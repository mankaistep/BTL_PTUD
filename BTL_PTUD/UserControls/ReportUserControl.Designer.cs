
namespace BTL_PTUD.Forms.Panels {
    partial class ReportUserControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.cbEDYear = new System.Windows.Forms.ComboBox();
            this.cbSTYear = new System.Windows.Forms.ComboBox();
            this.cbEDMonth = new System.Windows.Forms.ComboBox();
            this.cbSTMonth = new System.Windows.Forms.ComboBox();
            this.cbEDDay = new System.Windows.Forms.ComboBox();
            this.cbSTDay = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lọc kỳ thi bắt đầu từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tạo báo cáo kết quả thi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đến ngày";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(240, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Báo cáo theo lớp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnButtonClassClick);
            // 
            // btnSubject
            // 
            this.btnSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubject.Location = new System.Drawing.Point(240, 315);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(289, 39);
            this.btnSubject.TabIndex = 2;
            this.btnSubject.Text = "Báo cáo theo môn học";
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.OnButtonSubjectClick);
            // 
            // cbEDYear
            // 
            this.cbEDYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEDYear.FormattingEnabled = true;
            this.cbEDYear.Location = new System.Drawing.Point(485, 185);
            this.cbEDYear.Name = "cbEDYear";
            this.cbEDYear.Size = new System.Drawing.Size(67, 21);
            this.cbEDYear.TabIndex = 7;
            this.cbEDYear.TabStop = false;
            // 
            // cbSTYear
            // 
            this.cbSTYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSTYear.FormattingEnabled = true;
            this.cbSTYear.Location = new System.Drawing.Point(485, 138);
            this.cbSTYear.Name = "cbSTYear";
            this.cbSTYear.Size = new System.Drawing.Size(67, 21);
            this.cbSTYear.TabIndex = 8;
            this.cbSTYear.TabStop = false;
            // 
            // cbEDMonth
            // 
            this.cbEDMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEDMonth.FormattingEnabled = true;
            this.cbEDMonth.Location = new System.Drawing.Point(411, 185);
            this.cbEDMonth.Name = "cbEDMonth";
            this.cbEDMonth.Size = new System.Drawing.Size(46, 21);
            this.cbEDMonth.TabIndex = 9;
            this.cbEDMonth.TabStop = false;
            // 
            // cbSTMonth
            // 
            this.cbSTMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSTMonth.FormattingEnabled = true;
            this.cbSTMonth.Location = new System.Drawing.Point(411, 138);
            this.cbSTMonth.Name = "cbSTMonth";
            this.cbSTMonth.Size = new System.Drawing.Size(46, 21);
            this.cbSTMonth.TabIndex = 10;
            this.cbSTMonth.TabStop = false;
            // 
            // cbEDDay
            // 
            this.cbEDDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEDDay.FormattingEnabled = true;
            this.cbEDDay.Location = new System.Drawing.Point(340, 185);
            this.cbEDDay.Name = "cbEDDay";
            this.cbEDDay.Size = new System.Drawing.Size(46, 21);
            this.cbEDDay.TabIndex = 11;
            this.cbEDDay.TabStop = false;
            // 
            // cbSTDay
            // 
            this.cbSTDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSTDay.FormattingEnabled = true;
            this.cbSTDay.Location = new System.Drawing.Point(340, 138);
            this.cbSTDay.Name = "cbSTDay";
            this.cbSTDay.Size = new System.Drawing.Size(46, 21);
            this.cbSTDay.TabIndex = 12;
            this.cbSTDay.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(466, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(466, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "/";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(392, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "/";
            // 
            // ReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbEDYear);
            this.Controls.Add(this.cbSTYear);
            this.Controls.Add(this.cbEDMonth);
            this.Controls.Add(this.cbSTMonth);
            this.Controls.Add(this.cbEDDay);
            this.Controls.Add(this.cbSTDay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSubject);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ReportUserControl";
            this.Size = new System.Drawing.Size(786, 398);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.ComboBox cbEDYear;
        private System.Windows.Forms.ComboBox cbSTYear;
        private System.Windows.Forms.ComboBox cbEDMonth;
        private System.Windows.Forms.ComboBox cbSTMonth;
        private System.Windows.Forms.ComboBox cbEDDay;
        private System.Windows.Forms.ComboBox cbSTDay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
    }
}
