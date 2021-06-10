using BTL_PTUD.Source.Connection;
using BTL_PTUD.Source.Objects;
using BTL_PTUD.Source.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_PTUD.Forms {
    public partial class ExamChangeForm : Form {

        public Exam CurrentExam { get; set; }

        private const string questionDefault = "Điền câu hỏi";
        private Dictionary<RichTextBox, string> answerDefaults;

        private Exam sourceExam;

        private List<Class> availableClasses;

        private List<RichTextBox> rtbAnswers;
        private List<RadioButton> btnIsTrues;

        private List<RichTextBox> allQA;

        private bool canEdit;
        private bool loaded;

        private Question currentQuestion;

        private bool saved;

        public ExamChangeForm() {
            InitializeComponent();
        }

        public ExamChangeForm(string examID) : base() {
            InitializeComponent();
            this.loaded = false;
            this.saved = false;

            // Default values
            this.GenerateDefautValues();

            // Generate news
            if (examID == null) {
                this.CurrentExam = new Exam(MainTeacherForm.MainForm.TeacherID);
                this.canEdit = true;
            }
            else {
                this.CurrentExam = SQLConnections.QueryExam(examID, true);
                this.canEdit = this.CurrentExam.CanEdit();
                if (!this.canEdit) {
                    this.saved = true;
                    MessageBox.Show("Vì kỳ thi đã bắt đầu, không thể chỉnh sửa kỳ thi. Chỉ có thể xem và tải đề về", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MakeUneditable();
                }
            }
            this.sourceExam = clone(this.CurrentExam);

            // Set
            this.GenerateExamValue();

            //...
            this.OnCheckedChanged(null, null);
        }

        public void GenerateExamValue() {
            // Set class
            if (CurrentExam.ClassID != null) this.cbClass.SelectedItem = CurrentExam.ClassID + " " + fromID(CurrentExam.ClassID).Name;

            // Acces time
            if (CurrentExam.Time != 0) {
                this.cbTAHour.SelectedItem = CurrentExam.Time / 3600;
                this.cbTAMinute.SelectedItem = (CurrentExam.Time % 3600) / 60;
                this.cbTASecond.SelectedItem = CurrentExam.Time % 60;
            }

            // Limit
            if (CurrentExam.Limit != 0) {
                this.buttonLimit.Checked = true;
                this.cbLimitTimes.SelectedItem = CurrentExam.Limit;
            }
            else this.buttonLimit.Checked = false;

            // Question amount
            this.cbQuestionAmount.SelectedItem = this.CurrentExam.NumberQuestion;

            // Start date
            if (this.CurrentExam.StartDate != null) {
                this.cbSTDay.SelectedItem = this.CurrentExam.StartDate.Day;
                this.cbSTMonth.SelectedItem = this.CurrentExam.StartDate.Month;
                this.cbSTYear.SelectedItem = this.CurrentExam.StartDate.Year;
            }

            // End date
            if (this.CurrentExam.EndDate != null) {
                this.cbEDDay.SelectedItem = this.CurrentExam.EndDate.Day;
                this.cbEDMonth.SelectedItem = this.CurrentExam.EndDate.Month;
                this.cbEDYear.SelectedItem = this.CurrentExam.EndDate.Year;
            }

            // Exam order
            if (this.CurrentExam.ExamOrder != null) this.cbOrder.Text = this.CurrentExam.ExamOrder;

            // Current Question
            this.currentQuestion = this.CurrentExam.Questions.Count == 0 ? null : this.CurrentExam.Questions[0];

            // Question
            this.dgvQuestions.Rows.Clear();
            for (int i = 0; i < this.CurrentExam.Questions.Count; i++) {
                this.addQuestionToDGV(i, this.CurrentExam.Questions[i]);
            }
        }

        public void GenerateDefautValues() {
            // Generate combobox
            this.cbTAHour.Items.Clear();
            for (int i = 0; i <= 99; i++) this.cbTAHour.Items.Add(i);
            this.cbTAMinute.Items.Clear();
            for (int i = 0; i <= 59; i++) this.cbTAMinute.Items.Add(i);
            this.cbTASecond.Items.Clear();
            for (int i = 0; i <= 59; i++) this.cbTASecond.Items.Add(i);
            this.cbLimitTimes.Items.Clear();
            for (int i = 1; i <= 99; i++) this.cbLimitTimes.Items.Add(i);
            this.cbQuestionAmount.Items.Clear();
            for (int i = 1; i <= 999; i++) this.cbQuestionAmount.Items.Add(i);
            this.cbSTDay.Items.Clear();
            this.cbEDDay.Items.Clear();
            for (int i = 1; i <= 31; i++) {
                this.cbSTDay.Items.Add(i);
                this.cbEDDay.Items.Add(i);
            }
            this.cbSTMonth.Items.Clear();
            this.cbSTMonth.Items.Clear();
            for (int i = 1; i <= 12; i++) {
                this.cbSTMonth.Items.Add(i);
                this.cbEDMonth.Items.Add(i);
            }
            int currentYear = DateTime.Now.Year;
            this.cbSTYear.Items.Clear();
            this.cbEDYear.Items.Clear();
            for (int i = currentYear; i <= currentYear + 100; i++) {
                this.cbSTYear.Items.Add(i);
                this.cbEDYear.Items.Add(i);
            }

            // Answers
            this.rtbAnswers = new List<RichTextBox>() { rtbAnswer1, rtbAnswer2, rtbAnswer3, rtbAnswer4, rtbAnswer5 };
            this.btnIsTrues = new List<RadioButton>() { btnIsTrue1, btnIsTrue2, btnIsTrue3, btnIsTrue4, btnIsTrue5 };
            this.answerDefaults = new Dictionary<RichTextBox, string>();
            answerDefaults.Add(rtbAnswer1, "Điền câu trả lời thứ nhất");
            answerDefaults.Add(rtbAnswer2, "Điền câu trả lời thứ hai");
            answerDefaults.Add(rtbAnswer3, "Điền câu trả lời thứ ba (Không bắt buộc)");
            answerDefaults.Add(rtbAnswer4, "Điền câu trả lời thứ nhất (Không bắt buộc)");
            answerDefaults.Add(rtbAnswer5, "Điền câu trả lời thứ nhất (Không bắt buộc)");

            // QA
            this.allQA = new List<RichTextBox> ();
            this.allQA.Add(rtbQuestion);
            foreach (var rtba in rtbAnswers) this.allQA.Add(rtba);

            // Defaults
            this.rtbQuestion.Text = questionDefault;
            foreach (KeyValuePair<RichTextBox, string> e in answerDefaults) {
                e.Key.Text = e.Value;
            }

            // Class
            this.availableClasses = SQLConnections.QueryClasses(MainTeacherForm.MainForm.TeacherID);
            cbClass.Items.Clear();
            foreach (var cls in this.availableClasses) {
                cbClass.Items.Add(cls.ID + " " + cls.Name);
            }

            // Order
            this.cbOrder.Text = "";

            // Questions
            this.dgvQuestions.Rows.Clear();
        }

        public void AddNewQuestion() {
            List<Answer> answers = new List<Answer>();
            for (int i = 1; i <= 2; i++) {
                var a = new Answer(null, null, "Câu trả lời " + i, i == 1 ? true : false);
                answers.Add(a);
            }
            var q = new Question(null, this.CurrentExam.ID, "Câu hỏi");
            q.Answers = answers;
            this.CurrentExam.Questions.Add(q);

            this.addQuestionToDGV(CurrentExam.Questions.Count - 1, q);
            this.dgvQuestions.CurrentCell = this.dgvQuestions[0, this.dgvQuestions.Rows.Count - 1];
            this.loadCurrentQA();
        }

        public void SaveCurrentQuestion() {
            var currentQ = this.currentQuestion;
            int index = this.CurrentExam.Questions.IndexOf(currentQ);

            // Question and Answer contents
            currentQ.Content = rtbQuestion.Text;
            for (int i = 0; i < rtbAnswers.Count; i++) {
                var content = rtbAnswers[i].Text;
                if (content != "" && content != answerDefaults[rtbAnswers[i]]) {
                    // Old answer
                    if (i < currentQ.Answers.Count) {
                        currentQ.Answers[i].Content = content;
                        currentQ.Answers[i].IsTrue = false;
                    }
                    // New answer
                    else {
                        var newa = new Answer(null, currentQ.ID, content, false);
                        currentQ.Answers.Add(newa);
                    }

                }
            }

            // Is true answer
            for (int i = 0; i < btnIsTrues.Count; i++) {
                if (btnIsTrues[i].Checked) {
                    if (i >= currentQ.Answers.Count) {
                        MessageBox.Show("Đáp án đúng của bạn không có nội dung! Vui lòng điền nội dung hoặc chọn đáp án đúng khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    currentQ.Answers[i].IsTrue = true;
                    break;
                }
            }

            // Dgv update
            setQuestionToDGV(index, currentQ);
        }

        private bool CheckEdit() {
            bool edited = false;
            var currentQ = this.currentQuestion;
            if (currentQ == null) return true;

            if (rtbQuestion.Modified) {
                edited = true;
            }
            // Check anwser && isTrue
            for (int i = 0; i < currentQ.Answers.Count; i++) {
                if (rtbAnswers[i].Modified) {
                    edited = true;
                    break;
                }
                if (currentQ.Answers[i].IsTrue != btnIsTrues[i].Checked) {
                    edited = true;
                    break;
                }
            }
            if (edited) {
                var result = MessageBox.Show("Câu hỏi đã được thay đổi, bạn muốn lưu chứ?", "Thay đổi câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                // Save changes
                if (result == DialogResult.Yes) {
                    SaveCurrentQuestion();
                    return true;
                }

                if (result == DialogResult.Cancel) return false;
            }

            return true;
        }

        public void MakeUneditable() {
            List<Control> toDisable = new List<Control>();
            toDisable.Add(this.cbClass);
            toDisable.Add(this.cbEDDay);
            toDisable.Add(this.cbEDMonth);
            toDisable.Add(this.cbEDYear);
            toDisable.Add(this.cbLimitTimes);
            toDisable.Add(this.cbOrder);
            toDisable.Add(this.cbQuestionAmount);
            toDisable.Add(this.cbSTDay);
            toDisable.Add(this.cbSTMonth);
            toDisable.Add(this.cbSTYear);
            toDisable.Add(this.cbTAHour);
            toDisable.Add(this.cbTAMinute);
            toDisable.Add(this.cbTASecond);
            toDisable.Add(this.buttonLimit);
            toDisable.Add(this.button7);
            toDisable.Add(this.btnExamImport);
            toDisable.Add(this.btnIsTrue1);
            toDisable.Add(this.btnIsTrue2);
            toDisable.Add(this.btnIsTrue3);
            toDisable.Add(this.btnIsTrue4);
            toDisable.Add(this.btnIsTrue5);
            toDisable.Add(this.btnQRemove);
            toDisable.Add(this.btnQSave);
            toDisable.Add(this.btnQuestionAdd);
            toDisable.Add(this.btnRollback);
            toDisable.Add(this.btnSave);

            foreach (var c in toDisable) c.Enabled = false;

            this.rtbQuestion.ReadOnly = true;
            foreach (var rtb in rtbAnswers) rtb.ReadOnly = true;
        }

        /*
         * Util methods
         */

        private Exam clone(Exam exam) {
            var e = new Exam(exam.ID, exam.TeacherID, exam.ClassID, exam.CreationDate, exam.Time, exam.ExamOrder, exam.StartDate, exam.EndDate, exam.Limit, exam.NumberQuestion);
            e.Questions.AddRange(exam.Questions);
            return e;
        }

        private Class fromID(string id) {
            foreach (var cls in availableClasses) {
                if (cls.ID.Equals(id)) return cls;
            }
            return null;
        }

        private void addQuestionToDGV(int index, Question q) {
            this.dgvQuestions.Rows.Add(index + 1, q.Content, q.Answers.Count);
        }

        private void setQuestionToDGV(int index, Question q) {
            this.dgvQuestions.Rows[index].SetValues(new object[] { index + 1, q.Content, q.Answers.Count });
        }

        private void loadCurrentQA() {
            int index = this.dgvQuestions.CurrentRow.Index;
            if (index >= this.CurrentExam.Questions.Count) return;
            // Question
            var q = this.CurrentExam.Questions[index];
            this.currentQuestion = q;
            this.rtbQuestion.Text = q.Content;

            // Answer
            for (int i = 0; i < this.rtbAnswers.Count; i++) {
                this.rtbAnswers[i].Text = "";
                if (q.Answers.Count > i) {
                    rtbAnswers[i].Text = q.Answers[i].Content;
                    if (q.Answers[i].IsTrue) {
                        this.btnIsTrues[i].Checked = true;
                        this.btnIsTrues[i].TabStop = false;
                    }
                }
            }

            // Set indexs
            for (int i = 0; i < this.dgvQuestions.Rows.Count; i++) {
                dgvQuestions[0, i].Value = i + 1;
            }
        }

        public bool checkValid() {
            // Check class
            if (cbClass.SelectedItem == null) {
                MessageBox.Show("Vui lòng chọn Lớp học", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check exam order
            if (cbOrder.SelectedItem == null) {
                MessageBox.Show("Vui lòng chọn Loại kỳ thi", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check time
            if (cbTAHour.SelectedItem != null && cbTAMinute.SelectedItem != null && cbTASecond.SelectedItem != null) {
                if (cbTAHour.SelectedItem.Equals(0) && cbTAMinute.SelectedItem.Equals(0) && cbTASecond.SelectedItem.Equals(0)) {
                    MessageBox.Show("Vui lòng thiết lập Thời gian làm bài", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else {
                MessageBox.Show("Vui lòng thiết lập Thời gian làm bài", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check limit
            if (buttonLimit.Checked && cbQuestionAmount.SelectedItem == null) {
                MessageBox.Show("Vui lòng thiết lập Giới hạn làm bài", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check amount
            int qAmount = 0;
            if (cbQuestionAmount.SelectedItem == null) {
                MessageBox.Show("Vui lòng thiết lập Số lượng câu hỏi (lớn hơn 0)", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else qAmount = (int)cbQuestionAmount.SelectedItem;

            // Check date
            DateTime startDate;
            try {
                startDate = new DateTime((int)cbSTYear.SelectedItem, (int)cbSTMonth.SelectedItem, (int)cbSTDay.SelectedItem);
            }
            catch (ArgumentOutOfRangeException) {
                MessageBox.Show("Vui lòng chọn đúng Ngày bắt đầu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            DateTime endDate;
            try {
                endDate = new DateTime((int)cbEDYear.SelectedItem, (int)cbEDMonth.SelectedItem, (int)cbEDDay.SelectedItem);
            }
            catch (ArgumentOutOfRangeException) {
                MessageBox.Show("Vui lòng chọn đúng Ngày kết thúc", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (DateTime.Compare(startDate, endDate) >= 0) {
                MessageBox.Show("Ngày kết thúc phải sau Ngày bắt đầu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check question amount
            if (qAmount > dgvQuestions.Rows.Count) {
                MessageBox.Show("Số lượng câu hỏi phải ít hơn hoặc bằng số lượng câu hỏi trong ngân hàng câu hỏi", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public void setValues() {
            // Set class
            this.CurrentExam.ClassID = availableClasses[cbClass.SelectedIndex].ID;

            // Set access time
            int at = ((int)this.cbTAHour.SelectedItem) * 3600 + ((int)this.cbTAMinute.SelectedItem) * 60 + (int)this.cbTASecond.SelectedItem;
            this.CurrentExam.Time = at;

            // Limit
            if (this.buttonLimit.Checked) {
                this.CurrentExam.Limit = (int)cbLimitTimes.SelectedItem;
            }
            else this.CurrentExam.Limit = 0;

            // Question amount
            this.CurrentExam.NumberQuestion = (int)cbQuestionAmount.SelectedItem;

            // Order
            this.CurrentExam.ExamOrder = cbOrder.SelectedItem.ToString();

            // Start day
            this.CurrentExam.StartDate = new DateTime((int)cbSTYear.SelectedItem, (int)cbSTMonth.SelectedItem, (int)cbSTDay.SelectedItem);

            // End day
            this.CurrentExam.EndDate = new DateTime((int)cbEDYear.SelectedItem, (int)cbEDMonth.SelectedItem, (int)cbEDDay.SelectedItem); 
        }

        private void loadTemplateExcel() {
            using (FolderBrowserDialog ofd = new FolderBrowserDialog()) {
                if (ofd.ShowDialog() == DialogResult.OK) {
                    string sourcepath = Application.StartupPath + "\\Extends\\Mau-cau-hoi.xlsx";

                    File.Copy(sourcepath, Path.Combine(ofd.SelectedPath, "Mau-cau-hoi.xlsx"), true);

                    MessageBox.Show("Tải thành công! Hãy kiểm tra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void readExcel(string fileSource) {
            try {
                string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileSource + ";Extended Properties='Excel 8.0;HDR=Yes;ImportMixedTypes=Text'";
                int count = 0;

                int countProblem = 0;

                using (OleDbConnection connection = new OleDbConnection(con)) {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("select * from [Sheet1$]", connection);
                    using (OleDbDataReader dr = command.ExecuteReader()) {
                        while (dr.Read()) {
                            var qS = dr.IsDBNull(0) ? "Câu hỏi trống" : dr[0].ToString();
                            var q = new Question(null, this.CurrentExam.ID, qS);

                            int trueA = dr.IsDBNull(6) ? 1 : Convert.ToInt32(dr[6]);

                            int countA = 0;
                            for (int j = 1; j < 6; j++) {
                                if (dr.IsDBNull(j)) continue;
                                countA++;

                                var aS = dr[j].ToString();
                                var a = new Answer(null, null, aS, false);
                                if (j == trueA) a.IsTrue = true;

                                q.Answers.Add(a);
                            }
                            if (countA < 2) {
                                countProblem++;
                                continue;
                            }

                            this.CurrentExam.Questions.Add(q);
                            count++;
                        }
                    }
                }
                if (countProblem > 0) {
                    MessageBox.Show("Có " + countProblem + " câu hỏi có vấn đề, không thể thêm. Bạn nên kiểm tra lại!", "Báo cáo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                MessageBox.Show("Thêm thành công " + count + " câu hỏi!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GenerateExamValue();
            }
            catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm. Có vẻ như file excel của bạn không đúng. Hãy sửa lại file theo mẫu (Tải đề mẫu)", "Xảy ra lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void generateQuestionExcel() {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null) {
                MessageBox.Show("Phần mềm Excel của bạn cài đặt không đúng cách!");
                return;
            }

            using (FolderBrowserDialog ofd = new FolderBrowserDialog()) {
                if (ofd.ShowDialog() != DialogResult.OK) return;

                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlWorkSheet.Cells[1, 1] = "Câu hỏi";
                xlWorkSheet.Cells[1, 2] = "Đáp án 1";
                xlWorkSheet.Cells[1, 3] = "Đáp án 2";
                xlWorkSheet.Cells[1, 4] = "Đáp án 3";
                xlWorkSheet.Cells[1, 5] = "Đáp án 4";
                xlWorkSheet.Cells[1, 6] = "Đáp án 5";
                xlWorkSheet.Cells[1, 7] = "Đáp án đúng";

                int index = 2;
                foreach (var q in this.CurrentExam.Questions) {
                    xlWorkSheet.Cells[index, 1] = q.Content.ToString();
                    for (int i = 0; i < q.Answers.Count; i++) {
                        var a = q.Answers[i];
                        xlWorkSheet.Cells[index, 2 + i].NumberFormat = "@";
                        xlWorkSheet.Cells[index, 2 + i] = a.Content.ToString();
                        if (a.IsTrue) {
                            xlWorkSheet.Cells[index, 7] = i + 1 + "";
                        }
                    }
                    index++;
                }

                var fileName = this.CurrentExam.ID + "-" + Utils.GetCurrentUnixTimestampMillis() + ".xls";
                xlWorkBook.SaveAs(Path.Combine(ofd.SelectedPath, fileName), Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);

                MessageBox.Show("Lưu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /*
         * Event Handling
         */

        private void OnCheckedChanged(object sender, EventArgs e) {
            if (this.buttonLimit.Checked) {
                this.cbLimitTimes.Show();
                this.labelLimitTimes.Show();
            }
            else {
                this.cbLimitTimes.Hide();
                this.labelLimitTimes.Hide();
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e) {
            if (saved) return;
            if (e.CloseReason != CloseReason.UserClosing) return;
            var result = MessageBox.Show("Bạn có chắc muốn thoát? Có thể mất dữ liệu nếu đang chỉnh sửa", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) e.Cancel = true;
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e) {
            MainTeacherForm.MainForm.Show();
        }

        private void OnQuestionsSelectionChanged(object sender, EventArgs e) {
            // Load question
            loadCurrentQA();
        }

        private void OnQARTBEnter(object sender, EventArgs e) {
            this.loaded = true;
            if (answerDefaults.Keys.Contains(sender)) {
                var rtb = (RichTextBox) sender;
                if (rtb.Text.Equals(answerDefaults[rtb])) {
                    rtb.Text = "";
                    rtb.ForeColor = Color.Black;
                }
            }
            else if (sender == rtbQuestion && rtbQuestion.Text.Equals(questionDefault)) {
                rtbQuestion.Text = "";
                rtbQuestion.ForeColor = Color.Black;
            }

            var rtb2 = (RichTextBox)sender;
            rtb2.SelectionStart = rtb2.Text.Length;
        }

        private void OnQARTBLeave(object sender, EventArgs e) {
            // Default check
            if (answerDefaults.Keys.Contains(sender)) {
                var rtb = (RichTextBox)sender;
                if (!rtb.Text.Equals("")) return;
                rtb.Text = answerDefaults[rtb];
            }
            else if (sender == rtbQuestion && rtbQuestion.Text.Equals("")) {
                rtbQuestion.Text = questionDefault;
            }
            
        }

        private void OnQuestionAddButtonClick(object sender, EventArgs e) {
            AddNewQuestion();
        }

        private void OnButtonQSave(object sender, EventArgs e) {
            SaveCurrentQuestion();
            rtbQuestion.Modified = false;
            foreach (var rtba in rtbAnswers) rtba.Modified = false;
        }

        private void OnQuestionsRowValidating(object sender, DataGridViewCellCancelEventArgs e) {
            if (this.CurrentExam.Questions == null) return;
            if (loaded) CheckEdit();
        }

        private void OnButtonQRemove(object sender, EventArgs e) {
            var result = MessageBox.Show("Bạn có chắc là muốn xóa câu hỏi này chứ?", "Xóa câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                int index = this.dgvQuestions.CurrentRow.Index;
                // Clear in dgv
                this.dgvQuestions.Rows.RemoveAt(index);

                // Clear in data
                this.CurrentExam.Questions.RemoveAt(index);

                // Update new current
                this.loadCurrentQA();
            }
        }

        private void OnButtonQuit(object sender, EventArgs e) {
            this.Close();
        }

        private void OnButtonRollBackClick(object sender, EventArgs e) {
            var result = MessageBox.Show("Những gì bạn đã chỉnh sửa sẽ mất hết. Bạn có chắc là muốn làm mới kỳ thi về ban đầu chứ?", "Làm mới kỳ thi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                this.loaded = false;
                this.CurrentExam = sourceExam;
                this.GenerateDefautValues();
                this.GenerateExamValue();
                this.loaded = true;
            }
        }

        private void OnBtnSaveClick(object sender, EventArgs e) {
            // Check
            if (!checkValid()) return;

            // Set
            this.setValues();

            // Check edit
            this.CheckEdit();

            // Save
            if (SQLConnections.SaveExam(this.CurrentExam)) {
                this.saved = true;
                MessageBox.Show("Lưu kỳ thi thành công!", "Thành công", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void OnButtonExamImportClick(object sender, EventArgs e) {
            this.Hide();
            new ExamQuestionsSelectForm(MainTeacherForm.MainForm.TeacherID, this).Show();
        }

        private void OnButtonTemplateDownloadClick(object sender, EventArgs e) {
            loadTemplateExcel();
        }

        private void OnButtonUploadClick(object sender, EventArgs e) {
            OpenFileDialog openDialog = new OpenFileDialog();

            openDialog.Title = "Chọn file Excel";
            openDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openDialog.CheckFileExists = true;
            openDialog.CheckPathExists = true;

            var result = openDialog.ShowDialog();
            if (result == DialogResult.OK) {
                var fileSource = openDialog.FileName;
                readExcel(fileSource);
            }
        }

        private void OnButtonDownloadClick(object sender, EventArgs e) {
            generateQuestionExcel();
        }
    }
}
