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
    public partial class ExamsForm : Form {

        private string teacherID;
        private List<Exam> availableExams;

        private Exam currentExam;

        public ExamsForm() {
            InitializeComponent();
        }

        public ExamsForm(string teacherID) {
            InitializeComponent();
            this.teacherID = teacherID;

            // Generates Values
            GenerateValues();
        }

        public void GenerateValues() {
            // Query Exams
            this.availableExams = SQLConnections.QueryExams(teacherID, true, true);

            this.dgvExams.Rows.Clear();
            foreach (var exam in this.availableExams) {
                this.dgvExams.Rows.Add(exam.ID, exam.ClassID, exam.ExamOrder);
            }
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e) {
            MainTeacherForm.MainForm.Show();
        }

        private void OnButtonBackClick(object sender, EventArgs e) {
            this.Close();
            MainTeacherForm.MainForm.Show();
        }

        private void OnSelectionChanged(object sender, EventArgs e) {
            this.currentExam = this.availableExams[this.dgvExams.CurrentCell.RowIndex];
        }

        private void OnButtonEditClick(object sender, EventArgs e) {
            if (this.currentExam == null) return;
            this.Close();
            MainTeacherForm.MainForm.Hide();
            new ExamChangeForm(this.currentExam.ID).Show();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e) {
            MainTeacherForm.MainForm.Show();
        }

        private void OnDoubleClick(object sender, EventArgs e) {
            if (this.currentExam == null) return;
            this.Close();
            MainTeacherForm.MainForm.Hide();
            new ExamChangeForm(this.currentExam.ID).Show();
        }
    }
}
