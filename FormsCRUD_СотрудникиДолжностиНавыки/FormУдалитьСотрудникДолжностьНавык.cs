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
    public partial class FormУдалитьСотрудникДолжностьНавык : Form
    {
        СотрудникДолжностьНавык СотрудникДолжность_;
        public FormУдалитьСотрудникДолжностьНавык(СотрудникДолжностьНавык СотрудникДолжность_)
        {
            InitializeComponent();
            this.СотрудникДолжность_ = СотрудникДолжность_;
            this.textBox_НавыкИмя.Text = СотрудникДолжность_.Навык_Имя;
        }

        private void button_Сохранить_Click(object sender, EventArgs e)
        {
            Accessor.СотрудникДолжностьНавыкDelete(СотрудникДолжность_.Сотрудник_Id, СотрудникДолжность_.Должность_Id, СотрудникДолжность_.Навык_Id);
            DialogResult = DialogResult.OK;
            this.Close();

        }

        private void button_НеСохранять_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}
