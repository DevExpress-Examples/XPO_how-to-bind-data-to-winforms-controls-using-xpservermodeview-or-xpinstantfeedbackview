using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XpoTutorial;

namespace XPServerModeViewDemo {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        readonly Session session;

        public Form1() {
            InitializeComponent();
            session = new Session(XpoDefault.DataLayer);
            xpServerModeView1.ResolveSession += (s, e) => {
                e.Session = session;
            };
            xpInstantFeedbackView1.ResolveSession += (s, e) => {
                e.Session = session;
            };
        }
    }
}
