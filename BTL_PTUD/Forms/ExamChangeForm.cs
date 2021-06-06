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
    public partial class ExamChangeForm : Form {

        private int examID;

        public ExamChangeForm() {
            InitializeComponent();
        }

        public ExamChangeForm(int examID) : base() {
            this.examID = examID;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
