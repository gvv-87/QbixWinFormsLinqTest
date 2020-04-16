using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QbixPasswordsReturn
{
    partial class FormMain : Form
    {
        #region//-- dataGridView_Сотрудники_RowEnter() -- 
        private void dataGridView_Сотрудники_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            User сотрудник = dataGridView_Сотрудники.Rows[e.RowIndex].DataBoundItem as User;

        }
        #endregion/-- dataGridView_Сотрудники_RowEnter() -- 

        private void toolStripButtonAddСотрудника_Click(object sender, EventArgs e)
        {
            //FormДобавитьСотрудника modal = new FormДобавитьСотрудника();

            //modal.ShowDialog();

            //if (modal.DialogResult == DialogResult.OK) dataGridView_Сотрудники.DataSource = Accessor.GetTable_Сотрудники();
        }

        private void toolStripButtonEditСотрудника_Click(object sender, EventArgs e)
        {
            DataGridViewRow r_ = dataGridView_Сотрудники.CurrentRow;

            FormРедактироватьСотрудника modal = new FormРедактироватьСотрудника((User)r_.DataBoundItem);

            modal.ShowDialog();

            if (modal.DialogResult == DialogResult.OK) dataGridView_Сотрудники.DataSource = Accessor.GetTable_Users();
        }

        private void toolStripButtonDelСотрудника_Click(object sender, EventArgs e)
        {
            DataGridViewRow r_ = dataGridView_Сотрудники.CurrentRow;

            FormУдалитьСотрудника modal = new FormУдалитьСотрудника((User)r_.DataBoundItem);

            modal.ShowDialog();

            if (modal.DialogResult == DialogResult.OK) dataGridView_Сотрудники.DataSource = Accessor.GetTable_Users();

        }



    }
}
