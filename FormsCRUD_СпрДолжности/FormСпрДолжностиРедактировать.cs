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
    public partial class FormСпрДолжностиРедактировать : Form
    {
        Должности Должность_;
        public FormСпрДолжностиРедактировать(Должности Должность_)
        {
            InitializeComponent();
            this.Должность_              = Должность_;
            this.textBox_ТекущееФио.Text = Должность_.Должность_Имя;
            this.textBox_НовоеИмяДолжности.Text   = Должность_.Должность_Имя;
        }

        private void button_Сохранить_Click(object sender, EventArgs e)
        {
            Accessor.СпрДолжностьUpdte(Должность_.Должность_Id, this.textBox_НовоеИмяДолжности.Text);
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
