using BTL_PTUD.Forms.Panels;
using BTL_PTUD.Reports;
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
    public partial class ReportSubjectSelect : Form {

        private string teacherID;
        private DateTime start;
        private DateTime end;

        private List<Subject> avaialableSubjects;  

        public ReportSubjectSelect(DateTime start, DateTime end) {
            InitializeComponent();
            this.teacherID = MainTeacherForm.MainForm.TeacherID;
            this.start = start;
            this.end = end;

            // Load avaiable subjects
            this.avaialableSubjects = SQLConnections.QuerySubjects(teacherID);

            // Load combobox
            foreach (var sj in this.avaialableSubjects) {
                this.cbSubjects.Items.Add(sj.ID.ToUpper() + " - " + sj.Name);
            }
        }

        private void OnButtonCreateClick(object sender, EventArgs e) {
            int index = this.cbSubjects.SelectedIndex;
            if (index < 0 || index >= avaialableSubjects.Count) return;
            var sj = avaialableSubjects[index];

            var report = new SubjectReport();
            SQLConnections.FillResultReportsBySubject(this.teacherID, sj.ID, this.start, this.end, report);

            this.Close();
            new SubjectReportForm(report).ShowDialog();
        }
    }
}
