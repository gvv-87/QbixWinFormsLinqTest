namespace QbixWinFormsLinqTest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Сотрудники = new System.Windows.Forms.DataGridView();
            this.Сотрудник_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сотрудник_Фио = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip_Сотрудники = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_Сотрудники = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonAdd_Сотрудника = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit_Сотрудника = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDel_Сотрудника = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_СотрудникДолжности = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip_Должности = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_Должности = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonAdd_Должность = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDel_Должность = new System.Windows.Forms.ToolStripButton();
            this.dataGridView_НавыкиДолжностиСотрудника = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip_Навыки = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_Навыки = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonAdd_Навык = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDel_Навык = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Сотрудники)).BeginInit();
            this.toolStrip_Сотрудники.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_СотрудникДолжности)).BeginInit();
            this.toolStrip_Должности.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_НавыкиДолжностиСотрудника)).BeginInit();
            this.toolStrip_Навыки.SuspendLayout();
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
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
            this.toolStripButtonAdd_Сотрудника.Image = global::QbixWinFormsLinqTest.Properties.Resources.Плюс;
            this.toolStripButtonAdd_Сотрудника.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd_Сотрудника.Name = "toolStripButtonAdd_Сотрудника";
            this.toolStripButtonAdd_Сотрудника.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd_Сотрудника.Text = "Добавить сотрудника";
            this.toolStripButtonAdd_Сотрудника.Click += new System.EventHandler(this.toolStripButtonAddСотрудника_Click);
            // 
            // toolStripButtonEdit_Сотрудника
            // 
            this.toolStripButtonEdit_Сотрудника.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit_Сотрудника.Image = global::QbixWinFormsLinqTest.Properties.Resources.edit;
            this.toolStripButtonEdit_Сотрудника.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit_Сотрудника.Name = "toolStripButtonEdit_Сотрудника";
            this.toolStripButtonEdit_Сотрудника.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEdit_Сотрудника.Text = "Редактировать ФИО сотрудника";
            this.toolStripButtonEdit_Сотрудника.Click += new System.EventHandler(this.toolStripButtonEditСотрудника_Click);
            // 
            // toolStripButtonDel_Сотрудника
            // 
            this.toolStripButtonDel_Сотрудника.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDel_Сотрудника.Image = global::QbixWinFormsLinqTest.Properties.Resources.Удалить;
            this.toolStripButtonDel_Сотрудника.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDel_Сотрудника.Name = "toolStripButtonDel_Сотрудника";
            this.toolStripButtonDel_Сотрудника.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDel_Сотрудника.Text = "Удалить сотрудника";
            this.toolStripButtonDel_Сотрудника.Click += new System.EventHandler(this.toolStripButtonDelСотрудника_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView_СотрудникДолжности);
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip_Должности);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView_НавыкиДолжностиСотрудника);
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip_Навыки);
            this.splitContainer2.Size = new System.Drawing.Size(496, 450);
            this.splitContainer2.SplitterDistance = 242;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView_СотрудникДолжности
            // 
            this.dataGridView_СотрудникДолжности.AllowUserToAddRows = false;
            this.dataGridView_СотрудникДолжности.AllowUserToDeleteRows = false;
            this.dataGridView_СотрудникДолжности.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_СотрудникДолжности.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_СотрудникДолжности.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_СотрудникДолжности.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView_СотрудникДолжности.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_СотрудникДолжности.Location = new System.Drawing.Point(0, 25);
            this.dataGridView_СотрудникДолжности.Name = "dataGridView_СотрудникДолжности";
            this.dataGridView_СотрудникДолжности.Size = new System.Drawing.Size(242, 425);
            this.dataGridView_СотрудникДолжности.TabIndex = 1;
            this.dataGridView_СотрудникДолжности.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Должности_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Сотрудник_Id";
            this.Column1.HeaderText = "Сотрудник_Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Должность_Id";
            this.Column2.HeaderText = "Должность_Id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Должность_Имя";
            this.Column3.HeaderText = "Должность";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // toolStrip_Должности
            // 
            this.toolStrip_Должности.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_Должности.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_Должности,
            this.toolStripButtonAdd_Должность,
            this.toolStripButtonDel_Должность});
            this.toolStrip_Должности.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_Должности.Name = "toolStrip_Должности";
            this.toolStrip_Должности.Size = new System.Drawing.Size(242, 25);
            this.toolStrip_Должности.TabIndex = 0;
            this.toolStrip_Должности.Text = "toolStrip2";
            // 
            // toolStripLabel_Должности
            // 
            this.toolStripLabel_Должности.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel_Должности.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripLabel_Должности.Name = "toolStripLabel_Должности";
            this.toolStripLabel_Должности.Size = new System.Drawing.Size(98, 22);
            this.toolStripLabel_Должности.Text = "Должности";
            // 
            // toolStripButtonAdd_Должность
            // 
            this.toolStripButtonAdd_Должность.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd_Должность.Image = global::QbixWinFormsLinqTest.Properties.Resources.Плюс;
            this.toolStripButtonAdd_Должность.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd_Должность.Name = "toolStripButtonAdd_Должность";
            this.toolStripButtonAdd_Должность.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd_Должность.Text = "Добавить должность сотруднику";
            this.toolStripButtonAdd_Должность.Click += new System.EventHandler(this.toolStripButtonAdd_ДолжностьСотрудника_Click);
            // 
            // toolStripButtonDel_Должность
            // 
            this.toolStripButtonDel_Должность.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDel_Должность.Image = global::QbixWinFormsLinqTest.Properties.Resources.Удалить;
            this.toolStripButtonDel_Должность.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDel_Должность.Name = "toolStripButtonDel_Должность";
            this.toolStripButtonDel_Должность.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDel_Должность.Text = "Удалить должность сотрудника";
            this.toolStripButtonDel_Должность.Click += new System.EventHandler(this.toolStripButtonDel_ДолжностьСотрудника_Click);
            // 
            // dataGridView_НавыкиДолжностиСотрудника
            // 
            this.dataGridView_НавыкиДолжностиСотрудника.AllowUserToAddRows = false;
            this.dataGridView_НавыкиДолжностиСотрудника.AllowUserToDeleteRows = false;
            this.dataGridView_НавыкиДолжностиСотрудника.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_НавыкиДолжностиСотрудника.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_НавыкиДолжностиСотрудника.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_НавыкиДолжностиСотрудника.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView_НавыкиДолжностиСотрудника.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_НавыкиДолжностиСотрудника.Location = new System.Drawing.Point(0, 25);
            this.dataGridView_НавыкиДолжностиСотрудника.MultiSelect = false;
            this.dataGridView_НавыкиДолжностиСотрудника.Name = "dataGridView_НавыкиДолжностиСотрудника";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_НавыкиДолжностиСотрудника.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_НавыкиДолжностиСотрудника.Size = new System.Drawing.Size(250, 425);
            this.dataGridView_НавыкиДолжностиСотрудника.TabIndex = 1;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Сотрудник_Id";
            this.Column4.HeaderText = "Сотрудник Id";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Должность_Id";
            this.Column5.HeaderText = "Должность Id";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Навык_Id";
            this.Column6.HeaderText = "Навык Id";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Навык_Имя";
            this.Column7.HeaderText = "Навык";
            this.Column7.Name = "Column7";
            // 
            // toolStrip_Навыки
            // 
            this.toolStrip_Навыки.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_Навыки.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_Навыки,
            this.toolStripButtonAdd_Навык,
            this.toolStripButtonDel_Навык});
            this.toolStrip_Навыки.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_Навыки.Name = "toolStrip_Навыки";
            this.toolStrip_Навыки.Size = new System.Drawing.Size(250, 25);
            this.toolStrip_Навыки.TabIndex = 0;
            this.toolStrip_Навыки.Text = "toolStrip3";
            // 
            // toolStripLabel_Навыки
            // 
            this.toolStripLabel_Навыки.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel_Навыки.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripLabel_Навыки.Name = "toolStripLabel_Навыки";
            this.toolStripLabel_Навыки.Size = new System.Drawing.Size(69, 22);
            this.toolStripLabel_Навыки.Text = "Навыки";
            // 
            // toolStripButtonAdd_Навык
            // 
            this.toolStripButtonAdd_Навык.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd_Навык.Image = global::QbixWinFormsLinqTest.Properties.Resources.Плюс;
            this.toolStripButtonAdd_Навык.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd_Навык.Name = "toolStripButtonAdd_Навык";
            this.toolStripButtonAdd_Навык.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd_Навык.Text = "Добавить навык";
            this.toolStripButtonAdd_Навык.Click += new System.EventHandler(this.toolStripButtonAdd_НавыкиДолжностиСотрудника_Click);
            // 
            // toolStripButtonDel_Навык
            // 
            this.toolStripButtonDel_Навык.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDel_Навык.Image = global::QbixWinFormsLinqTest.Properties.Resources.Удалить;
            this.toolStripButtonDel_Навык.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDel_Навык.Name = "toolStripButtonDel_Навык";
            this.toolStripButtonDel_Навык.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDel_Навык.Text = "Удалить навык должности сотрудника";
            this.toolStripButtonDel_Навык.Click += new System.EventHandler(this.toolStripButtonDel_НавыкиДолжностиСотрудника_Click);
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
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Сотрудники)).EndInit();
            this.toolStrip_Сотрудники.ResumeLayout(false);
            this.toolStrip_Сотрудники.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_СотрудникДолжности)).EndInit();
            this.toolStrip_Должности.ResumeLayout(false);
            this.toolStrip_Должности.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_НавыкиДолжностиСотрудника)).EndInit();
            this.toolStrip_Навыки.ResumeLayout(false);
            this.toolStrip_Навыки.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip toolStrip_Сотрудники;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Сотрудники;
        private System.Windows.Forms.ToolStrip toolStrip_Должности;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Должности;
        private System.Windows.Forms.ToolStrip toolStrip_Навыки;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Навыки;
        private System.Windows.Forms.DataGridView dataGridView_СотрудникДолжности;
        private System.Windows.Forms.DataGridView dataGridView_НавыкиДолжностиСотрудника;
        private System.Windows.Forms.DataGridView dataGridView_Сотрудники;
        private System.Windows.Forms.DataGridViewTextBoxColumn Сотрудник_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Сотрудник_Фио;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd_Сотрудника;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit_Сотрудника;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel_Сотрудника;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd_Должность;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel_Должность;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd_Навык;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel_Навык;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

