namespace Показания_счетчиков
{
    partial class Parent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parent));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combChooseMeter = new System.Windows.Forms.ComboBox();
            this.addValue = new System.Windows.Forms.Button();
            this.addMeter = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.combChooseMeter6 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.deletePrice = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.newServicePrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combChooseMeter5 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.changePrice = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.servicePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combChooseMeter4 = new System.Windows.Forms.ComboBox();
            this.addPrice = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.addValue);
            this.tabPage1.Controls.Add(this.addMeter);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(422, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Счетчики";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.combChooseMeter);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 292);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выберете счетчик";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(6, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(388, 227);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата показания";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 135;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Показание";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Расход";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Сумма";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // combChooseMeter
            // 
            this.combChooseMeter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.combChooseMeter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combChooseMeter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.combChooseMeter.FormattingEnabled = true;
            this.combChooseMeter.Location = new System.Drawing.Point(6, 32);
            this.combChooseMeter.Name = "combChooseMeter";
            this.combChooseMeter.Size = new System.Drawing.Size(121, 21);
            this.combChooseMeter.TabIndex = 1;
            this.combChooseMeter.DropDown += new System.EventHandler(this.combChooseMeter_DropDown);
            this.combChooseMeter.SelectedIndexChanged += new System.EventHandler(this.combChooseMeter_SelectedIndexChanged);
            // 
            // addValue
            // 
            this.addValue.BackColor = System.Drawing.SystemColors.Control;
            this.addValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addValue.Location = new System.Drawing.Point(246, 328);
            this.addValue.Name = "addValue";
            this.addValue.Size = new System.Drawing.Size(167, 23);
            this.addValue.TabIndex = 4;
            this.addValue.Text = "Добавить показание";
            this.addValue.UseVisualStyleBackColor = false;
            this.addValue.Click += new System.EventHandler(this.addValue_Click);
            // 
            // addMeter
            // 
            this.addMeter.BackColor = System.Drawing.SystemColors.Control;
            this.addMeter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addMeter.Location = new System.Drawing.Point(3, 328);
            this.addMeter.Name = "addMeter";
            this.addMeter.Size = new System.Drawing.Size(167, 23);
            this.addMeter.TabIndex = 0;
            this.addMeter.Text = "Добавить счетчик";
            this.addMeter.UseVisualStyleBackColor = false;
            this.addMeter.Click += new System.EventHandler(this.addMeter_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(430, 381);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(422, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Стоимость услуг";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.combChooseMeter6);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.deletePrice);
            this.groupBox4.Location = new System.Drawing.Point(292, 136);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(129, 192);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Удалить стоимость услуги";
            // 
            // combChooseMeter6
            // 
            this.combChooseMeter6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combChooseMeter6.FormattingEnabled = true;
            this.combChooseMeter6.Location = new System.Drawing.Point(9, 57);
            this.combChooseMeter6.Name = "combChooseMeter6";
            this.combChooseMeter6.Size = new System.Drawing.Size(100, 21);
            this.combChooseMeter6.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(6, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Выберете услугу:";
            // 
            // deletePrice
            // 
            this.deletePrice.BackColor = System.Drawing.SystemColors.Control;
            this.deletePrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deletePrice.Location = new System.Drawing.Point(6, 163);
            this.deletePrice.Name = "deletePrice";
            this.deletePrice.Size = new System.Drawing.Size(113, 23);
            this.deletePrice.TabIndex = 4;
            this.deletePrice.Text = "Удалить строку";
            this.deletePrice.UseVisualStyleBackColor = false;
            this.deletePrice.Click += new System.EventHandler(this.deletePrice_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.newServicePrice);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.combChooseMeter5);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.changePrice);
            this.groupBox3.Location = new System.Drawing.Point(149, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 192);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Изменить стоимость услуги";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(115, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "руб.";
            // 
            // newServicePrice
            // 
            this.newServicePrice.Location = new System.Drawing.Point(9, 137);
            this.newServicePrice.Name = "newServicePrice";
            this.newServicePrice.Size = new System.Drawing.Size(100, 20);
            this.newServicePrice.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(9, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Стоимость";
            // 
            // combChooseMeter5
            // 
            this.combChooseMeter5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combChooseMeter5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.combChooseMeter5.FormattingEnabled = true;
            this.combChooseMeter5.Location = new System.Drawing.Point(9, 57);
            this.combChooseMeter5.Name = "combChooseMeter5";
            this.combChooseMeter5.Size = new System.Drawing.Size(100, 21);
            this.combChooseMeter5.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Выберете услугу:";
            // 
            // changePrice
            // 
            this.changePrice.BackColor = System.Drawing.SystemColors.Control;
            this.changePrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changePrice.Location = new System.Drawing.Point(6, 163);
            this.changePrice.Name = "changePrice";
            this.changePrice.Size = new System.Drawing.Size(113, 23);
            this.changePrice.TabIndex = 3;
            this.changePrice.Text = "Изменить";
            this.changePrice.UseVisualStyleBackColor = false;
            this.changePrice.Click += new System.EventHandler(this.changePrice_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.servicePrice);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.combChooseMeter4);
            this.groupBox2.Controls.Add(this.addPrice);
            this.groupBox2.Location = new System.Drawing.Point(5, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 192);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавить услугу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(3, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Выберете услугу:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(105, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "руб.";
            // 
            // servicePrice
            // 
            this.servicePrice.Location = new System.Drawing.Point(6, 140);
            this.servicePrice.Name = "servicePrice";
            this.servicePrice.Size = new System.Drawing.Size(100, 20);
            this.servicePrice.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(4, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Стоимость";
            // 
            // combChooseMeter4
            // 
            this.combChooseMeter4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combChooseMeter4.FormattingEnabled = true;
            this.combChooseMeter4.Items.AddRange(new object[] {
            "Холодное водоснабжение",
            "Горячее водоснабжение",
            "Электроснабжение",
            "Газоснабжение"});
            this.combChooseMeter4.Location = new System.Drawing.Point(7, 57);
            this.combChooseMeter4.Name = "combChooseMeter4";
            this.combChooseMeter4.Size = new System.Drawing.Size(100, 21);
            this.combChooseMeter4.TabIndex = 6;
            this.combChooseMeter4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // addPrice
            // 
            this.addPrice.BackColor = System.Drawing.SystemColors.Control;
            this.addPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addPrice.Location = new System.Drawing.Point(6, 163);
            this.addPrice.Name = "addPrice";
            this.addPrice.Size = new System.Drawing.Size(126, 23);
            this.addPrice.TabIndex = 1;
            this.addPrice.Text = "Добавить";
            this.addPrice.UseVisualStyleBackColor = false;
            this.addPrice.Click += new System.EventHandler(this.addPrice_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView2.Location = new System.Drawing.Point(3, 17);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(418, 113);
            this.dataGridView2.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Услуга";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 140;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Цена";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 135;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Измерение";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 140;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(422, 355);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Инстуркция";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(8, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(413, 206);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 381);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Parent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Показания счетчиков";
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addValue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combChooseMeter;
        private System.Windows.Forms.Button addMeter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button addPrice;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox combChooseMeter4;
        private System.Windows.Forms.TextBox servicePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button changePrice;
        private System.Windows.Forms.Button deletePrice;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox combChooseMeter6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox newServicePrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combChooseMeter5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

