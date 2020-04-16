using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;


namespace QbixPasswordsReturn
{
    partial class Accessor
    {
        #region//-- GetTable_Сотрудники() ------------
        public static System.Data.Linq.Table<User> GetTable_Users()
        {
            QbixDataContext dc = new QbixDataContext();
            return dc.GetTable<User>();
        }
        #endregion/-- GetTable_Сотрудники() ------------

        #region//-- СотрудникInsert() ------------
        /// <summary>Вставить запись нового сотрудника</summary>
        /// <param name="Сотрудник_Фио_"></param>
        public static void СотрудникInsert(string Сотрудник_Фио_)
        {
            try
            {
                Table<User> сотрудники = Accessor.GetTable_Users();
                User Сотрудник_        = new User();
                Сотрудник_.FullName     = Сотрудник_Фио_;

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
        public static void СотрудникUpdte(Guid Сотрудник_Id_, string Сотрудник_Фио_)
        {
            QbixDataContext dc = new QbixDataContext();

            var Сотрудник_ = (from c in dc.GetTable<User>()
                              where c.ID == Сотрудник_Id_
                              select c).SingleOrDefault();

            try
            {
                Сотрудник_.FullName = Сотрудник_Фио_;
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
        public static void СотрудникDelete(Guid Сотрудник_Id_)
        {
            QbixDataContext dc = new QbixDataContext();

            var Сотрудник_ = (from c in dc.GetTable<User>()
                              where c.ID == Сотрудник_Id_
                              select c).SingleOrDefault();

            try
            {
                dc.Users.DeleteOnSubmit(Сотрудник_);
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