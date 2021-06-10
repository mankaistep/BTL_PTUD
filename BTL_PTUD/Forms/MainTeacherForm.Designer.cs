
namespace BTL_PTUD.Forms {
    partial class MainTeacherForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.examUC = new BTL_PTUD.Forms.Panels.ExaminationUserControl();
            this.classUC = new BTL_PTUD.Forms.Panels.ClassUserControl();
            this.reportUC = new BTL_PTUD.Forms.Panels.ReportUserControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExam);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnClass);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 57);
            this.panel1.TabIndex = 1;
            // 
            // btnExam
            // 
            this.btnExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExam.Location = new System.Drawing.Point(136, 4);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(161, 50);
            this.btnExam.TabIndex = 0;
            this.btnExam.Text = "Kỳ thi";
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.OnExaminationButtonClick);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(470, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(161, 50);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.OnReportButtonClick);
            // 
            // btnClass
            // 
            this.btnClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.Location = new System.Drawing.Point(303, 4);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(161, 50);
            this.btnClass.TabIndex = 0;
            this.btnClass.Text = "Lớp học";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.OnClassButtonClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.examUC);
            this.panel2.Controls.Add(this.classUC);
            this.panel2.Controls.Add(this.reportUC);
            this.panel2.Location = new System.Drawing.Point(13, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 443);
            this.panel2.TabIndex = 2;
            // 
            // examUC
            // 
            this.examUC.Location = new System.Drawing.Point(3, 3);
            this.examUC.Name = "examUC";
            this.examUC.Size = new System.Drawing.Size(769, 437);
            this.examUC.TabIndex = 2;
            // 
            // classUC
            // 
            this.classUC.Location = new System.Drawing.Point(-3, 3);
            this.classUC.Name = "classUC";
            this.classUC.Size = new System.Drawing.Size(781, 437);
            this.classUC.TabIndex = 1;
            this.classUC.Click += new System.EventHandler(this.OnClassButtonClick);
            // 
            // reportUC
            // 
            this.reportUC.Location = new System.Drawing.Point(-1, 0);
            this.reportUC.Name = "reportUC";
            this.reportUC.Size = new System.Drawing.Size(776, 443);
            this.reportUC.TabIndex = 3;
            // 
            // MainTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainTeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "11192033 - GV Trần Chí Đức";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Panel panel2;
        private Panels.ClassUserControl classUC;
        private Panels.ExaminationUserControl examUC;
        private System.Windows.Forms.Button btnReport;
        private Panels.ReportUserControl reportUC;
    }
}