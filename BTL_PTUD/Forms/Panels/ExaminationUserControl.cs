using System;
using System.Windows.Forms;

namespace BTL_PTUD.Forms.Panels {
    public partial class ExaminationUserControl : UserControl {
        public ExaminationUserControl() {
            InitializeComponent();
        }

        private void OnNewExamButtonClick(object sender, EventArgs e) {
            new ExamChangeForm().ShowDialog();
        }
    }
}
