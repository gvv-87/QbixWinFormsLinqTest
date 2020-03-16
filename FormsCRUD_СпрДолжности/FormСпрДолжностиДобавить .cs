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
    public partial class FormСпрДолжностиДобавить : Form
    {
        public FormСпрДолжностиДобавить()
        {
            InitializeComponent();
        }


        private void button_Сохранить_Click(object sender, EventArgs e)
        {
            bool ins_ = Accessor.СпрДолжностьInsert(this.textBox_НоваяДолжность.Text);
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
