using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace XPServerModeViewDemo {
    public partial class ProgressForm : DevExpress.XtraEditors.XtraForm, IProgress<int> {
        public ProgressForm() {
            InitializeComponent();
        }

        public void Report(int value) {
            progressBarControl1.EditValue = value;
        }
    }
}