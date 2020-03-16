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
    public partial class FormСпрДолжностиНавыкиДобавить : Form
    {
        int должность_Id_;
        public FormСпрДолжностиНавыкиДобавить(int должность_Id_)
        {
            InitializeComponent();
            this.должность_Id_ = должность_Id_;
        }

        private void button_Сохранить_Click(object sender, EventArgs e)
        {
            bool ins_ = Accessor.СпрДолжностиНавыкиInsert(должность_Id_, this.textBox_НовыйНавык.Text);
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
