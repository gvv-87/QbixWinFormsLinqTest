using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;


namespace QbixWinFormsLinqTest
{
    partial class Accessor
    {
        #region//-- GetTable_Сотрудники() ------------
        public static System.Data.Linq.Table<Сотрудники> GetTable_Сотрудники()
        {
            QbixTestDataContext dc = new QbixTestDataContext();
            return dc.GetTable<Сотрудники>();
        }
        #endregion/-- GetTable_Сотрудники() ------------

        #region//-- СотрудникInsert() ------------
        /// <summary>Вставить запись нового сотрудника</summary>
        /// <param name="Сотрудник_Фио_"></param>
        public static void СотрудникInsert(string Сотрудник_Фио_)
        {
            try
            {
                Table<Сотрудники> сотрудники = Accessor.GetTable_Сотрудники();
                Сотрудники Сотрудник_        = new Сотрудники();
                Сотрудник_.Сотрудник_Фио     = Сотрудник_Фио_;

                сотрудники.InsertOnSubmit(Сотрудник_);
                сотрудники.Context.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion/-- СотрудникInsert() ------------

        #region//-- СотрудникUpdte() -----
        /// <summary>
        /// Обновить запись сотрудника
        /// </summary>
        /// <param name="Сотрудник_Id_"></param>
        /// <param name="Сотрудник_Фио_"></param>
        public static void СотрудникUpdte(int Сотрудник_Id_, string Сотрудник_Фио_)
        {
            QbixTestDataContext dc = new QbixTestDataContext();

            var Сотрудник_ = (from c in dc.GetTable<Сотрудники>()
                              where c.Сотрудник_Id == Сотрудник_Id_
                              select c).SingleOrDefault();

            try
            {
                Сотрудник_.Сотрудник_Фио = Сотрудник_Фио_;
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion/-- СотрудникUpdte() --------

        #region//-- СотрудникDelete() -----
        /// <summary>
        /// Удалить запись сотрудника и все его ассоциации
        /// </summary>
        /// <param name="Сотрудник_Id_"></param>
        public static void СотрудникDelete(int Сотрудник_Id_)
        {
            QbixTestDataContext dc = new QbixTestDataContext();

            var Сотрудник_ = (from c in dc.GetTable<Сотрудники>()
                              where c.Сотрудник_Id == Сотрудник_Id_
                              select c).SingleOrDefault();

            try
            {
                dc.Сотрудники_Должн_Навыкиs.DeleteAllOnSubmit<Сотрудники_Должн_Навыки>(Сотрудник_.Сотрудники_Должн_Навыкиs.ToList().Where(p=>p.Сотрудник_Id == Сотрудник_.Сотрудник_Id));
                dc.Сотрудники_Должностиs.DeleteAllOnSubmit<Сотрудники_Должности>(Сотрудник_.Сотрудники_Должностиs.ToList().Where(p => p.Сотрудник_Id == Сотрудник_.Сотрудник_Id));
                dc.Сотрудникиs.DeleteOnSubmit(Сотрудник_);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion/-- СотрудникDelete() --------
    }
}