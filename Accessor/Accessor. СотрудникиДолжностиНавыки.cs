using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Windows.Forms;

namespace QbixWinFormsLinqTest
{
    public   partial class Accessor
    {
        #region//-- GetTable_Сотрудники() ------------
        public static System.Data.Linq.Table<Сотрудники_Должн_Навыки> GetTable_Сотрудники_Должн_Навыки()
        {
            QbixTestDataContext dc = new QbixTestDataContext();
            return dc.GetTable<Сотрудники_Должн_Навыки>();
        }
        #endregion/-- GetTable_Сотрудники() ------------

        #region//-- GetList_СотрудникДолжностьНавыки() -- Получить список навыков сотрудника по должности ----------
        /// <summary>
        /// Получить список навыков сотрудника по должности
        /// </summary>
        /// <param name="СотрудникДолжность_"></param>
        /// <returns></returns>
        public static List<СотрудникДолжностьНавык> GetList_СотрудникДолжностьНавыки(СотрудникДолжность СотрудникДолжность_)
        {
            QbixTestDataContext dc = new QbixTestDataContext();
            
            var d =(from c in dc.Сотрудники_Должн_Навыкиs
                    join p in dc.Должности_Навыкиs on c.Навык_Id equals p.Навык_Id
                    where   ( c.Сотрудник_Id == СотрудникДолжность_.Сотрудник_Id 
                              & 
                              c.Должность_Id == СотрудникДолжность_.Должность_Id
                            )
                    select new СотрудникДолжностьНавык
                    {
                        Сотрудник_Id = c.Сотрудник_Id,
                        Должность_Id = c.Должность_Id,
                        Навык_Id     = p.Навык_Id,
                        Навык_Имя    = p.Навык_Имя
                    });
                return d.ToList<СотрудникДолжностьНавык>();
        }
        #endregion/-- GetList_СотрудникДолжностьНавыки()  -- Получить список навыков сотрудника по должности ----------

        #region//-- СотрудникДолжностьНавыкInsert() ------------
        /// <summary>Вставить запись нового навыка должности сотрудника</summary>
        /// <param name="Сотрудник_Id_"></param>
        /// <param name="Должность_Id_"></param>
        /// <param name="Навык_Id_"></param>
        public static bool СотрудникДолжностьНавыкInsert(int Сотрудник_Id_, int Должность_Id_, int Навык_Id_)
        {
            try
            {
                Table<Сотрудники_Должн_Навыки> СотрудникиДолжнНавыки = Accessor.GetTable_Сотрудники_Должн_Навыки();

                var должность_ = (from c in СотрудникиДолжнНавыки
                                  where (c.Должность_Id == Должность_Id_ & c.Сотрудник_Id == Сотрудник_Id_ & c.Навык_Id == Навык_Id_)
                                  select c).SingleOrDefault();

                if (должность_ != null) { MessageBox.Show("У сотрудника \r\n" + должность_.Сотрудники.Сотрудник_Фио + "\r\n" + "навык  " + должность_.Должности_Навыки.Навык_Имя + "\r\n уже есть"); return false; }

                Сотрудники_Должн_Навыки Сотрудники_Должн_Навыки_ = new Сотрудники_Должн_Навыки();
                Сотрудники_Должн_Навыки_.Сотрудник_Id            = Сотрудник_Id_;
                Сотрудники_Должн_Навыки_.Должность_Id            = Должность_Id_;
                Сотрудники_Должн_Навыки_.Навык_Id                = Навык_Id_;

                СотрудникиДолжнНавыки.InsertOnSubmit(Сотрудники_Должн_Навыки_);
                СотрудникиДолжнНавыки.Context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }
        #endregion/-- СотрудникДолжностьНавыкInsert() ------------

        #region//-- СотрудникДолжностьНавыкDelete() -- Удалить запись навыка должности сотрудника ---
        /// <summary>Удалить запись навыка должности сотрудника</summary>
        /// <param name="Сотрудник_Id_"></param>
        /// <param name="Должность_Id_"></param>
        /// <param name="Навык_Id_"></param>
        public static bool СотрудникДолжностьНавыкDelete(int Сотрудник_Id_, int Должность_Id_, int Навык_Id_)
        {
            QbixTestDataContext dc = new QbixTestDataContext();

            try
            {
                dc.Сотрудники_Должн_Навыкиs
                    .DeleteAllOnSubmit<Сотрудники_Должн_Навыки>(from c in dc.GetTable<Сотрудники_Должн_Навыки>()
                                                                                       where c.Сотрудник_Id == Сотрудник_Id_
                                                                                       & c.Должность_Id == Должность_Id_
                                                                                       & c.Навык_Id == Навык_Id_
                                                                                       select c);
                dc.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion/-- СпрДолжностиНавыкиDelete() --------
    }
}
