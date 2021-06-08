
namespace BTL_PTUD.Forms {
    partial class ClassForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbExams = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCreationDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelExamOrder = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelLimitTimes = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelQuestionAmount = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.Student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Access_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Times = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvChoices = new System.Windows.Forms.DataGridView();
            this.Question_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_true = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoices)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kỳ thi:";
            // 
            // cbExams
            // 
            this.cbExams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExams.FormattingEnabled = true;
            this.cbExams.Location = new System.Drawing.Point(121, 12);
            this.cbExams.Name = "cbExams";
            this.cbExams.Size = new System.Drawing.Size(148, 21);
            this.cbExams.Sorted = true;
            this.cbExams.TabIndex = 1;
            this.cbExams.SelectedIndexChanged += new System.EventHandler(this.OnExamChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày tạo:";
            // 
            // labelCreationDate
            // 
            this.labelCreationDate.AutoSize = true;
            this.labelCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreationDate.Location = new System.Drawing.Point(118, 43);
            this.labelCreationDate.Name = "labelCreationDate";
            this.labelCreationDate.Size = new System.Drawing.Size(72, 16);
            this.labelCreationDate.TabIndex = 0;
            this.labelCreationDate.Text = "01/01/1970";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thời gian thi:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(118, 73);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(29, 16);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "300";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loại kỳ thi:";
            // 
            // labelExamOrder
            // 
            this.labelExamOrder.AutoSize = true;
            this.labelExamOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExamOrder.Location = new System.Drawing.Point(118, 103);
            this.labelExamOrder.Name = "labelExamOrder";
            this.labelExamOrder.Size = new System.Drawing.Size(53, 16);
            this.labelExamOrder.TabIndex = 0;
            this.labelExamOrder.Text = "Giữa kỳ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(499, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày bắt đầu:";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDate.Location = new System.Drawing.Point(607, 14);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(72, 16);
            this.labelStartDate.TabIndex = 0;
            this.labelStartDate.Text = "01/01/1970";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(499, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ngày kết thúc:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndDate.Location = new System.Drawing.Point(607, 43);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(72, 16);
            this.labelEndDate.TabIndex = 0;
            this.labelEndDate.Text = "01/01/1970";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(499, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Giới hạn làm:";
            // 
            // labelLimitTimes
            // 
            this.labelLimitTimes.AutoSize = true;
            this.labelLimitTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLimitTimes.Location = new System.Drawing.Point(607, 73);
            this.labelLimitTimes.Name = "labelLimitTimes";
            this.labelLimitTimes.Size = new System.Drawing.Size(25, 16);
            this.labelLimitTimes.TabIndex = 0;
            this.labelLimitTimes.Text = "10 ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(499, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Số câu hỏi:";
            // 
            // labelQuestionAmount
            // 
            this.labelQuestionAmount.AutoSize = true;
            this.labelQuestionAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionAmount.Location = new System.Drawing.Point(607, 103);
            this.labelQuestionAmount.Name = "labelQuestionAmount";
            this.labelQuestionAmount.Size = new System.Drawing.Size(22, 16);
            this.labelQuestionAmount.TabIndex = 0;
            this.labelQuestionAmount.Text = "50";
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_id,
            this.Student_name,
            this.Score,
            this.Access_time,
            this.Times});
            this.dgvResults.Location = new System.Drawing.Point(13, 162);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(423, 425);
            this.dgvResults.TabIndex = 2;
            this.dgvResults.SelectionChanged += new System.EventHandler(this.OnSelectionChanged);
            // 
            // Student_id
            // 
            this.Student_id.HeaderText = "Mã sinh viên";
            this.Student_id.Name = "Student_id";
            this.Student_id.ReadOnly = true;
            this.Student_id.Width = 85;
            // 
            // Student_name
            // 
            this.Student_name.HeaderText = "Tên";
            this.Student_name.Name = "Student_name";
            this.Student_name.ReadOnly = true;
            this.Student_name.Width = 120;
            // 
            // Score
            // 
            this.Score.HeaderText = "Điểm";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 50;
            // 
            // Access_time
            // 
            this.Access_time.HeaderText = "Thời gian";
            this.Access_time.Name = "Access_time";
            this.Access_time.ReadOnly = true;
            this.Access_time.Width = 70;
            // 
            // Times
            // 
            this.Times.HeaderText = "Lần làm";
            this.Times.Name = "Times";
            this.Times.ReadOnly = true;
            this.Times.Width = 55;
            // 
            // dgvChoices
            // 
            this.dgvChoices.AllowUserToAddRows = false;
            this.dgvChoices.AllowUserToDeleteRows = false;
            this.dgvChoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Question_id,
            this.is_true,
            this.Answer});
            this.dgvChoices.Location = new System.Drawing.Point(442, 162);
            this.dgvChoices.Name = "dgvChoices";
            this.dgvChoices.Size = new System.Drawing.Size(607, 425);
            this.dgvChoices.TabIndex = 3;
            // 
            // Question_id
            // 
            this.Question_id.HeaderText = "Câu hỏi";
            this.Question_id.Name = "Question_id";
            this.Question_id.ReadOnly = true;
            this.Question_id.Width = 300;
            // 
            // is_true
            // 
            this.is_true.HeaderText = "Kết quả";
            this.is_true.Name = "is_true";
            this.is_true.ReadOnly = true;
            this.is_true.Width = 55;
            // 
            // Answer
            // 
            this.Answer.HeaderText = "Đã chọn";
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.Width = 208;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbExams);
            this.panel1.Controls.Add(this.labelExamOrder);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.labelQuestionAmount);
            this.panel1.Controls.Add(this.labelLimitTimes);
            this.panel1.Controls.Add(this.labelEndDate);
            this.panel1.Controls.Add(this.labelStartDate);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.labelCreationDate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(167, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 132);
            this.panel1.TabIndex = 4;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(94, 36);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Quay lại";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.OnButtonBackClick);
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 595);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvChoices);
            this.Controls.Add(this.dgvResults);
            this.Name = "ClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết quả theo lớp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoices)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbExams;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCreationDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelExamOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelLimitTimes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelQuestionAmount;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataGridView dgvChoices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_true;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Access_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Times;
    }
}