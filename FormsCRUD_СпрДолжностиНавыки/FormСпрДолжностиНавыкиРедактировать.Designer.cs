namespace QbixWinFormsLinqTest
{
    partial class FormСпрДолжностиНавыкиРедактировать
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormСпрДолжностиРедактировать));
            this.button_Сохранить = new System.Windows.Forms.Button();
            this.button_НеСохранять = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ТекущееФио = new System.Windows.Forms.TextBox();
            this.textBox_НовоеИмяНавыка = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Сохранить
            // 
            this.button_Сохранить.Location = new System.Drawing.Point(60, 107);
            this.button_Сохранить.Name = "button_Сохранить";
            this.button_Сохранить.Size = new System.Drawing.Size(75, 23);
            this.button_Сохранить.TabIndex = 0;
            this.button_Сохранить.Text = "Сохранить";
            this.button_Сохранить.UseVisualStyleBackColor = true;
            this.button_Сохранить.Click += new System.EventHandler(this.button_Сохранить_Click);
            // 
            // button_НеСохранять
            // 
            this.button_НеСохранять.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_НеСохранять.Location = new System.Drawing.Point(169, 107);
            this.button_НеСохранять.Name = "button_НеСохранять";
            this.button_НеСохранять.Size = new System.Drawing.Size(91, 23);
            this.button_НеСохранять.TabIndex = 1;
            this.button_НеСохранять.Text = "Не сохранять";
            this.button_НеСохранять.UseVisualStyleBackColor = true;
            this.button_НеСохранять.Click += new System.EventHandler(this.button_НеСохранять_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Текущее имя должности";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Новое имя должности";
            // 
            // textBox_ТекущееФио
            // 
            this.textBox_ТекущееФио.Enabled = false;
            this.textBox_ТекущееФио.Location = new System.Drawing.Point(156, 22);
            this.textBox_ТекущееФио.Name = "textBox_ТекущееФио";
            this.textBox_ТекущееФио.ReadOnly = true;
            this.textBox_ТекущееФио.Size = new System.Drawing.Size(135, 20);
            this.textBox_ТекущееФио.TabIndex = 4;
            // 
            // textBox_НовоеФио
            // 
            this.textBox_НовоеИмяНавыка.Location = new System.Drawing.Point(156, 48);
            this.textBox_НовоеИмяНавыка.Name = "textBox_НовоеФио";
            this.textBox_НовоеИмяНавыка.Size = new System.Drawing.Size(135, 20);
            this.textBox_НовоеИмяНавыка.TabIndex = 5;
            // 
            // FormСпрДолжностиРедактировать
            // 
            this.AcceptButton = this.button_Сохранить;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_НеСохранять;
            this.ClientSize = new System.Drawing.Size(320, 144);
            this.Controls.Add(this.textBox_НовоеИмяНавыка);
            this.Controls.Add(this.textBox_ТекущееФио);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_НеСохранять);
            this.Controls.Add(this.button_Сохранить);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormСпрДолжностиРедактировать";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактировать сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Сохранить;
        private System.Windows.Forms.Button button_НеСохранять;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ТекущееФио;
        private System.Windows.Forms.TextBox textBox_НовоеИмяНавыка;
    }
}