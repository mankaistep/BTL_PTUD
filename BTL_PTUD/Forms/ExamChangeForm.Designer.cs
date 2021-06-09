
namespace BTL_PTUD.Forms {
    partial class ExamChangeForm {
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
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTAHour = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTAMinute = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTASecond = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSTDay = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSTMonth = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSTYear = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbEDDay = new System.Windows.Forms.ComboBox();
            this.cbEDMonth = new System.Windows.Forms.ComboBox();
            this.cbEDYear = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonLimit = new System.Windows.Forms.CheckBox();
            this.cbLimitTimes = new System.Windows.Forms.ComboBox();
            this.labelLimitTimes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbOrder = new System.Windows.Forms.ComboBox();
            this.cbQuestionAmount = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQSave = new System.Windows.Forms.Button();
            this.btnQRemove = new System.Windows.Forms.Button();
            this.btnExamImport = new System.Windows.Forms.Button();
            this.btnQuestionAdd = new System.Windows.Forms.Button();
            this.btnIsTrue5 = new System.Windows.Forms.RadioButton();
            this.btnIsTrue4 = new System.Windows.Forms.RadioButton();
            this.btnIsTrue3 = new System.Windows.Forms.RadioButton();
            this.btnIsTrue2 = new System.Windows.Forms.RadioButton();
            this.btnIsTrue1 = new System.Windows.Forms.RadioButton();
            this.rtbAnswer5 = new System.Windows.Forms.RichTextBox();
            this.rtbAnswer4 = new System.Windows.Forms.RichTextBox();
            this.rtbAnswer3 = new System.Windows.Forms.RichTextBox();
            this.rtbAnswer2 = new System.Windows.Forms.RichTextBox();
            this.rtbAnswer1 = new System.Windows.Forms.RichTextBox();
            this.rtbQuestion = new System.Windows.Forms.RichTextBox();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answers_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnRollback = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp học";
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(129, 24);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(252, 21);
            this.cbClass.TabIndex = 1;
            this.cbClass.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thời gian làm bài";
            // 
            // cbTAHour
            // 
            this.cbTAHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTAHour.FormattingEnabled = true;
            this.cbTAHour.Location = new System.Drawing.Point(129, 56);
            this.cbTAHour.Name = "cbTAHour";
            this.cbTAHour.Size = new System.Drawing.Size(46, 21);
            this.cbTAHour.TabIndex = 2;
            this.cbTAHour.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "giờ";
            // 
            // cbTAMinute
            // 
            this.cbTAMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTAMinute.FormattingEnabled = true;
            this.cbTAMinute.Location = new System.Drawing.Point(210, 56);
            this.cbTAMinute.Name = "cbTAMinute";
            this.cbTAMinute.Size = new System.Drawing.Size(46, 21);
            this.cbTAMinute.TabIndex = 2;
            this.cbTAMinute.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "phút";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "giây";
            // 
            // cbTASecond
            // 
            this.cbTASecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTASecond.FormattingEnabled = true;
            this.cbTASecond.Location = new System.Drawing.Point(295, 56);
            this.cbTASecond.Name = "cbTASecond";
            this.cbTASecond.Size = new System.Drawing.Size(46, 21);
            this.cbTASecond.TabIndex = 2;
            this.cbTASecond.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày bắt đầu";
            // 
            // cbSTDay
            // 
            this.cbSTDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSTDay.FormattingEnabled = true;
            this.cbSTDay.Location = new System.Drawing.Point(546, 24);
            this.cbSTDay.Name = "cbSTDay";
            this.cbSTDay.Size = new System.Drawing.Size(46, 21);
            this.cbSTDay.TabIndex = 2;
            this.cbSTDay.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(598, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "/";
            // 
            // cbSTMonth
            // 
            this.cbSTMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSTMonth.FormattingEnabled = true;
            this.cbSTMonth.Location = new System.Drawing.Point(617, 24);
            this.cbSTMonth.Name = "cbSTMonth";
            this.cbSTMonth.Size = new System.Drawing.Size(46, 21);
            this.cbSTMonth.TabIndex = 2;
            this.cbSTMonth.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(672, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "/";
            // 
            // cbSTYear
            // 
            this.cbSTYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSTYear.FormattingEnabled = true;
            this.cbSTYear.Location = new System.Drawing.Point(691, 24);
            this.cbSTYear.Name = "cbSTYear";
            this.cbSTYear.Size = new System.Drawing.Size(67, 21);
            this.cbSTYear.TabIndex = 2;
            this.cbSTYear.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(432, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày kết thúc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(598, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "/";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(672, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "/";
            // 
            // cbEDDay
            // 
            this.cbEDDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEDDay.FormattingEnabled = true;
            this.cbEDDay.Location = new System.Drawing.Point(546, 56);
            this.cbEDDay.Name = "cbEDDay";
            this.cbEDDay.Size = new System.Drawing.Size(46, 21);
            this.cbEDDay.TabIndex = 2;
            this.cbEDDay.TabStop = false;
            // 
            // cbEDMonth
            // 
            this.cbEDMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEDMonth.FormattingEnabled = true;
            this.cbEDMonth.Location = new System.Drawing.Point(617, 56);
            this.cbEDMonth.Name = "cbEDMonth";
            this.cbEDMonth.Size = new System.Drawing.Size(46, 21);
            this.cbEDMonth.TabIndex = 2;
            this.cbEDMonth.TabStop = false;
            // 
            // cbEDYear
            // 
            this.cbEDYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEDYear.FormattingEnabled = true;
            this.cbEDYear.Location = new System.Drawing.Point(691, 56);
            this.cbEDYear.Name = "cbEDYear";
            this.cbEDYear.Size = new System.Drawing.Size(67, 21);
            this.cbEDYear.TabIndex = 2;
            this.cbEDYear.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Giới hạn lần làm";
            // 
            // buttonLimit
            // 
            this.buttonLimit.AutoSize = true;
            this.buttonLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimit.Location = new System.Drawing.Point(129, 90);
            this.buttonLimit.Name = "buttonLimit";
            this.buttonLimit.Size = new System.Drawing.Size(44, 20);
            this.buttonLimit.TabIndex = 3;
            this.buttonLimit.TabStop = false;
            this.buttonLimit.Text = "Có";
            this.buttonLimit.UseVisualStyleBackColor = true;
            this.buttonLimit.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // cbLimitTimes
            // 
            this.cbLimitTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLimitTimes.FormattingEnabled = true;
            this.cbLimitTimes.Location = new System.Drawing.Point(210, 87);
            this.cbLimitTimes.Name = "cbLimitTimes";
            this.cbLimitTimes.Size = new System.Drawing.Size(46, 21);
            this.cbLimitTimes.TabIndex = 2;
            this.cbLimitTimes.TabStop = false;
            // 
            // labelLimitTimes
            // 
            this.labelLimitTimes.AutoSize = true;
            this.labelLimitTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLimitTimes.Location = new System.Drawing.Point(262, 91);
            this.labelLimitTimes.Name = "labelLimitTimes";
            this.labelLimitTimes.Size = new System.Drawing.Size(26, 16);
            this.labelLimitTimes.TabIndex = 0;
            this.labelLimitTimes.Text = "lần";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonLimit);
            this.panel1.Controls.Add(this.cbTASecond);
            this.panel1.Controls.Add(this.cbLimitTimes);
            this.panel1.Controls.Add(this.cbTAMinute);
            this.panel1.Controls.Add(this.cbEDYear);
            this.panel1.Controls.Add(this.cbSTYear);
            this.panel1.Controls.Add(this.cbEDMonth);
            this.panel1.Controls.Add(this.cbSTMonth);
            this.panel1.Controls.Add(this.cbOrder);
            this.panel1.Controls.Add(this.cbEDDay);
            this.panel1.Controls.Add(this.cbSTDay);
            this.panel1.Controls.Add(this.cbQuestionAmount);
            this.panel1.Controls.Add(this.cbTAHour);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbClass);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.labelLimitTimes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 149);
            this.panel1.TabIndex = 4;
            // 
            // cbOrder
            // 
            this.cbOrder.FormattingEnabled = true;
            this.cbOrder.Items.AddRange(new object[] {
            "Bài tập",
            "Giữa kỳ",
            "Cuối kỳ"});
            this.cbOrder.Location = new System.Drawing.Point(546, 86);
            this.cbOrder.Name = "cbOrder";
            this.cbOrder.Size = new System.Drawing.Size(117, 21);
            this.cbOrder.TabIndex = 2;
            this.cbOrder.TabStop = false;
            // 
            // cbQuestionAmount
            // 
            this.cbQuestionAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuestionAmount.FormattingEnabled = true;
            this.cbQuestionAmount.Location = new System.Drawing.Point(129, 119);
            this.cbQuestionAmount.Name = "cbQuestionAmount";
            this.cbQuestionAmount.Size = new System.Drawing.Size(75, 21);
            this.cbQuestionAmount.TabIndex = 2;
            this.cbQuestionAmount.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(210, 124);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 16);
            this.label18.TabIndex = 0;
            this.label18.Text = "câu";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(432, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 18);
            this.label16.TabIndex = 0;
            this.label16.Text = "Loại kỳ thi";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(4, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 18);
            this.label17.TabIndex = 0;
            this.label17.Text = "Số lượng câu hỏi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(34, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 18);
            this.label14.TabIndex = 5;
            this.label14.Text = "Thông tin kỳ thi";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnQSave);
            this.panel2.Controls.Add(this.btnQRemove);
            this.panel2.Controls.Add(this.btnExamImport);
            this.panel2.Controls.Add(this.btnQuestionAdd);
            this.panel2.Controls.Add(this.btnIsTrue5);
            this.panel2.Controls.Add(this.btnIsTrue4);
            this.panel2.Controls.Add(this.btnIsTrue3);
            this.panel2.Controls.Add(this.btnIsTrue2);
            this.panel2.Controls.Add(this.btnIsTrue1);
            this.panel2.Controls.Add(this.rtbAnswer5);
            this.panel2.Controls.Add(this.rtbAnswer4);
            this.panel2.Controls.Add(this.rtbAnswer3);
            this.panel2.Controls.Add(this.rtbAnswer2);
            this.panel2.Controls.Add(this.rtbAnswer1);
            this.panel2.Controls.Add(this.rtbQuestion);
            this.panel2.Controls.Add(this.dgvQuestions);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(8, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 436);
            this.panel2.TabIndex = 6;
            // 
            // btnQSave
            // 
            this.btnQSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQSave.Location = new System.Drawing.Point(241, 344);
            this.btnQSave.Name = "btnQSave";
            this.btnQSave.Size = new System.Drawing.Size(100, 36);
            this.btnQSave.TabIndex = 4;
            this.btnQSave.TabStop = false;
            this.btnQSave.Text = "Lưu câu hỏi";
            this.btnQSave.UseVisualStyleBackColor = true;
            this.btnQSave.Click += new System.EventHandler(this.OnButtonQSave);
            // 
            // btnQRemove
            // 
            this.btnQRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQRemove.Location = new System.Drawing.Point(124, 344);
            this.btnQRemove.Name = "btnQRemove";
            this.btnQRemove.Size = new System.Drawing.Size(97, 36);
            this.btnQRemove.TabIndex = 4;
            this.btnQRemove.TabStop = false;
            this.btnQRemove.Text = "Xóa câu hỏi";
            this.btnQRemove.UseVisualStyleBackColor = true;
            this.btnQRemove.Click += new System.EventHandler(this.OnButtonQRemove);
            // 
            // btnExamImport
            // 
            this.btnExamImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamImport.Location = new System.Drawing.Point(7, 386);
            this.btnExamImport.Name = "btnExamImport";
            this.btnExamImport.Size = new System.Drawing.Size(334, 36);
            this.btnExamImport.TabIndex = 4;
            this.btnExamImport.TabStop = false;
            this.btnExamImport.Text = "Lấy câu hỏi từ kỳ thi khác";
            this.btnExamImport.UseVisualStyleBackColor = true;
            this.btnExamImport.Click += new System.EventHandler(this.OnButtonExamImportClick);
            // 
            // btnQuestionAdd
            // 
            this.btnQuestionAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestionAdd.Location = new System.Drawing.Point(7, 344);
            this.btnQuestionAdd.Name = "btnQuestionAdd";
            this.btnQuestionAdd.Size = new System.Drawing.Size(100, 36);
            this.btnQuestionAdd.TabIndex = 4;
            this.btnQuestionAdd.TabStop = false;
            this.btnQuestionAdd.Text = "Thêm mới";
            this.btnQuestionAdd.UseVisualStyleBackColor = true;
            this.btnQuestionAdd.Click += new System.EventHandler(this.OnQuestionAddButtonClick);
            // 
            // btnIsTrue5
            // 
            this.btnIsTrue5.AutoSize = true;
            this.btnIsTrue5.Location = new System.Drawing.Point(367, 383);
            this.btnIsTrue5.Name = "btnIsTrue5";
            this.btnIsTrue5.Size = new System.Drawing.Size(51, 17);
            this.btnIsTrue5.TabIndex = 2;
            this.btnIsTrue5.Text = "Đúng";
            this.btnIsTrue5.UseVisualStyleBackColor = true;
            // 
            // btnIsTrue4
            // 
            this.btnIsTrue4.AutoSize = true;
            this.btnIsTrue4.Location = new System.Drawing.Point(367, 321);
            this.btnIsTrue4.Name = "btnIsTrue4";
            this.btnIsTrue4.Size = new System.Drawing.Size(51, 17);
            this.btnIsTrue4.TabIndex = 2;
            this.btnIsTrue4.Text = "Đúng";
            this.btnIsTrue4.UseVisualStyleBackColor = true;
            // 
            // btnIsTrue3
            // 
            this.btnIsTrue3.AutoSize = true;
            this.btnIsTrue3.Location = new System.Drawing.Point(367, 259);
            this.btnIsTrue3.Name = "btnIsTrue3";
            this.btnIsTrue3.Size = new System.Drawing.Size(51, 17);
            this.btnIsTrue3.TabIndex = 2;
            this.btnIsTrue3.Text = "Đúng";
            this.btnIsTrue3.UseVisualStyleBackColor = true;
            // 
            // btnIsTrue2
            // 
            this.btnIsTrue2.AutoSize = true;
            this.btnIsTrue2.Location = new System.Drawing.Point(367, 197);
            this.btnIsTrue2.Name = "btnIsTrue2";
            this.btnIsTrue2.Size = new System.Drawing.Size(51, 17);
            this.btnIsTrue2.TabIndex = 2;
            this.btnIsTrue2.Text = "Đúng";
            this.btnIsTrue2.UseVisualStyleBackColor = true;
            // 
            // btnIsTrue1
            // 
            this.btnIsTrue1.AutoSize = true;
            this.btnIsTrue1.Checked = true;
            this.btnIsTrue1.Location = new System.Drawing.Point(367, 135);
            this.btnIsTrue1.Name = "btnIsTrue1";
            this.btnIsTrue1.Size = new System.Drawing.Size(51, 17);
            this.btnIsTrue1.TabIndex = 2;
            this.btnIsTrue1.TabStop = true;
            this.btnIsTrue1.Text = "Đúng";
            this.btnIsTrue1.UseVisualStyleBackColor = true;
            // 
            // rtbAnswer5
            // 
            this.rtbAnswer5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAnswer5.Location = new System.Drawing.Point(424, 363);
            this.rtbAnswer5.Name = "rtbAnswer5";
            this.rtbAnswer5.Size = new System.Drawing.Size(334, 56);
            this.rtbAnswer5.TabIndex = 6;
            this.rtbAnswer5.Text = "";
            this.rtbAnswer5.Enter += new System.EventHandler(this.OnQARTBEnter);
            this.rtbAnswer5.Leave += new System.EventHandler(this.OnQARTBLeave);
            // 
            // rtbAnswer4
            // 
            this.rtbAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAnswer4.Location = new System.Drawing.Point(424, 301);
            this.rtbAnswer4.Name = "rtbAnswer4";
            this.rtbAnswer4.Size = new System.Drawing.Size(334, 56);
            this.rtbAnswer4.TabIndex = 5;
            this.rtbAnswer4.Text = "";
            this.rtbAnswer4.Enter += new System.EventHandler(this.OnQARTBEnter);
            this.rtbAnswer4.Leave += new System.EventHandler(this.OnQARTBLeave);
            // 
            // rtbAnswer3
            // 
            this.rtbAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAnswer3.Location = new System.Drawing.Point(424, 239);
            this.rtbAnswer3.Name = "rtbAnswer3";
            this.rtbAnswer3.Size = new System.Drawing.Size(334, 56);
            this.rtbAnswer3.TabIndex = 4;
            this.rtbAnswer3.Text = "";
            this.rtbAnswer3.Enter += new System.EventHandler(this.OnQARTBEnter);
            this.rtbAnswer3.Leave += new System.EventHandler(this.OnQARTBLeave);
            // 
            // rtbAnswer2
            // 
            this.rtbAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAnswer2.Location = new System.Drawing.Point(424, 177);
            this.rtbAnswer2.Name = "rtbAnswer2";
            this.rtbAnswer2.Size = new System.Drawing.Size(334, 56);
            this.rtbAnswer2.TabIndex = 3;
            this.rtbAnswer2.Text = "";
            this.rtbAnswer2.Enter += new System.EventHandler(this.OnQARTBEnter);
            this.rtbAnswer2.Leave += new System.EventHandler(this.OnQARTBLeave);
            // 
            // rtbAnswer1
            // 
            this.rtbAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAnswer1.Location = new System.Drawing.Point(424, 115);
            this.rtbAnswer1.Name = "rtbAnswer1";
            this.rtbAnswer1.Size = new System.Drawing.Size(334, 56);
            this.rtbAnswer1.TabIndex = 2;
            this.rtbAnswer1.Text = "";
            this.rtbAnswer1.Enter += new System.EventHandler(this.OnQARTBEnter);
            this.rtbAnswer1.Leave += new System.EventHandler(this.OnQARTBLeave);
            // 
            // rtbQuestion
            // 
            this.rtbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbQuestion.Location = new System.Drawing.Point(346, 13);
            this.rtbQuestion.Name = "rtbQuestion";
            this.rtbQuestion.Size = new System.Drawing.Size(412, 96);
            this.rtbQuestion.TabIndex = 1;
            this.rtbQuestion.Text = "Bài thơ: “Gạo đem vào giã bao đau đớn;Gạo giã xong rồi trắng tựa bông; Sống ở trê" +
    "n đời người cũng vậy; Gian nan rèn luyện mới thành công”: Bài thơ trên ở trong t" +
    "ác phẩm nào của Hồ Chí Minh?";
            this.rtbQuestion.Enter += new System.EventHandler(this.OnQARTBEnter);
            this.rtbQuestion.Leave += new System.EventHandler(this.OnQARTBLeave);
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AllowUserToDeleteRows = false;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Question,
            this.Answers_amount});
            this.dgvQuestions.Location = new System.Drawing.Point(7, 13);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.Size = new System.Drawing.Size(334, 325);
            this.dgvQuestions.TabIndex = 0;
            this.dgvQuestions.TabStop = false;
            this.dgvQuestions.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.OnQuestionsRowValidating);
            this.dgvQuestions.SelectionChanged += new System.EventHandler(this.OnQuestionsSelectionChanged);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 30;
            // 
            // Question
            // 
            this.Question.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Question.HeaderText = "Đề";
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            // 
            // Answers_amount
            // 
            this.Answers_amount.HeaderText = "Số đáp án";
            this.Answers_amount.Name = "Answers_amount";
            this.Answers_amount.ReadOnly = true;
            this.Answers_amount.Width = 50;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(363, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(57, 303);
            this.panel3.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(34, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 18);
            this.label15.TabIndex = 5;
            this.label15.Text = "Câu hỏi";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(626, 642);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 36);
            this.btnSave.TabIndex = 7;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Lưu kỳ thi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnBtnSaveClick);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(8, 642);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(108, 36);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.TabStop = false;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.OnButtonQuit);
            // 
            // btnRollback
            // 
            this.btnRollback.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollback.Location = new System.Drawing.Point(122, 642);
            this.btnRollback.Name = "btnRollback";
            this.btnRollback.Size = new System.Drawing.Size(108, 36);
            this.btnRollback.TabIndex = 7;
            this.btnRollback.TabStop = false;
            this.btnRollback.Text = "Làm mới";
            this.btnRollback.UseVisualStyleBackColor = true;
            this.btnRollback.Click += new System.EventHandler(this.OnButtonRollBackClick);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(376, 642);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 36);
            this.button7.TabIndex = 7;
            this.button7.TabStop = false;
            this.button7.Text = "Tải đề lên";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.OnButtonUploadClick);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(277, 642);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(93, 36);
            this.button9.TabIndex = 7;
            this.button9.TabStop = false;
            this.button9.Text = "Tải đề mẫu";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.OnButtonTemplateDownloadClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(475, 642);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 36);
            this.button1.TabIndex = 7;
            this.button1.TabStop = false;
            this.button1.Text = "Tải đề về";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnButtonDownloadClick);
            // 
            // ExamChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 687);
            this.Controls.Add(this.btnRollback);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ExamChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo mới/Chỉnh sửa kỳ thi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTAHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTAMinute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTASecond;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSTDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSTMonth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSTYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbEDDay;
        private System.Windows.Forms.ComboBox cbEDMonth;
        private System.Windows.Forms.ComboBox cbEDYear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox buttonLimit;
        private System.Windows.Forms.ComboBox cbLimitTimes;
        private System.Windows.Forms.Label labelLimitTimes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbQuestion;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnQSave;
        private System.Windows.Forms.Button btnQRemove;
        private System.Windows.Forms.Button btnQuestionAdd;
        private System.Windows.Forms.RadioButton btnIsTrue5;
        private System.Windows.Forms.RadioButton btnIsTrue4;
        private System.Windows.Forms.RadioButton btnIsTrue3;
        private System.Windows.Forms.RadioButton btnIsTrue2;
        private System.Windows.Forms.RadioButton btnIsTrue1;
        private System.Windows.Forms.RichTextBox rtbAnswer5;
        private System.Windows.Forms.RichTextBox rtbAnswer4;
        private System.Windows.Forms.RichTextBox rtbAnswer3;
        private System.Windows.Forms.RichTextBox rtbAnswer2;
        private System.Windows.Forms.RichTextBox rtbAnswer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnRollback;
        private System.Windows.Forms.ComboBox cbOrder;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbQuestionAmount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnExamImport;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answers_amount;
        private System.Windows.Forms.Button button1;
    }
}