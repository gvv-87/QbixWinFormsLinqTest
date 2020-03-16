using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Windows.Forms;


namespace QbixWinFormsLinqTest
{
    partial class Accessor
    {
        #region//-- GetTable_ДолжностиНавыки() ------------
        public static System.Data.Linq.Table<Должности_Навыки> GetTable_ДолжностиНавыки()
        {
            QbixTestDataContext dc = new QbixTestDataContext();
            return dc.GetTable<Должности_Навыки>();
        }
        #endregion/-- GetTable_ДолжностиНавыки() ------------

        #region//-- GetList_ДолжностьНавыки() ------------
        public static List<ДолжностьНавык> GetList_ДолжностьНавыки(int должность_Id_)
        {
            QbixTestDataContext dc = new QbixTestDataContext();
            return (from r_ in dc.Должности_Навыкиs
                    where r_.Должность_Id == должность_Id_
                    select new ДолжностьНавык
                    {
                        Должность_Id = r_.Должность_Id,
                        Навык_Id     = r_.Навык_Id,
                        Навык_Имя    = r_.Навык_Имя
                    }).ToList<ДолжностьНавык>();
        }
        #endregion/-- GetList_ДолжностьНавыки() ------------

        #region//-- СпрДолжностьНавыкUpdte() -- Обновить название навыка должности  --------
        /// <summary> Обновить название навыка должности</summary>
        /// <param name="Должность_Id_"></param>
        /// <param name="Навык_Id_"></param>
        /// <param name="Навык_Имя_"></param>
        public static bool СпрДолжностьНавыкUpdte(int Должность_Id_, int Навык_Id_, string Навык_Имя_)
        {
            QbixTestDataContext dc = new QbixTestDataContext();

            //-- Проверка на повтор названия навыка должности ----------------
            var навык_ = (from c in dc.Должности_Навыкиs
                              where c.Должность_Id == Должность_Id_ & c.Навык_Id != Навык_Id_ & c.Навык_Имя == Навык_Имя_
                              select c).SingleOrDefault();

            if (навык_ != null) { MessageBox.Show("У должности " + навык_.Должности.Должность_Имя+ "\r\n навык " + Навык_Имя_.ToString() + "\r\n уже есть"); return false; }


            var Навык_ = (from c in dc.Должности_Навыкиs
                              where c.Должность_Id == Должность_Id_ & c.Навык_Id == Навык_Id_
                          select c).Single();

            try
            {
                Навык_.Навык_Имя = Навык_Имя_;
                dc.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }
        #endregion/-- СпрДолжностьНавыкUpdte() -- Обновить название навыка должности  --------

        #region//-- СпрДолжностиНавыкиInsert() -- Вставить запись нового навыка ----------
        /// <summary>Вставить запись нового навыка</summary>
        /// <param name="Должность_Имя_"></param>
        public static bool СпрДолжностиНавыкиInsert(int Должность_Id_, string Навык_Имя_)
        {
            QbixTestDataContext dc = new QbixTestDataContext();
            Table<Должности_Навыки> ДолжностиНавыки = Accessor.GetTable_ДолжностиНавыки();

            //-- Проверка на повтор названия навыка должности ----------------
            var навык_ = (from c in ДолжностиНавыки
                          where c.Должность_Id == Должность_Id_  & c.Навык_Имя == Навык_Имя_
                          select c).SingleOrDefault();

            if (навык_ != null) { MessageBox.Show("У должности " + навык_.Должности.Должность_Имя + "\r\n навык " + Навык_Имя_.ToString() + "\r\n уже есть"); return false; }

            try
            {
                Должности_Навыки ДолжностьНавык_ = new Должности_Навыки();
                ДолжностьНавык_.Должность_Id     = Должность_Id_;
                ДолжностьНавык_.Навык_Имя        = Навык_Имя_;

                ДолжностиНавыки.InsertOnSubmit(ДолжностьНавык_);
                ДолжностиНавыки.Context.SubmitChanges();

                dc.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }
        #endregion/-- /-- СпрДолжностиНавыкиInsert() -- Вставить запись нового навыка ----------

        #region//-- СпрДолжностиНавыкиDelete() -----
        /// <summary>
        /// Удалить запись сотрудника и все его ассоциации
        /// </summary>
        /// <param name="Сотрудник_Id_"></param>
        public static void СпрДолжностиНавыкиDelete(int Сотрудник_Id_)
        {
            QbixTestDataContext dc = new QbixTestDataContext();

            var Сотрудник_ = (from c in dc.GetTable<Сотрудники>()
                              where c.Сотрудник_Id == Сотрудник_Id_
                              select c).SingleOrDefault();

            try
            {
                dc.Сотрудники_Должн_Навыкиs.DeleteAllOnSubmit<Сотрудники_Должн_Навыки>(Сотрудник_.Сотрудники_Должн_Навыкиs.ToList().Where(p => p.Сотрудник_Id == Сотрудник_.Сотрудник_Id));
                dc.Сотрудники_Должностиs.DeleteAllOnSubmit<Сотрудники_Должности>(Сотрудник_.Сотрудники_Должностиs.ToList().Where(p => p.Сотрудник_Id == Сотрудник_.Сотрудник_Id));
                dc.Сотрудникиs.DeleteOnSubmit(Сотрудник_);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion/-- СпрДолжностиНавыкиDelete() --------
    }
}