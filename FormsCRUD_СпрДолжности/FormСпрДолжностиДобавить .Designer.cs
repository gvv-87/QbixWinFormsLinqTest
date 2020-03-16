namespace QbixWinFormsLinqTest
{
    partial class FormСпрДолжностиДобавить
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormСпрДолжностиДобавить));
            this.button_Сохранить = new System.Windows.Forms.Button();
            this.button_НеСохранять = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_НоваяДолжность = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Сохранить
            // 
            this.button_Сохранить.Location = new System.Drawing.Point(51, 66);
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
            this.button_НеСохранять.Location = new System.Drawing.Point(166, 66);
            this.button_НеСохранять.Name = "button_НеСохранять";
            this.button_НеСохранять.Size = new System.Drawing.Size(91, 23);
            this.button_НеСохранять.TabIndex = 1;
            this.button_НеСохранять.Text = "Не сохранять";
            this.button_НеСохранять.UseVisualStyleBackColor = true;
            this.button_НеСохранять.Click += new System.EventHandler(this.button_НеСохранять_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название новой должности";
            // 
            // textBox_НовоеФио
            // 
            this.textBox_НоваяДолжность.Location = new System.Drawing.Point(163, 21);
            this.textBox_НоваяДолжность.Name = "textBox_НовоеФио";
            this.textBox_НоваяДолжность.Size = new System.Drawing.Size(167, 20);
            this.textBox_НоваяДолжность.TabIndex = 5;
            // 
            // FormСпрДолжностиДобавить
            // 
            this.AcceptButton = this.button_Сохранить;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_НеСохранять;
            this.ClientSize = new System.Drawing.Size(341, 108);
            this.Controls.Add(this.textBox_НоваяДолжность);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_НеСохранять);
            this.Controls.Add(this.button_Сохранить);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormСпрДолжностиДобавить";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новая должность";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Сохранить;
        private System.Windows.Forms.Button button_НеСохранять;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_НоваяДолжность;
    }
}