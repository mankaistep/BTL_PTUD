using BTL_PTUD.Reports;
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
    public partial class ReportUserControl : UserControl {
        public ReportUserControl() {
            InitializeComponent();

            // Generate 
            GenerateDefautValues();
        }

        public void GenerateDefautValues() {
            // Generate combobox
            this.cbSTDay.Items.Clear();
            this.cbEDDay.Items.Clear();
            for (int i = 1; i <= 31; i++) {
                this.cbSTDay.Items.Add(i);
                this.cbEDDay.Items.Add(i);
            }
            this.cbSTMonth.Items.Clear();
            this.cbSTMonth.Items.Clear();
            for (int i = 1; i <= 12; i++) {
                this.cbSTMonth.Items.Add(i);
                this.cbEDMonth.Items.Add(i);
            }
            int currentYear = 1970;
            this.cbSTYear.Items.Clear();
            this.cbEDYear.Items.Clear();
            for (int i = currentYear; i <= currentYear + 100; i++) {
                this.cbSTYear.Items.Add(i);
                this.cbEDYear.Items.Add(i);
            }

            this.cbSTDay.SelectedItem = 1;
            this.cbSTMonth.SelectedItem = 1;
            this.cbSTYear.SelectedItem = 1970;

            this.cbEDDay.SelectedItem = 1;
            this.cbEDMonth.SelectedItem = 1;
            this.cbEDYear.SelectedItem = 2070;
        }

        public bool CheckValid() {
            // Check date
            DateTime startDate;
            try {
                startDate = new DateTime((int)cbSTYear.SelectedItem, (int)cbSTMonth.SelectedItem, (int)cbSTDay.SelectedItem);
            }
            catch (ArgumentOutOfRangeException) {
                MessageBox.Show("Vui lòng chọn đúng Ngày bắt đầu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            DateTime endDate;
            try {
                endDate = new DateTime((int)cbEDYear.SelectedItem, (int)cbEDMonth.SelectedItem, (int)cbEDDay.SelectedItem);
            }
            catch (ArgumentOutOfRangeException) {
                MessageBox.Show("Vui lòng chọn đúng Ngày kết thúc", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (DateTime.Compare(startDate, endDate) >= 0) {
                MessageBox.Show("Ngày kết thúc phải sau Ngày bắt đầu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void OnButtonSubjectClick(object sender, EventArgs e) {
            // Check valid
            if (!CheckValid()) return;

            // Open select form
            var start = new DateTime((int)cbSTYear.SelectedItem, (int)cbSTMonth.SelectedItem, (int)cbSTDay.SelectedItem);
            var end = new DateTime((int)cbEDYear.SelectedItem, (int)cbEDMonth.SelectedItem, (int)cbEDDay.SelectedItem);
            new ReportSubjectSelect(start, end).ShowDialog();
        }

        private void OnButtonClassClick(object sender, EventArgs e) {
            // Check valid
            if (!CheckValid()) return;

            // Open select form
            var start = new DateTime((int)cbSTYear.SelectedItem, (int)cbSTMonth.SelectedItem, (int)cbSTDay.SelectedItem);
            var end = new DateTime((int)cbEDYear.SelectedItem, (int)cbEDMonth.SelectedItem, (int)cbEDDay.SelectedItem);
            new ReportClassSelect(start, end).ShowDialog();
        }
    }
}
