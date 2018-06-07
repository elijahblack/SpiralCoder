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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.StupidButton = new System.Windows.Forms.Button();
            this.InitTypeComboBox = new System.Windows.Forms.ComboBox();
            this.InitTypeLabel = new System.Windows.Forms.Label();
            this.WayLabel3 = new System.Windows.Forms.Label();
            this.WayLabel2 = new System.Windows.Forms.Label();
            this.WayLabel1 = new System.Windows.Forms.Label();
            this.SetEncodeComboBox = new System.Windows.Forms.ComboBox();
            this.SetEncodeLabel = new System.Windows.Forms.Label();
            this.ArrayLengthComboBox = new System.Windows.Forms.ComboBox();
            this.ArrayLengthLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.TextGroupBox = new System.Windows.Forms.GroupBox();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TextGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(497, 346);
            this.dataGridView.TabIndex = 0;
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.SettingsGroupBox.Controls.Add(this.StupidButton);
            this.SettingsGroupBox.Controls.Add(this.WayLabel3);
            this.SettingsGroupBox.Controls.Add(this.InitTypeLabel);
            this.SettingsGroupBox.Controls.Add(this.ArrayLengthComboBox);
            this.SettingsGroupBox.Controls.Add(this.SetEncodeComboBox);
            this.SettingsGroupBox.Controls.Add(this.WayLabel2);
            this.SettingsGroupBox.Controls.Add(this.InitTypeComboBox);
            this.SettingsGroupBox.Controls.Add(this.WayLabel1);
            this.SettingsGroupBox.Controls.Add(this.ArrayLengthLabel);
            this.SettingsGroupBox.Controls.Add(this.SetEncodeLabel);
            this.SettingsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(247, 343);
            this.SettingsGroupBox.TabIndex = 1;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Настройки";
            // 
            // StupidButton
            // 
            this.StupidButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StupidButton.BackColor = System.Drawing.Color.Red;
            this.StupidButton.Location = new System.Drawing.Point(0, 219);
            this.StupidButton.Name = "StupidButton";
            this.StupidButton.Size = new System.Drawing.Size(247, 118);
            this.StupidButton.TabIndex = 9;
            this.StupidButton.Text = "Сделать, как в задании";
            this.StupidButton.UseVisualStyleBackColor = false;
            this.StupidButton.Click += new System.EventHandler(this.StupidButton_Click);
            // 
            // InitTypeComboBox
            // 
            this.InitTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InitTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InitTypeComboBox.FormattingEnabled = true;
            this.InitTypeComboBox.Location = new System.Drawing.Point(6, 172);
            this.InitTypeComboBox.Name = "InitTypeComboBox";
            this.InitTypeComboBox.Size = new System.Drawing.Size(235, 21);
            this.InitTypeComboBox.TabIndex = 8;
            // 
            // InitTypeLabel
            // 
            this.InitTypeLabel.AutoSize = true;
            this.InitTypeLabel.Location = new System.Drawing.Point(3, 156);
            this.InitTypeLabel.Name = "InitTypeLabel";
            this.InitTypeLabel.Size = new System.Drawing.Size(63, 13);
            this.InitTypeLabel.TabIndex = 7;
            this.InitTypeLabel.Text = "Тип текста";
            // 
            // WayLabel3
            // 
            this.WayLabel3.AutoSize = true;
            this.WayLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WayLabel3.ForeColor = System.Drawing.Color.Green;
            this.WayLabel3.Location = new System.Drawing.Point(12, 133);
            this.WayLabel3.Name = "WayLabel3";
            this.WayLabel3.Size = new System.Drawing.Size(176, 13);
            this.WayLabel3.TabIndex = 6;
            this.WayLabel3.Text = "Третий обрабатываемый символ";
            // 
            // WayLabel2
            // 
            this.WayLabel2.AutoSize = true;
            this.WayLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WayLabel2.ForeColor = System.Drawing.Color.Yellow;
            this.WayLabel2.Location = new System.Drawing.Point(12, 120);
            this.WayLabel2.Name = "WayLabel2";
            this.WayLabel2.Size = new System.Drawing.Size(176, 13);
            this.WayLabel2.TabIndex = 5;
            this.WayLabel2.Text = "Второй обрабатываемый символ";
            // 
            // WayLabel1
            // 
            this.WayLabel1.AutoSize = true;
            this.WayLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WayLabel1.ForeColor = System.Drawing.Color.Red;
            this.WayLabel1.Location = new System.Drawing.Point(12, 106);
            this.WayLabel1.Name = "WayLabel1";
            this.WayLabel1.Size = new System.Drawing.Size(180, 13);
            this.WayLabel1.TabIndex = 4;
            this.WayLabel1.Text = "Первый обрабатываемый символ";
            // 
            // SetEncodeComboBox
            // 
            this.SetEncodeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetEncodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SetEncodeComboBox.FormattingEnabled = true;
            this.SetEncodeComboBox.Location = new System.Drawing.Point(6, 82);
            this.SetEncodeComboBox.Name = "SetEncodeComboBox";
            this.SetEncodeComboBox.Size = new System.Drawing.Size(235, 21);
            this.SetEncodeComboBox.TabIndex = 3;
            // 
            // SetEncodeLabel
            // 
            this.SetEncodeLabel.AutoSize = true;
            this.SetEncodeLabel.Location = new System.Drawing.Point(3, 66);
            this.SetEncodeLabel.Name = "SetEncodeLabel";
            this.SetEncodeLabel.Size = new System.Drawing.Size(93, 13);
            this.SetEncodeLabel.TabIndex = 2;
            this.SetEncodeLabel.Text = "Тип шифрования";
            // 
            // ArrayLengthComboBox
            // 
            this.ArrayLengthComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArrayLengthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArrayLengthComboBox.FormattingEnabled = true;
            this.ArrayLengthComboBox.Location = new System.Drawing.Point(6, 32);
            this.ArrayLengthComboBox.Name = "ArrayLengthComboBox";
            this.ArrayLengthComboBox.Size = new System.Drawing.Size(235, 21);
            this.ArrayLengthComboBox.TabIndex = 1;
            // 
            // ArrayLengthLabel
            // 
            this.ArrayLengthLabel.AutoSize = true;
            this.ArrayLengthLabel.Location = new System.Drawing.Point(3, 16);
            this.ArrayLengthLabel.Name = "ArrayLengthLabel";
            this.ArrayLengthLabel.Size = new System.Drawing.Size(123, 13);
            this.ArrayLengthLabel.TabIndex = 0;
            this.ArrayLengthLabel.Text = "Размерность матрицы";
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
            this.splitContainer1.Panel1.Controls.Add(this.TextGroupBox);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TextButton);
            this.splitContainer1.Panel2.Controls.Add(this.DecodeButton);
            this.splitContainer1.Panel2.Controls.Add(this.SettingsGroupBox);
            this.splitContainer1.Panel2.Controls.Add(this.EncodeButton);
            this.splitContainer1.Panel2MinSize = 200;
            this.splitContainer1.Size = new System.Drawing.Size(760, 497);
            this.splitContainer1.SplitterDistance = 503;
            this.splitContainer1.TabIndex = 2;
            // 
            // EncodeButton
            // 
            this.EncodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncodeButton.Location = new System.Drawing.Point(3, 400);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(247, 44);
            this.EncodeButton.TabIndex = 2;
            this.EncodeButton.Text = "Зашифровать";
            this.EncodeButton.UseVisualStyleBackColor = true;
            // 
            // TextGroupBox
            // 
            this.TextGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextGroupBox.Controls.Add(this.textBox1);
            this.TextGroupBox.Location = new System.Drawing.Point(3, 352);
            this.TextGroupBox.Name = "TextGroupBox";
            this.TextGroupBox.Size = new System.Drawing.Size(497, 142);
            this.TextGroupBox.TabIndex = 1;
            this.TextGroupBox.TabStop = false;
            this.TextGroupBox.Text = "Текст";
            // 
            // DecodeButton
            // 
            this.DecodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecodeButton.Location = new System.Drawing.Point(3, 450);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(247, 44);
            this.DecodeButton.TabIndex = 3;
            this.DecodeButton.Text = "Расшифровать";
            this.DecodeButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(7, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(490, 121);
            this.textBox1.TabIndex = 0;
            // 
            // TextButton
            // 
            this.TextButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextButton.Location = new System.Drawing.Point(3, 350);
            this.TextButton.Name = "TextButton";
            this.TextButton.Size = new System.Drawing.Size(247, 44);
            this.TextButton.TabIndex = 4;
            this.TextButton.Text = "Сформировать текст";
            this.TextButton.UseVisualStyleBackColor = true;
            this.TextButton.Click += new System.EventHandler(this.TextButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(800, 560);
            this.Name = "MainForm";
            this.Text = "Шифрование";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TextGroupBox.ResumeLayout(false);
            this.TextGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// Таблица вывода матрицы
        /// </summary>
        private System.Windows.Forms.DataGridView dataGridView;
        /// <summary>
        /// Поле настроек
        /// </summary>
        private System.Windows.Forms.GroupBox SettingsGroupBox;
        /// <summary>
        /// Метка выбора размерности массива
        /// </summary>
        private System.Windows.Forms.Label ArrayLengthLabel;
        /// <summary>
        /// Список выбора размерности массива
        /// </summary>
        private System.Windows.Forms.ComboBox ArrayLengthComboBox;
        /// <summary>
        /// Третья метка пути шифрования
        /// </summary>
        private System.Windows.Forms.Label WayLabel3;
        /// <summary>
        /// Вторая метка пути шифрования
        /// </summary>
        private System.Windows.Forms.Label WayLabel2;
        /// <summary>
        /// Первая метка пути шифрования
        /// </summary>
        private System.Windows.Forms.Label WayLabel1;
        /// <summary>
        /// Список выбора метода шифрования
        /// </summary>
        private System.Windows.Forms.ComboBox SetEncodeComboBox;
        /// <summary>
        /// Метка выбора метода шифрования
        /// </summary>
        private System.Windows.Forms.Label SetEncodeLabel;
        /// <summary>
        /// Список выбора типа инициализации шифруемого текста
        /// </summary>
        private System.Windows.Forms.ComboBox InitTypeComboBox;
        /// <summary>
        /// Метка выбора типа инициализации шифруемого текста
        /// </summary>
        private System.Windows.Forms.Label InitTypeLabel;
        /// <summary>
        /// Кнопка для идиотов
        /// </summary>
        private System.Windows.Forms.Button StupidButton;
        /// <summary>
        /// Контейнер, разделяющий интерфейс
        /// </summary>
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox TextGroupBox;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button TextButton;
    }
}

