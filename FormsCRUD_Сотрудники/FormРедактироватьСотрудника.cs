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
    public partial class FormРедактироватьСотрудника : Form
    {
        User Сотрудник_;
        public FormРедактироватьСотрудника(User Сотрудник_)
        {
            InitializeComponent();
            this.Сотрудник_ = Сотрудник_;
            this.textBox_ТекущееФио.Text = Сотрудник_.FullName;
            this.textBox_НовоеФио.Text = Сотрудник_.FullName;
        }

        private void button_Сохранить_Click(object sender, EventArgs e)
        {
            Accessor.СотрудникUpdte(Сотрудник_.ID, this.textBox_НовоеФио.Text);
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
