namespace Показания_счетчиков
{
    partial class formAddMeter
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
            this.combChooseMeter3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.TextBox();
            this.addMeterClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combChooseMeter3
            // 
            this.combChooseMeter3.FormattingEnabled = true;
            this.combChooseMeter3.Location = new System.Drawing.Point(91, 24);
            this.combChooseMeter3.Name = "combChooseMeter3";
            this.combChooseMeter3.Size = new System.Drawing.Size(100, 21);
            this.combChooseMeter3.TabIndex = 0;
            this.combChooseMeter3.DropDown += new System.EventHandler(this.combChooseMeter3_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберете услугу:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(91, 76);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(100, 20);
            this.comment.TabIndex = 3;
            // 
            // addMeterClose
            // 
            this.addMeterClose.Location = new System.Drawing.Point(91, 116);
            this.addMeterClose.Margin = new System.Windows.Forms.Padding(2);
            this.addMeterClose.Name = "addMeterClose";
            this.addMeterClose.Size = new System.Drawing.Size(99, 19);
            this.addMeterClose.TabIndex = 4;
            this.addMeterClose.Text = "Применить";
            this.addMeterClose.UseVisualStyleBackColor = true;
            this.addMeterClose.Click += new System.EventHandler(this.addMeterClose_Click);
            // 
            // formAddMeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 191);
            this.Controls.Add(this.addMeterClose);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combChooseMeter3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formAddMeter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить счетчик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combChooseMeter3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.Button addMeterClose;
    }
}