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
    public partial class FormРедактироватьСотрудника : Form
    {
        Сотрудники Сотрудник_;
        public FormРедактироватьСотрудника(Сотрудники Сотрудник_)
        {
            InitializeComponent();
            this.Сотрудник_ = Сотрудник_;
            this.textBox_ТекущееФио.Text = Сотрудник_.Сотрудник_Фио;
            this.textBox_НовоеФио.Text = Сотрудник_.Сотрудник_Фио;
        }

        private void button_Сохранить_Click(object sender, EventArgs e)
        {
            Accessor.СотрудникUpdte(Сотрудник_.Сотрудник_Id, this.textBox_НовоеФио.Text);
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
