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
    partial class FormMain : Form
    {
        #region//-- dataGridView_Должности_RowEnter() -- 
        private void dataGridView_Должности_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            СотрудникДолжность должность = dataGridView_СотрудникДолжности.Rows[e.RowIndex].DataBoundItem as СотрудникДолжность;
            dataGridView_НавыкиДолжностиСотрудника.DataSource = Accessor.GetList_СотрудникДолжностьНавыки(должность);
        }
        #endregion/-- dataGridView_Должности_RowEnter() -- 

        #region//-- toolStripButtonAdd_ДолжностьСотрудника_Click() -- 
        private void toolStripButtonAdd_ДолжностьСотрудника_Click(object sender, EventArgs e)
        {
            FormСпрДолжности FormСпрДолжности_ = new FormСпрДолжности();
            FormСпрДолжности_.ShowDialog();
            Должности должность = FormСпрДолжности_.CurrentДолжность;
            Сотрудники сотрудник = dataGridView_Сотрудники.CurrentRow.DataBoundItem as Сотрудники;
            
            if ( должность!=null ) 
            { 
                Accessor.СотрудникДолжностьInsert(сотрудник.Сотрудник_Id, должность.Должность_Id);
                this.dataGridView_СотрудникДолжности.DataSource = Accessor.GetList_Сотрудник_Должности(сотрудник.Сотрудник_Id);
            }
        }
        #endregion/-- toolStripButtonAdd_ДолжностьСотрудника_Click() -- 

        #region//-- toolStripButtonDel_ДолжностьСотрудника_Click() -- 
        private void toolStripButtonDel_ДолжностьСотрудника_Click(object sender, EventArgs e)
        {
            DataGridViewRow r_ = dataGridView_СотрудникДолжности.CurrentRow;

            FormУдалитьДолжностьСотрудника modal = new FormУдалитьДолжностьСотрудника((СотрудникДолжность)r_.DataBoundItem);

            modal.ShowDialog();

            if (modal.DialogResult == DialogResult.OK) dataGridView_СотрудникДолжности.DataSource = Accessor.GetList_Сотрудник_Должности(((СотрудникДолжность)r_.DataBoundItem).Сотрудник_Id);

        }
        #endregion/-- toolStripButtonDel_ДолжностьСотрудника_Click() -- 

    }
}
