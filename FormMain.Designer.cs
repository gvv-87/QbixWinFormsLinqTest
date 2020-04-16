namespace QbixPasswordsReturn
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Сотрудники = new System.Windows.Forms.DataGridView();
            this.Сотрудник_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сотрудник_Фио = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip_Сотрудники = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_Сотрудники = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonAdd_Сотрудника = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit_Сотрудника = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDel_Сотрудника = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Сотрудники)).BeginInit();
            this.toolStrip_Сотрудники.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView_Сотрудники);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip_Сотрудники);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridView_Сотрудники
            // 
            this.dataGridView_Сотрудники.AllowUserToAddRows = false;
            this.dataGridView_Сотрудники.AllowUserToDeleteRows = false;
            this.dataGridView_Сотрудники.AllowUserToOrderColumns = true;
            this.dataGridView_Сотрудники.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Сотрудники.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Сотрудники.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Сотрудники.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Сотрудники.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Сотрудник_Id,
            this.Сотрудник_Фио});
            this.dataGridView_Сотрудники.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Сотрудники.Location = new System.Drawing.Point(0, 25);
            this.dataGridView_Сотрудники.MultiSelect = false;
            this.dataGridView_Сотрудники.Name = "dataGridView_Сотрудники";
            this.dataGridView_Сотрудники.ReadOnly = true;
            this.dataGridView_Сотрудники.Size = new System.Drawing.Size(300, 425);
            this.dataGridView_Сотрудники.TabIndex = 1;
            this.dataGridView_Сотрудники.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Сотрудники_RowEnter);
            // 
            // Сотрудник_Id
            // 
            this.Сотрудник_Id.DataPropertyName = "Сотрудник_Id";
            this.Сотрудник_Id.FillWeight = 35.53299F;
            this.Сотрудник_Id.HeaderText = "Id";
            this.Сотрудник_Id.MaxInputLength = 3;
            this.Сотрудник_Id.Name = "Сотрудник_Id";
            this.Сотрудник_Id.ReadOnly = true;
            this.Сотрудник_Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Сотрудник_Фио
            // 
            this.Сотрудник_Фио.DataPropertyName = "Сотрудник_Фио";
            this.Сотрудник_Фио.FillWeight = 104.467F;
            this.Сотрудник_Фио.HeaderText = "Сотрудник ФИО";
            this.Сотрудник_Фио.Name = "Сотрудник_Фио";
            this.Сотрудник_Фио.ReadOnly = true;
            // 
            // toolStrip_Сотрудники
            // 
            this.toolStrip_Сотрудники.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_Сотрудники.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_Сотрудники,
            this.toolStripButtonAdd_Сотрудника,
            this.toolStripButtonEdit_Сотрудника,
            this.toolStripButtonDel_Сотрудника});
            this.toolStrip_Сотрудники.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_Сотрудники.Name = "toolStrip_Сотрудники";
            this.toolStrip_Сотрудники.Size = new System.Drawing.Size(300, 25);
            this.toolStrip_Сотрудники.TabIndex = 0;
            this.toolStrip_Сотрудники.Text = "toolStrip1";
            // 
            // toolStripLabel_Сотрудники
            // 
            this.toolStripLabel_Сотрудники.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel_Сотрудники.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripLabel_Сотрудники.Name = "toolStripLabel_Сотрудники";
            this.toolStripLabel_Сотрудники.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel_Сотрудники.Text = "Сотрудники";
            // 
            // toolStripButtonAdd_Сотрудника
            // 
            this.toolStripButtonAdd_Сотрудника.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd_Сотрудника.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd_Сотрудника.Name = "toolStripButtonAdd_Сотрудника";
            this.toolStripButtonAdd_Сотрудника.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd_Сотрудника.Text = "Добавить сотрудника";
            this.toolStripButtonAdd_Сотрудника.Click += new System.EventHandler(this.toolStripButtonAddСотрудника_Click);
            // 
            // toolStripButtonEdit_Сотрудника
            // 
            this.toolStripButtonEdit_Сотрудника.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit_Сотрудника.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit_Сотрудника.Name = "toolStripButtonEdit_Сотрудника";
            this.toolStripButtonEdit_Сотрудника.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEdit_Сотрудника.Text = "Редактировать ФИО сотрудника";
            this.toolStripButtonEdit_Сотрудника.Click += new System.EventHandler(this.toolStripButtonEditСотрудника_Click);
            // 
            // toolStripButtonDel_Сотрудника
            // 
            this.toolStripButtonDel_Сотрудника.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDel_Сотрудника.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDel_Сотрудника.Name = "toolStripButtonDel_Сотрудника";
            this.toolStripButtonDel_Сотрудника.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDel_Сотрудника.Text = "Удалить сотрудника";
            this.toolStripButtonDel_Сотрудника.Click += new System.EventHandler(this.toolStripButtonDelСотрудника_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Сотрудники)).EndInit();
            this.toolStrip_Сотрудники.ResumeLayout(false);
            this.toolStrip_Сотрудники.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip_Сотрудники;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Сотрудники;
        private System.Windows.Forms.DataGridView dataGridView_Сотрудники;
        private System.Windows.Forms.DataGridViewTextBoxColumn Сотрудник_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Сотрудник_Фио;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd_Сотрудника;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit_Сотрудника;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel_Сотрудника;
    }
}

