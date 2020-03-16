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
    public partial class FormСпрДолжности : Form
    {
        Должности r_ = null;
        public Должности CurrentДолжность { get {return r_; } set { r_= value;} }
        public FormСпрДолжности()
        {
            InitializeComponent();
            this.dataGridViewСпр_Должности.DataSource = Accessor.GetTable_Должности();
        }

        #region//-- dataGridViewСпр_Должности_RowHeaderMouseDoubleClick() -- Выбрать строку должности из справочника должностей --------
        private void dataGridViewСпр_Должности_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dv = (DataGridView)sender;
            r_              = (Должности)dv.CurrentRow.DataBoundItem;
            DialogResult    = DialogResult.OK;
            this.Close();
        }
        #endregion/-- dataGridViewСпр_Должности_RowHeaderMouseDoubleClick() -- Выбрать строку должности из справочника должностей --------

        #region//-- toolStripButtonAdd_СпрДолжности_Click() -- Добавить новую должность в справочник --------
        private void toolStripButtonAdd_СпрДолжности_Click(object sender, EventArgs e)
        {
            FormСпрДолжностиДобавить FormСпрДолжностиДобавить_ = new FormСпрДолжностиДобавить();
            FormСпрДолжностиДобавить_.ShowDialog();
            if (FormСпрДолжностиДобавить_.DialogResult == DialogResult.OK)
                this.dataGridViewСпр_Должности.DataSource = Accessor.GetTable_Должности();
        }
        #endregion/-- toolStripButtonAdd_СпрДолжности_Click() -- Добавить новую должность в справочнк --------

        private void toolStripButtonEdit_СпрДолжности_Click(object sender, EventArgs e)
        {
            DataGridViewRow r_ = dataGridViewСпр_Должности.CurrentRow;

            FormСпрДолжностиРедактировать modal = new FormСпрДолжностиРедактировать((Должности)r_.DataBoundItem);

            modal.ShowDialog();

            if (modal.DialogResult == DialogResult.OK) dataGridViewСпр_Должности.DataSource = Accessor.GetTable_Должности();

        }
    }
}
