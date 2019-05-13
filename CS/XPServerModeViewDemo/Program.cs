using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using XpoTutorial;
using DevExpress.Xpo;
using DevExpress.XtraEditors;

namespace XPServerModeViewDemo {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            try {
                ConnectionHelper.Connect();
                GenerateTestData();
            } catch(Exception ex) {
                XtraMessageBox.Show(ex.Message);
                return;
            }
            Application.Run(new Form1());
        }

        static void GenerateTestData() {
            using(UnitOfWork uow = new UnitOfWork()) {
                if(DemoDataHelper.IsSeedRequired(uow)) {
                    using(ProgressForm progressForm = new ProgressForm()) {
                        progressForm.Shown += async (s, args) => {
                            await DemoDataHelper.SeedAsync(uow, progressForm);
                            progressForm.Close();
                        };
                        progressForm.ShowDialog();
                    }
                }
            }
        }
    }
}
