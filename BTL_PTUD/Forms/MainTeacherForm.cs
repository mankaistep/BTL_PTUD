using BTL_PTUD.Forms.Panels;
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
    public partial class MainTeacherForm : Form {

        public static MainTeacherForm MainForm;

        public string TeacherID;
        public Teacher Teacher;

        public List<ButtonBase> buttons;

        public MainTeacherForm(string id, string sqlconnstring) {
            InitializeComponent();
            SQLConnections.Init(sqlconnstring);
            MainForm = this;

            // Group buttons
            this.buttons = new List<ButtonBase>();
            this.buttons.Add(btnExam);
            this.buttons.Add(btnClass);
            this.buttons.Add(btnReport);
            this.setBold(btnExam);

            this.TeacherID = id;
            this.Teacher = SQLConnections.QueryTeacher(id);

            // Change title
            this.Text = Teacher.ID + " - GV " + Teacher.Name;

            // Change ExamUserControl
            this.examUC.labelCurrentExams.Text = SQLConnections.QueryCurrentExamAmount(id) + "";

            // Load Classes
            this.LoadClasses();

        }

        private void LoadClasses() {
            this.classUC.flpClassList.Controls.Clear();
            List<Class> list = SQLConnections.QueryClasses(this.TeacherID);
            foreach (Class cls in list) {
                var template = Utils.Clone<ClassButtonTemplate>(new ClassButtonTemplate());
                template.labelID.Text = cls.ID;
                template.labelName.Text = cls.Name;
                template.ClassObject = cls;
                this.classUC.flpClassList.Controls.Add(template);
            }
        }

        private void resetFontButtons() {
            foreach (var btn in buttons) {
                btn.Font = new Font(btn.Font, FontStyle.Regular);
            }
        }

        private void setBold(ButtonBase btn) {
            btn.Font = new Font(btn.Font, FontStyle.Bold);
        }

        private void OnClassButtonClick(object sender, EventArgs e) {
            this.classUC.BringToFront();
            this.resetFontButtons();
            this.setBold((ButtonBase) sender);
        }

        private void OnExaminationButtonClick(object sender, EventArgs e) {
            this.examUC.BringToFront();
            this.resetFontButtons();
            this.setBold((ButtonBase)sender);
        }

        private void OnReportButtonClick(object sender, EventArgs e) {
            this.reportUC.BringToFront();
            this.resetFontButtons();
            this.setBold((ButtonBase)sender);
        }

        private void OnFormClose(object sender, FormClosedEventArgs e) {
            SQLConnections.Connection.Close();
        }

    }
}
