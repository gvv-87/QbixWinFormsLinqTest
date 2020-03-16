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
    public partial class FormУдалитьДолжностьСотрудника : Form
    {
        СотрудникДолжность СотрудникДолжность_;
        public FormУдалитьДолжностьСотрудника(СотрудникДолжность СотрудникДолжность_)
        {
            InitializeComponent();
            this.СотрудникДолжность_ = СотрудникДолжность_;
            this.textBox_ДолжностьИмя.Text = СотрудникДолжность_.Должность_Имя;
        }

        private void button_Сохранить_Click(object sender, EventArgs e)
        {
            Accessor.СотрудникДолжностьDelete(СотрудникДолжность_.Сотрудник_Id, СотрудникДолжность_.Должность_Id);
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
