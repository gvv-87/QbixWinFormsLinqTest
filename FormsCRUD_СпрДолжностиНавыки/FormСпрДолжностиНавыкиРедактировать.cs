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
    public partial class FormСпрДолжностиНавыкиРедактировать : Form
    {
        ДолжностьНавык ДолжностьНавык_;
        public FormСпрДолжностиНавыкиРедактировать(ДолжностьНавык ДолжностьНавык_)
        {
            InitializeComponent();
            this.ДолжностьНавык_               = ДолжностьНавык_;
            this.textBox_ТекущееФио.Text       = ДолжностьНавык_.Навык_Имя;
            this.textBox_НовоеИмяНавыка.Text   = ДолжностьНавык_.Навык_Имя;
        }

        private void button_Сохранить_Click(object sender, EventArgs e)
        {
            Accessor.СпрДолжностьНавыкUpdte(ДолжностьНавык_.Должность_Id, ДолжностьНавык_.Навык_Id, this.textBox_НовоеИмяНавыка.Text);
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
