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

namespace BTL_PTUD.Forms.Panels {
    public partial class ClassButtonTemplate : UserControl {

        public Class ClassObject { get; set; }

        public ClassButtonTemplate() {
            InitializeComponent();
        }

        private void OnClick(object sender, EventArgs e) {
            MainTeacherForm.MainForm.Hide();
            new ClassForm(ClassObject).ShowDialog();
        }
    }
}
