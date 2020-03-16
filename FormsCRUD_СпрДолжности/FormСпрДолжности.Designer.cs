namespace QbixWinFormsLinqTest
{
    partial class FormСпрДолжности
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
            this.dataGridViewСпр_Должности = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd_СпрДолжности = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit_СпрДолжности = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDel_СпрДолжности = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewСпр_Должности)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewСпр_Должности
            // 
            this.dataGridViewСпр_Должности.AllowUserToAddRows = false;
            this.dataGridViewСпр_Должности.AllowUserToDeleteRows = false;
            this.dataGridViewСпр_Должности.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewСпр_Должности.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewСпр_Должности.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewСпр_Должности.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewСпр_Должности.Location = new System.Drawing.Point(0, 28);
            this.dataGridViewСпр_Должности.MultiSelect = false;
            this.dataGridViewСпр_Должности.Name = "dataGridViewСпр_Должности";
            this.dataGridViewСпр_Должности.ReadOnly = true;
            this.dataGridViewСпр_Должности.Size = new System.Drawing.Size(343, 210);
            this.dataGridViewСпр_Должности.TabIndex = 0;
            this.dataGridViewСпр_Должности.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewСпр_Должности_RowHeaderMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Должность_Id";
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.ToolTipText = "Идентификатор должности";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Должность_Имя";
            this.Column2.HeaderText = "Должность";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd_СпрДолжности,
            this.toolStripButtonEdit_СпрДолжности,
            this.toolStripButtonDel_СпрДолжности,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(343, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAdd_СпрДолжности
            // 
            this.toolStripButtonAdd_СпрДолжности.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd_СпрДолжности.Image = global::QbixWinFormsLinqTest.Properties.Resources.Плюс;
            this.toolStripButtonAdd_СпрДолжности.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd_СпрДолжности.Name = "toolStripButtonAdd_СпрДолжности";
            this.toolStripButtonAdd_СпрДолжности.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd_СпрДолжности.Text = "toolStripButton1";
            this.toolStripButtonAdd_СпрДолжности.Click += new System.EventHandler(this.toolStripButtonAdd_СпрДолжности_Click);
            // 
            // toolStripButtonEdit_СпрДолжности
            // 
            this.toolStripButtonEdit_СпрДолжности.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit_СпрДолжности.Image = global::QbixWinFormsLinqTest.Properties.Resources.edit;
            this.toolStripButtonEdit_СпрДолжности.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit_СпрДолжности.Name = "toolStripButtonEdit_СпрДолжности";
            this.toolStripButtonEdit_СпрДолжности.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEdit_СпрДолжности.Text = "toolStripButton2";
            this.toolStripButtonEdit_СпрДолжности.Click += new System.EventHandler(this.toolStripButtonEdit_СпрДолжности_Click);
            // 
            // toolStripButtonDel_СпрДолжности
            // 
            this.toolStripButtonDel_СпрДолжности.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDel_СпрДолжности.Image = global::QbixWinFormsLinqTest.Properties.Resources.Удалить;
            this.toolStripButtonDel_СпрДолжности.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDel_СпрДолжности.Name = "toolStripButtonDel_СпрДолжности";
            this.toolStripButtonDel_СпрДолжности.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDel_СпрДолжности.Text = "toolStripButton3";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(265, 22);
            this.toolStripLabel1.Text = "Выбор строки - 2-ой клик на заголовке строки";
            // 
            // FormСпрДолжности
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 238);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridViewСпр_Должности);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormСпрДолжности";
            this.ShowInTaskbar = false;
            this.Text = "Справочник должностей";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewСпр_Должности)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewСпр_Должности;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd_СпрДолжности;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit_СпрДолжности;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel_СпрДолжности;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}