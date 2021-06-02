
namespace BTL_PTUD.Forms.Panels {
    partial class ClassUserControl {
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.classButtonTemplate1 = new BTL_PTUD.Forms.Panels.ClassButtonTemplate();
            this.classButtonTemplate2 = new BTL_PTUD.Forms.Panels.ClassButtonTemplate();
            this.classButtonTemplate3 = new BTL_PTUD.Forms.Panels.ClassButtonTemplate();
            this.classButtonTemplate4 = new BTL_PTUD.Forms.Panels.ClassButtonTemplate();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách lớp học";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.classButtonTemplate1);
            this.flowLayoutPanel1.Controls.Add(this.classButtonTemplate2);
            this.flowLayoutPanel1.Controls.Add(this.classButtonTemplate3);
            this.flowLayoutPanel1.Controls.Add(this.classButtonTemplate4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 73);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(743, 305);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // classButtonTemplate1
            // 
            this.classButtonTemplate1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classButtonTemplate1.Location = new System.Drawing.Point(3, 3);
            this.classButtonTemplate1.Name = "classButtonTemplate1";
            this.classButtonTemplate1.Size = new System.Drawing.Size(241, 56);
            this.classButtonTemplate1.TabIndex = 0;
            // 
            // classButtonTemplate2
            // 
            this.classButtonTemplate2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classButtonTemplate2.Location = new System.Drawing.Point(250, 3);
            this.classButtonTemplate2.Name = "classButtonTemplate2";
            this.classButtonTemplate2.Size = new System.Drawing.Size(241, 56);
            this.classButtonTemplate2.TabIndex = 0;
            this.classButtonTemplate2.Load += new System.EventHandler(this.classButtonTemplate2_Load);
            // 
            // classButtonTemplate3
            // 
            this.classButtonTemplate3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classButtonTemplate3.Location = new System.Drawing.Point(497, 3);
            this.classButtonTemplate3.Name = "classButtonTemplate3";
            this.classButtonTemplate3.Size = new System.Drawing.Size(241, 56);
            this.classButtonTemplate3.TabIndex = 0;
            this.classButtonTemplate3.Load += new System.EventHandler(this.classButtonTemplate2_Load);
            // 
            // classButtonTemplate4
            // 
            this.classButtonTemplate4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classButtonTemplate4.Location = new System.Drawing.Point(3, 65);
            this.classButtonTemplate4.Name = "classButtonTemplate4";
            this.classButtonTemplate4.Size = new System.Drawing.Size(241, 56);
            this.classButtonTemplate4.TabIndex = 0;
            this.classButtonTemplate4.Load += new System.EventHandler(this.classButtonTemplate2_Load);
            // 
            // ClassUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "ClassUserControl";
            this.Size = new System.Drawing.Size(786, 398);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ClassButtonTemplate classButtonTemplate1;
        private ClassButtonTemplate classButtonTemplate2;
        private ClassButtonTemplate classButtonTemplate3;
        private ClassButtonTemplate classButtonTemplate4;
    }
}
