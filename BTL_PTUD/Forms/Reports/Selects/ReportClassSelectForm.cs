
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
    public partial class ReportClassSelect : Form {

        private string teacherID;
        private DateTime start;
        private DateTime end;

        private List<Class> avaialableClasses;

        public ReportClassSelect(DateTime start, DateTime end) {
            InitializeComponent();
            this.teacherID = MainTeacherForm.MainForm.TeacherID;
            this.start = start;
            this.end = end;

            // Load avaiable subjects
            this.avaialableClasses = SQLConnections.QueryClasses(teacherID);

            // Load combobox
            foreach (var cls in this.avaialableClasses) {
                this.cbSubjects.Items.Add(cls.ID + " - " + cls.Name);
            }
        }

        private void OnButtonCreateClick(object sender, EventArgs e) {
            int index = this.cbSubjects.SelectedIndex;
            if (index < 0 || index >= avaialableClasses.Count) return;
            var cls = avaialableClasses[index];

            var report = new ClassReport();
            SQLConnections.FillResultReportsByClass(this.teacherID, cls.ID, this.start, this.end, report);

            this.Close();
            new ClassReportForm(report).ShowDialog();
        }
    }
}
