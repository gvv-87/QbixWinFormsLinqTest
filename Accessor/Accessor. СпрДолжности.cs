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
        #region//-- GetTable_Должности() ------------
        public static System.Data.Linq.Table<Должности> GetTable_Должности()
        {
            QbixTestDataContext dc = new QbixTestDataContext();
            return dc.GetTable<Должности>();
        }
        #endregion/-- GetTable_Должностьи() ------------

        #region//-- СпрДолжностьInsert() ------------
        /// <summary>Вставить запись новой должности</summary>
        /// <param name="Должность_Имя_"></param>
        public static bool СпрДолжностьInsert(string Должность_Имя_)
        {
            try
            {
                Table<Должности> Должности  = Accessor.GetTable_Должности();

                var должность_ = (from c in Должности
                                  where c.Должность_Имя == Должность_Имя_
                                  select c).SingleOrDefault();

                if (должность_ != null) {MessageBox.Show(Должность_Имя_.ToString()+" - такая должность уже есть"); return false;  }

                Должности Должность_         = new Должности();
                Должность_.Должность_Имя     = Должность_Имя_;

                Должности.InsertOnSubmit(Должность_);
                Должности.Context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }
        #endregion/-- СпрДолжностьInsert() ------------

        #region//-- СпрДолжностьUpdte() -- Обновить название должности в справочнике--------
        /// <summary> Обновить название должности</summary>
        /// <param name="Должность_Id_"></param>
        /// <param name="Должность_Имя_"></param>
        public static bool СпрДолжностьUpdte(int Должность_Id_, string Должность_Имя_)
        {
            QbixTestDataContext dc = new QbixTestDataContext();
            
            //-- Проверка на повтор названия должности ----------------
            var должность_ = (from c in dc.GetTable<Должности>()
                              where c.Должность_Id != Должность_Id_ & c.Должность_Имя == Должность_Имя_
                              select c).SingleOrDefault();
            
            if (должность_ != null) { MessageBox.Show(Должность_Имя_.ToString()+ "/r/n - такая должность уже есть"); return false; }


            var Должность_ = (from c in dc.GetTable<Должности>()
                              where c.Должность_Id == Должность_Id_
                              select c).SingleOrDefault();

            try
            {
                Должность_.Должность_Имя = Должность_Имя_;
                dc.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
        }
        #endregion/-- СпрДолжностьUpdte() --------

        #region//-- СпрДолжностьDelete() -----
        /// <summary>
        /// Удалить запись Должность и все её ассоциации
        /// </summary>
        /// <param name="Должность_Id_"></param>
        public static void СпрДолжностьDelete(int Должность_Id_)
        {
            QbixTestDataContext dc = new QbixTestDataContext();

            var Должность_ = (from c in dc.GetTable<Должности>()
                              where c.Должность_Id == Должность_Id_
                              select c).SingleOrDefault();

            try
            {
                //dc.Сотрудники_Должн_Навыкиs.DeleteAllOnSubmit<Сотрудники_Должн_Навыки>(Должность_.Должности_Навыкиs.ToList().Where(p=>p.Должность_Id == Должность_.Должность_Id));
                //dc.Сотрудники_Должностиs.DeleteAllOnSubmit<Сотрудники_Должности>(Должность_.Должностьи_Должностиs.ToList().Where(p => p.Должность_Id == Должность_.Должность_Id));
                //dc.Сотрудникиs.DeleteOnSubmit(Должность_);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion/-- СпрДолжностьDelete() --------
    }
}