namespace QbixWinFormsLinqTest
{
    partial class FormУдалитьСотрудникДолжностьНавык
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormУдалитьСотрудникДолжностьНавык));
            this.button_Сохранить = new System.Windows.Forms.Button();
            this.button_НеСохранять = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_НавыкИмя = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Удалить навык должность сотрудника ?";
            // 
            // textBox_ДолжностьИмя
            // 
            this.textBox_НавыкИмя.Enabled = false;
            this.textBox_НавыкИмя.Location = new System.Drawing.Point(29, 51);
            this.textBox_НавыкИмя.Name = "textBox_ДолжностьИмя";
            this.textBox_НавыкИмя.ReadOnly = true;
            this.textBox_НавыкИмя.Size = new System.Drawing.Size(161, 20);
            this.textBox_НавыкИмя.TabIndex = 4;
            // 
            // FormУдалитьСотрудникиДолжностиНавыки
            // 
            this.AcceptButton = this.button_Сохранить;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_НеСохранять;
            this.ClientSize = new System.Drawing.Size(251, 144);
            this.Controls.Add(this.textBox_НавыкИмя);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_НеСохранять);
            this.Controls.Add(this.button_Сохранить);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormУдалитьСотрудникиДолжностиНавыки";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Удаление навык должности сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Сохранить;
        private System.Windows.Forms.Button button_НеСохранять;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_НавыкИмя;
    }
}