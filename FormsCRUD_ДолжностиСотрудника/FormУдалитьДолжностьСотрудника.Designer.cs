namespace QbixWinFormsLinqTest
{
    partial class FormУдалитьДолжностьСотрудника
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormУдалитьДолжностьСотрудника));
            this.button_Сохранить = new System.Windows.Forms.Button();
            this.button_НеСохранять = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ДолжностьИмя = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Сохранить
            // 
            this.button_Сохранить.Location = new System.Drawing.Point(12, 107);
            this.button_Сохранить.Name = "button_Сохранить";
            this.button_Сохранить.Size = new System.Drawing.Size(75, 23);
            this.button_Сохранить.TabIndex = 0;
            this.button_Сохранить.Text = "Удалить";
            this.button_Сохранить.UseVisualStyleBackColor = true;
            this.button_Сохранить.Click += new System.EventHandler(this.button_Сохранить_Click);
            // 
            // button_НеСохранять
            // 
            this.button_НеСохранять.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_НеСохранять.Location = new System.Drawing.Point(115, 107);
            this.button_НеСохранять.Name = "button_НеСохранять";
            this.button_НеСохранять.Size = new System.Drawing.Size(91, 23);
            this.button_НеСохранять.TabIndex = 1;
            this.button_НеСохранять.Text = "Не удалять";
            this.button_НеСохранять.UseVisualStyleBackColor = true;
            this.button_НеСохранять.Click += new System.EventHandler(this.button_НеСохранять_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Удалить должность сотрудника ?";
            // 
            // textBox_ТекущееФио
            // 
            this.textBox_ДолжностьИмя.Enabled = false;
            this.textBox_ДолжностьИмя.Location = new System.Drawing.Point(45, 52);
            this.textBox_ДолжностьИмя.Name = "textBox_ТекущееФио";
            this.textBox_ДолжностьИмя.ReadOnly = true;
            this.textBox_ДолжностьИмя.Size = new System.Drawing.Size(161, 20);
            this.textBox_ДолжностьИмя.TabIndex = 4;
            // 
            // FormУдалитьДолжностьСотрудника
            // 
            this.AcceptButton = this.button_Сохранить;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_НеСохранять;
            this.ClientSize = new System.Drawing.Size(236, 144);
            this.Controls.Add(this.textBox_ДолжностьИмя);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_НеСохранять);
            this.Controls.Add(this.button_Сохранить);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormУдалитьДолжностьСотрудника";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удаление должности сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Сохранить;
        private System.Windows.Forms.Button button_НеСохранять;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ДолжностьИмя;
    }
}