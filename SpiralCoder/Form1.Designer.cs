namespace SpiralCoder
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.ArrayLengthLabel = new System.Windows.Forms.Label();
            this.ArrayLengthComboBox = new System.Windows.Forms.ComboBox();
            this.SetEncodeLabel = new System.Windows.Forms.Label();
            this.SetEncodeComboBox = new System.Windows.Forms.ComboBox();
            this.WayLabel1 = new System.Windows.Forms.Label();
            this.WayLabel2 = new System.Windows.Forms.Label();
            this.WayLabel3 = new System.Windows.Forms.Label();
            this.InitTypeLabel = new System.Windows.Forms.Label();
            this.InitTypeComboBox = new System.Windows.Forms.ComboBox();
            this.StupidButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsGroupBox.Controls.Add(this.StupidButton);
            this.SettingsGroupBox.Controls.Add(this.InitTypeComboBox);
            this.SettingsGroupBox.Controls.Add(this.InitTypeLabel);
            this.SettingsGroupBox.Controls.Add(this.WayLabel3);
            this.SettingsGroupBox.Controls.Add(this.WayLabel2);
            this.SettingsGroupBox.Controls.Add(this.WayLabel1);
            this.SettingsGroupBox.Controls.Add(this.SetEncodeComboBox);
            this.SettingsGroupBox.Controls.Add(this.SetEncodeLabel);
            this.SettingsGroupBox.Controls.Add(this.ArrayLengthComboBox);
            this.SettingsGroupBox.Controls.Add(this.ArrayLengthLabel);
            this.SettingsGroupBox.Location = new System.Drawing.Point(6, 3);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(200, 358);
            this.SettingsGroupBox.TabIndex = 1;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Настройки";
            // 
            // ArrayLengthLabel
            // 
            this.ArrayLengthLabel.AutoSize = true;
            this.ArrayLengthLabel.Location = new System.Drawing.Point(7, 20);
            this.ArrayLengthLabel.Name = "ArrayLengthLabel";
            this.ArrayLengthLabel.Size = new System.Drawing.Size(123, 13);
            this.ArrayLengthLabel.TabIndex = 0;
            this.ArrayLengthLabel.Text = "Размерность матрицы";
            // 
            // ArrayLengthComboBox
            // 
            this.ArrayLengthComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArrayLengthComboBox.FormattingEnabled = true;
            this.ArrayLengthComboBox.Location = new System.Drawing.Point(7, 37);
            this.ArrayLengthComboBox.Name = "ArrayLengthComboBox";
            this.ArrayLengthComboBox.Size = new System.Drawing.Size(187, 21);
            this.ArrayLengthComboBox.TabIndex = 1;
            this.ArrayLengthComboBox.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_SelectionChangeCommitted);
            // 
            // SetEncodeLabel
            // 
            this.SetEncodeLabel.AutoSize = true;
            this.SetEncodeLabel.Location = new System.Drawing.Point(10, 75);
            this.SetEncodeLabel.Name = "SetEncodeLabel";
            this.SetEncodeLabel.Size = new System.Drawing.Size(93, 13);
            this.SetEncodeLabel.TabIndex = 2;
            this.SetEncodeLabel.Text = "Тип шифрования";
            // 
            // SetEncodeComboBox
            // 
            this.SetEncodeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetEncodeComboBox.FormattingEnabled = true;
            this.SetEncodeComboBox.Location = new System.Drawing.Point(7, 92);
            this.SetEncodeComboBox.Name = "SetEncodeComboBox";
            this.SetEncodeComboBox.Size = new System.Drawing.Size(187, 21);
            this.SetEncodeComboBox.TabIndex = 3;
            // 
            // WayLabel1
            // 
            this.WayLabel1.AutoSize = true;
            this.WayLabel1.Location = new System.Drawing.Point(7, 120);
            this.WayLabel1.Name = "WayLabel1";
            this.WayLabel1.Size = new System.Drawing.Size(180, 13);
            this.WayLabel1.TabIndex = 4;
            this.WayLabel1.Text = "Первый обрабатываемый символ";
            // 
            // WayLabel2
            // 
            this.WayLabel2.AutoSize = true;
            this.WayLabel2.Location = new System.Drawing.Point(7, 137);
            this.WayLabel2.Name = "WayLabel2";
            this.WayLabel2.Size = new System.Drawing.Size(176, 13);
            this.WayLabel2.TabIndex = 5;
            this.WayLabel2.Text = "Второй обрабатываемый символ";
            // 
            // WayLabel3
            // 
            this.WayLabel3.AutoSize = true;
            this.WayLabel3.Location = new System.Drawing.Point(7, 154);
            this.WayLabel3.Name = "WayLabel3";
            this.WayLabel3.Size = new System.Drawing.Size(176, 13);
            this.WayLabel3.TabIndex = 6;
            this.WayLabel3.Text = "Третий обрабатываемый символ";
            // 
            // InitTypeLabel
            // 
            this.InitTypeLabel.AutoSize = true;
            this.InitTypeLabel.Location = new System.Drawing.Point(7, 181);
            this.InitTypeLabel.Name = "InitTypeLabel";
            this.InitTypeLabel.Size = new System.Drawing.Size(63, 13);
            this.InitTypeLabel.TabIndex = 7;
            this.InitTypeLabel.Text = "Тип текста";
            // 
            // InitTypeComboBox
            // 
            this.InitTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InitTypeComboBox.FormattingEnabled = true;
            this.InitTypeComboBox.Location = new System.Drawing.Point(7, 198);
            this.InitTypeComboBox.Name = "InitTypeComboBox";
            this.InitTypeComboBox.Size = new System.Drawing.Size(187, 21);
            this.InitTypeComboBox.TabIndex = 8;
            // 
            // StupidButton
            // 
            this.StupidButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StupidButton.BackColor = System.Drawing.Color.Red;
            this.StupidButton.Location = new System.Drawing.Point(7, 236);
            this.StupidButton.Name = "StupidButton";
            this.StupidButton.Size = new System.Drawing.Size(187, 116);
            this.StupidButton.TabIndex = 9;
            this.StupidButton.Text = "Сделать, как в задании";
            this.StupidButton.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SettingsGroupBox);
            this.splitContainer1.Size = new System.Drawing.Size(769, 465);
            this.splitContainer1.SplitterDistance = 556;
            this.splitContainer1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 489);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Шифрование";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.Label ArrayLengthLabel;
        private System.Windows.Forms.ComboBox ArrayLengthComboBox;
        private System.Windows.Forms.Label WayLabel3;
        private System.Windows.Forms.Label WayLabel2;
        private System.Windows.Forms.Label WayLabel1;
        private System.Windows.Forms.ComboBox SetEncodeComboBox;
        private System.Windows.Forms.Label SetEncodeLabel;
        private System.Windows.Forms.ComboBox InitTypeComboBox;
        private System.Windows.Forms.Label InitTypeLabel;
        private System.Windows.Forms.Button StupidButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

