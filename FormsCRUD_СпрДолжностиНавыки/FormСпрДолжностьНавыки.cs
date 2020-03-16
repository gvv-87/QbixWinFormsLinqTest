using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QbixWinFormsLinqTest
{
    /// <summary>
    /// Справочник навыков должностей
    /// </summary>
    public partial class FormСпрДолжностьНавыки : Form
    {
        ДолжностьНавык r_ = null;
        public ДолжностьНавык CurrentДолжность { get {return r_; } set { r_= value;} }
        СотрудникДолжность СотрудникДолжность_;

        #region//--  FormСпрДолжностьНавыки() -- КОНСТРУКТОР --------
        public FormСпрДолжностьНавыки(СотрудникДолжность СотрудникДолжность_)
        {
            InitializeComponent();
            this.СотрудникДолжность_ = СотрудникДолжность_;
            this.dataGridView_СпрДолжностиНавыки.DataSource = Accessor.GetList_ДолжностьНавыки(СотрудникДолжность_.Должность_Id);
            this.Text = "Навыки должности: "+ СотрудникДолжность_.Должность_Имя;
        }
        #endregion/--  FormСпрДолжностьНавыки() -- КОНСТРУКТОР --------

        #region//-- dataGridView_СпрДолжностиНавыки_RowHeaderMouseDoubleClick() -- Выбрать строку навыка должности из справочника навыков --------
        private void dataGridView_СпрДолжностиНавыки_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dv = (DataGridView)sender;
            r_              = (ДолжностьНавык)dv.CurrentRow.DataBoundItem;
            DialogResult    = DialogResult.OK;
            this.Close();
        }
        #endregion/-- dataGridView_СпрДолжностиНавыки_RowHeaderMouseDoubleClick() -- Выбрать строку навыка должности из справочника навыков --------

        #region//-- toolStripButtonAdd_СпрДолжностиНавыки_Click() -- Добавить новый навык  должности в справочник --------
        private void toolStripButtonAdd_СпрДолжностиНавыки_Click(object sender, EventArgs e)
        {
            FormСпрДолжностиНавыкиДобавить FormСпрДолжностиНавыкиДобавить_ = new FormСпрДолжностиНавыкиДобавить(СотрудникДолжность_.Должность_Id);
            FormСпрДолжностиНавыкиДобавить_.ShowDialog();
            if (FormСпрДолжностиНавыкиДобавить_.DialogResult == DialogResult.OK)
                this.dataGridView_СпрДолжностиНавыки.DataSource = Accessor.GetList_ДолжностьНавыки(СотрудникДолжность_.Должность_Id); ;
        }
        #endregion/-- toolStripButtonAdd_СпрДолжностиНавыки_Click() -- Добавить новый навык  должности в справочник --------

        #region//-- toolStripButtonEdit_СпрДолжностиНавыки_Click() -- Изменить название навыка в справочнике --------
        private void toolStripButtonEdit_СпрДолжностиНавыки_Click(object sender, EventArgs e)
        {
            DataGridViewRow r_ = dataGridView_СпрДолжностиНавыки.CurrentRow ;

            FormСпрДолжностиНавыкиРедактировать modal = new FormСпрДолжностиНавыкиРедактировать((ДолжностьНавык)r_.DataBoundItem);

            modal.ShowDialog();

            if (modal.DialogResult == DialogResult.OK) dataGridView_СпрДолжностиНавыки.DataSource = Accessor.GetList_ДолжностьНавыки(((ДолжностьНавык)r_.DataBoundItem).Должность_Id);
        }
        #endregion/-- toolStripButtonEdit_СпрДолжностиНавыки_Click() -- Изменить название навыка в справочнике --------
    }
}
