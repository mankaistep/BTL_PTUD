
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.classUC = new BTL_PTUD.Forms.Panels.ClassUserControl();
            this.xmUC = new BTL_PTUD.Forms.Panels.ExamUserControl();
            this.xmtUC = new BTL_PTUD.Forms.Panels.ExaminationUserControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 57);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(468, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 50);
            this.button3.TabIndex = 0;
            this.button3.Text = "Kỳ thi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.onExaminationButtonClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 50);
            this.button2.TabIndex = 0;
            this.button2.Text = "Lớp học";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.onClassButtonClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Học liệu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onExamButtonClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.xmUC);
            this.panel2.Controls.Add(this.xmtUC);
            this.panel2.Controls.Add(this.classUC);
            this.panel2.Location = new System.Drawing.Point(13, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 443);
            this.panel2.TabIndex = 2;
            // 
            // classUC
            // 
            this.classUC.Location = new System.Drawing.Point(3, 3);
            this.classUC.Name = "classUC";
            this.classUC.Size = new System.Drawing.Size(769, 437);
            this.classUC.TabIndex = 1;
            this.classUC.Click += new System.EventHandler(this.onClassButtonClick);
            // 
            // xmUC
            // 
            this.xmUC.Location = new System.Drawing.Point(3, 3);
            this.xmUC.Name = "xmUC";
            this.xmUC.Size = new System.Drawing.Size(769, 437);
            this.xmUC.TabIndex = 0;
            // 
            // xmtUC
            // 
            this.xmtUC.Location = new System.Drawing.Point(3, 3);
            this.xmtUC.Name = "xmtUC";
            this.xmtUC.Size = new System.Drawing.Size(769, 437);
            this.xmtUC.TabIndex = 2;
            // 
            // MainTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainTeacherForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private Panels.ExamUserControl xmUC;
        private Panels.ClassUserControl classUC;
        private Panels.ExaminationUserControl xmtUC;
    }
}