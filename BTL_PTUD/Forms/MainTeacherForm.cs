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
        public MainTeacherForm() {
            InitializeComponent();
        }

        private void onExamButtonClick(object sender, EventArgs e) {
            this.xmUC.BringToFront();
        }

        private void onClassButtonClick(object sender, EventArgs e) {
            this.classUC.BringToFront();
        }

        private void onExaminationButtonClick(object sender, EventArgs e) {
            this.xmtUC.BringToFront();
        }
    }
}
