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
    public partial class FormУдалитьСотрудника : Form
    {
        User Сотрудники_;
        public FormУдалитьСотрудника(User Сотрудники_)
        {
            InitializeComponent();
            this.Сотрудники_ = Сотрудники_;
            this.textBox_ТекущееФио.Text = Сотрудники_.FullName;
        }

        private void button_Сохранить_Click(object sender, EventArgs e)
        {
            Accessor.СотрудникDelete(Сотрудники_.ID);
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
