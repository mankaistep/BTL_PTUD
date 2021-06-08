using BTL_PTUD.Source.Connection;
using BTL_PTUD.Source.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_PTUD.Forms {
    public partial class ClassForm : Form {

        private Class cls;
        private List<Exam> availableExams;

        private Exam currentExam;
        private List<Result> currentResults;

        public ClassForm() {
            InitializeComponent();
        }

        public ClassForm(Class cls) {
            InitializeComponent();
            this.cls = cls;

            // Query exams
            this.availableExams = SQLConnections.QueryExams(cls, false);

            // Set combobox
            var items = new Object[availableExams.Count()];
            int i = 0;
            foreach (var exam in availableExams) {
                items[i] = exam.ID;
                i++;
            }
            this.cbExams.DataSource = items;
        }

        public void GenerateValues() {
            // Creation Date
            var cD = currentExam.CreationDate;
            var dayS = cD.Day >= 10 ? cD.Day + "" : "0" + cD.Day;
            var monthS = cD.Month >= 10 ? cD.Month + "" : "0" + cD.Month;
            this.labelCreationDate.Text = dayS + "/" + monthS + "/" + cD.Year;

            // Time
            this.labelTime.Text = (currentExam.Time / 3600) + " h " + ((currentExam.Time % 3600) / 60) + " p " + (currentExam.Time % 60) + " s";

            // Order
            this.labelExamOrder.Text = currentExam.ExamOrder;

            // Start Date
            cD = currentExam.StartDate;
            dayS = cD.Day >= 10 ? cD.Day + "" : "0" + cD.Day;
            monthS = cD.Month >= 10 ? cD.Month + "" : "0" + cD.Month;
            this.labelStartDate.Text = dayS + "/" + monthS + "/" + cD.Year;

            // End Date
            cD = currentExam.EndDate;
            dayS = cD.Day >= 10 ? cD.Day + "" : "0" + cD.Day;
            monthS = cD.Month >= 10 ? cD.Month + "" : "0" + cD.Month;
            this.labelEndDate.Text = dayS + "/" + monthS + "/" + cD.Year;

            // Limit Times
            this.labelLimitTimes.Text = currentExam.Limit + " lần";

            // Question amount
            this.labelQuestionAmount.Text = currentExam.NumberQuestion + " câu";

            // Results
            this.dgvResults.Rows.Clear();
            foreach (var result in this.currentResults) {
                string time = result.AccessTime / 60 + " p" + (result.AccessTime % 60) + " s";
                this.dgvResults.Rows.Add(result.StudentID, result.StudentName, result.Score, time, result.Times);
            }
        }

        public void UpdateChoices() {
            if (currentResults == null) return;
            int i = this.dgvResults.CurrentCell.RowIndex;
            if (i < 0 || i >= this.currentResults.Count) return;
            var result = this.currentResults[i];

            List<Choice> choices = SQLConnections.QueryChoices(result.ID, true);
            this.dgvChoices.Rows.Clear();
            foreach (var choice in choices) {
                this.dgvChoices.Rows.Add(choice.Question, choice.IsTrue ? "Đúng" : "Sai", choice.Answer);
            }
        }

        private void OnExamChange(object sender, EventArgs e) {
            foreach (var exam in availableExams) {
                if (exam.ID.Equals(this.cbExams.SelectedItem.ToString())) {
                    this.currentExam = exam;
                    this.currentResults = SQLConnections.QueryResults(this.currentExam.ID, true);
                    GenerateValues();
                    break;
                }
            }
        }

        private void OnSelectionChanged(object sender, EventArgs e) {
            UpdateChoices();
        }

        private void OnFormClose(object sender, FormClosedEventArgs e) {
            MainTeacherForm.MainForm.Show();
        }

        private void OnButtonBackClick(object sender, EventArgs e) {
            this.Close();
        }
    }
}
