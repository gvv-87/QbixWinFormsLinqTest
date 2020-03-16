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

        #region//-- toolStripButtonAdd_НавыкиДолжностиСотрудника_Click() -- 
        private void toolStripButtonAdd_НавыкиДолжностиСотрудника_Click(object sender, EventArgs e)
        {
            СотрудникДолжность СотрудникДолжность_         = dataGridView_СотрудникДолжности.CurrentRow.DataBoundItem as СотрудникДолжность;
            FormСпрДолжностьНавыки FormСпрДолжностьНавыки_ = new FormСпрДолжностьНавыки(СотрудникДолжность_);
            FormСпрДолжностьНавыки_.ShowDialog();
            ДолжностьНавык ДолжностьНавык_                 = FormСпрДолжностьНавыки_.CurrentДолжность;

            if (ДолжностьНавык_ != null)
            {
                Accessor.СотрудникДолжностьНавыкInsert(СотрудникДолжность_.Сотрудник_Id, ДолжностьНавык_.Должность_Id, ДолжностьНавык_.Навык_Id);
                this.dataGridView_НавыкиДолжностиСотрудника.DataSource = Accessor.GetList_СотрудникДолжностьНавыки(СотрудникДолжность_);
            }
        }
        #endregion/-- toolStripButtonAdd_НавыкиДолжностиСотрудника_Click() -- 


        #region//-- toolStripButtonDel_НавыкиДолжностиСотрудника_Click() -- 
        private void toolStripButtonDel_НавыкиДолжностиСотрудника_Click(object sender, EventArgs e)
        {
            СотрудникДолжность СотрудникДолжность_ = this.dataGridView_СотрудникДолжности.CurrentRow.DataBoundItem as СотрудникДолжность;
            DataGridViewRow r_ = this.dataGridView_НавыкиДолжностиСотрудника.CurrentRow;
            FormУдалитьСотрудникДолжностьНавык modal = new FormУдалитьСотрудникДолжностьНавык((СотрудникДолжностьНавык)r_.DataBoundItem);

            modal.ShowDialog();

            if (modal.DialogResult == DialogResult.OK)
            {     
                this.dataGridView_НавыкиДолжностиСотрудника.DataSource = Accessor.GetList_СотрудникДолжностьНавыки(СотрудникДолжность_);
            }
        }
        #endregion/-- toolStripButtonDel_НавыкиДолжностиСотрудника_Click() -- 

    }
}
