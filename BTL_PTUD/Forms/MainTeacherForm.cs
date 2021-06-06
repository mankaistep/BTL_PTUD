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

        public string TeacherID;
        public Teacher Teacher;

        public MainTeacherForm(string id, string sqlconnstring) {
            InitializeComponent();
            SQLConnections.Init(sqlconnstring);

            this.TeacherID = id;
            this.Teacher = SQLConnections.QueryTeacher(id);

            // Change title
            this.Text = Teacher.ID + " - GV " + Teacher.Name;

            // Change ExamUserControl
            this.examUC.labelCurrentExams.Text = SQLConnections.QueryCurrentExamAmount() + "";

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

        private void OnClassButtonClick(object sender, EventArgs e) {
            this.classUC.BringToFront();
        }

        private void OnExaminationButtonClick(object sender, EventArgs e) {
            this.examUC.BringToFront();
        }

        private void OnFormClose(object sender, FormClosedEventArgs e) {
            SQLConnections.Connection.Close();
        }
    }
}
