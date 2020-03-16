using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Windows.Forms;

namespace QbixWinFormsLinqTest
{
    public   partial class Accessor
    {
        #region//-- GetTable_Сотрудники_Должности() -- Получить таблицу должностей всех сотрудников----------
        public static System.Data.Linq.Table<Сотрудники_Должности> GetTable_Сотрудники_Должности()
        {
            QbixTestDataContext dc = new QbixTestDataContext();
            return dc.GetTable<Сотрудники_Должности>();
        }
        #endregion/-- GetTable_Сотрудники_Должности() -- Получить таблицу должностей всех сотрудников----------

        #region//-- GetList_Сотрудник_Должности() -- Получить список должностей сотрудника----------
        /// <summary>Получить список должностей сотрудника</summary>
        /// <param name="сотрудник_Id_"></param>
        /// <returns></returns>
        public static List<СотрудникДолжность> GetList_Сотрудник_Должности(int сотрудник_Id_)
        {
            QbixTestDataContext dc = new QbixTestDataContext();
           return (from pos in dc.Сотрудники_Должностиs
                   join p in dc.Должностиs on pos.Должность_Id equals p.Должность_Id
                   where pos.Сотрудник_Id == сотрудник_Id_
                   select new СотрудникДолжность
                   {
                        Сотрудник_Id  = pos.Сотрудник_Id,
                        Должность_Id  = pos.Должность_Id,
                        Должность_Имя = p.Должность_Имя
                   }).ToList<СотрудникДолжность>();
        }
        #endregion/-- GetList_Сотрудник_Должности() -- Получить список должностей сотрудника----------

        #region//-- СотрудникДолжностьInsert() ------------
        /// <summary>Вставить запись новой должности сотрудника</summary>
        /// <param name="Должность_Id_"></param>
        public static bool СотрудникДолжностьInsert(int Сотрудник_Id_, int Должность_Id_)
        {
            try
            {
                Table<Сотрудники_Должности> ДолжностиСотрудники = Accessor.GetTable_Сотрудники_Должности();

                var должность_ = (from c in ДолжностиСотрудники
                                  where (c.Должность_Id == Должность_Id_ & c.Сотрудник_Id == Сотрудник_Id_)
                                  select c).SingleOrDefault();

                if (должность_ != null) { MessageBox.Show("У сотрудника \r\n" + должность_.Сотрудники.Сотрудник_Фио + "\r\n" + "должность "+должность_.Должности.Должность_Имя + "\r\n уже есть"); return false; }

                Сотрудники_Должности СотрудникДолжность_ = new Сотрудники_Должности();
                СотрудникДолжность_.Сотрудник_Id = Сотрудник_Id_;
                СотрудникДолжность_.Должность_Id = Должность_Id_;

                ДолжностиСотрудники.InsertOnSubmit(СотрудникДолжность_);
                ДолжностиСотрудники.Context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }
        #endregion/-- СотрудникДолжностьInsert() ------------

        #region//-- СотрудникДолжностьDelete() -----
        /// <summary>
        /// Удалить запись должности сотрудника и все её ассоциации
        /// </summary>
        /// <param name="Сотрудник_Id_"></param>
        /// <param name="Должность_Id_"></param>
        public static void СотрудникДолжностьDelete(int Сотрудник_Id_, int Должность_Id_)
        {
            QbixTestDataContext dc = new QbixTestDataContext();
            var Сотрудник_ = (from c in dc.GetTable<Сотрудники>()
                              where c.Сотрудник_Id == Сотрудник_Id_
                              select c).SingleOrDefault();



            var СотрудникДолжность_ = (from c in dc.GetTable<Сотрудники_Должности>()
                              where c.Сотрудник_Id == Сотрудник_Id_ & c.Должность_Id == Должность_Id_
                              select c).SingleOrDefault();

            try
            {
                dc.Сотрудники_Должн_Навыкиs.DeleteAllOnSubmit<Сотрудники_Должн_Навыки>(Сотрудник_.Сотрудники_Должн_Навыкиs.ToList().Where(p => p.Сотрудник_Id == Сотрудник_Id_ & p.Должность_Id == Должность_Id_));
                dc.Сотрудники_Должностиs.DeleteAllOnSubmit<Сотрудники_Должности>(Сотрудник_.Сотрудники_Должностиs.ToList().Where(p => p.Сотрудник_Id == Сотрудник_Id_ & p.Должность_Id == Должность_Id_));
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion/-- СотрудникДолжностьDelete() --------






    }
}
