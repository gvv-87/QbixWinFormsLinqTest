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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            { 
                System.Data.Linq.Table<Сотрудники> emp = Accessor.GetTable_Сотрудники();
                dataGridView_Сотрудники.DataSource = emp;
            }
            catch(Exception ex_) { MessageBox.Show(ex_.Message); this.Close();}
        }

    }
}
