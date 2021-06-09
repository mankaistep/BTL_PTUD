using BTL_PTUD.Source.Connection;
using BTL_PTUD.Source.Objects;
using BTL_PTUD.Source.Utils;
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
    public partial class ExamQuestionsSelect : Form {

        private string teacherID;
        private ExamChangeForm examForm;

        private List<Exam> exams;

        public ExamQuestionsSelect() {
            InitializeComponent();
        }

        public ExamQuestionsSelect(string teacherID, ExamChangeForm examForm) {
            InitializeComponent();
            this.teacherID = teacherID;
            this.examForm = examForm;

            // Query exams
            exams = SQLConnections.QueryExams(teacherID, true, false);

            // Add to dgv
            dgvExams.Rows.Clear();
            foreach (var exam in exams) {
                dgvExams.Rows.Add(exam.ID, exam.ClassID, exam.ExamOrder, exam.Questions.Count);
            }
        }
        private void checkSelect() {
            if (this.exams == null || this.exams.Count == 0) return;
            int index = this.dgvExams.CurrentRow.Index;

            // Confirm
            var result = MessageBox.Show("Bạn có chắc là muốn lấy câu hỏi từ kỳ thi này?", "Lấy câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            // Clone questions
            var exam = this.exams[index];
            List<Question> questions = new List<Question>();
            foreach (var q in exam.Questions) {
                questions.Add((Question)q.Clone());
            }

            // Add to form
            examForm.CurrentExam.Questions.AddRange(questions);
            examForm.GenerateExamValue();
            MessageBox.Show("Thêm câu hỏi thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void OnButtonSelectClick(object sender, EventArgs e) {
            checkSelect();
        }

        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            checkSelect();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e) {
            examForm.Show();
        }

        private void OnBackButtonClick(object sender, EventArgs e) {
            this.Close();
        }
    }
}
