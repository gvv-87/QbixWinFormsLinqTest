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
        #region//-- dataGridView_Сотрудники_RowEnter() -- 
        private void dataGridView_Сотрудники_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Сотрудники сотрудник = dataGridView_Сотрудники.Rows[e.RowIndex].DataBoundItem as Сотрудники;

            if (сотрудник != null)
            {
                dataGridView_СотрудникДолжности.DataSource = Accessor.GetList_Сотрудник_Должности(сотрудник.Сотрудник_Id);
                if (dataGridView_СотрудникДолжности.RowCount == 0)
                {     
                    СотрудникДолжность должность = new СотрудникДолжность();
                    this.dataGridView_НавыкиДолжностиСотрудника.DataSource = Accessor.GetList_СотрудникДолжностьНавыки(должность);
                }
            }
        }
        #endregion/-- dataGridView_Сотрудники_RowEnter() -- 

        private void toolStripButtonAddСотрудника_Click(object sender, EventArgs e)
        {
            FormДобавитьСотрудника modal = new FormДобавитьСотрудника();

            modal.ShowDialog();

            if (modal.DialogResult == DialogResult.OK) dataGridView_Сотрудники.DataSource = Accessor.GetTable_Сотрудники();
        }

        private void toolStripButtonEditСотрудника_Click(object sender, EventArgs e)
        {
            DataGridViewRow r_ = dataGridView_Сотрудники.CurrentRow;

            FormРедактироватьСотрудника modal = new FormРедактироватьСотрудника((Сотрудники)r_.DataBoundItem);

            modal.ShowDialog();

            if (modal.DialogResult == DialogResult.OK) dataGridView_Сотрудники.DataSource = Accessor.GetTable_Сотрудники();
        }

        private void toolStripButtonDelСотрудника_Click(object sender, EventArgs e)
        {
            DataGridViewRow r_ = dataGridView_Сотрудники.CurrentRow;

            FormУдалитьСотрудника modal = new FormУдалитьСотрудника((Сотрудники)r_.DataBoundItem);

            modal.ShowDialog();

            if (modal.DialogResult == DialogResult.OK) dataGridView_Сотрудники.DataSource = Accessor.GetTable_Сотрудники();

        }



    }
}
