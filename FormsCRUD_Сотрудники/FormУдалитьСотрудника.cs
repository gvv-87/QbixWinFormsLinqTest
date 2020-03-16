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
    public partial class FormУдалитьСотрудника : Form
    {
        Сотрудники Сотрудники_;
        public FormУдалитьСотрудника(Сотрудники Сотрудники_)
        {
            InitializeComponent();
            this.Сотрудники_ = Сотрудники_;
            this.textBox_ТекущееФио.Text = Сотрудники_.Сотрудник_Фио;
        }

        private void button_Сохранить_Click(object sender, EventArgs e)
        {
            Accessor.СотрудникDelete(Сотрудники_.Сотрудник_Id);
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
