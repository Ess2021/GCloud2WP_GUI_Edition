using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GCloud2WP_GUI_Edition.Events;

namespace GCloud2WP_GUI_Edition {
    public partial class Form1 : Form {

        static Path path = new Path();
        public Form1() {

            InitializeComponent();

            if (!File.Exists(path.FOLDER)) {
                FileEvent.CreateDirectory(path.FOLDER);
            }
        }

        private void Launch_Click(object sender, EventArgs e) {

            string urls = textBox.Text;

            if (!urls.StartsWith("http")) {
                DialogResult dlg = MessageBox.Show("たぶん、入力された値は不正だと思うんだよね…", "どうする?", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand); ;
                if (dlg == DialogResult.Cancel) return;
            }

            if (!File.Exists(path.FOLDER)) {
                FileEvent.CreateDirectory(path.FOLDER);
            }

            string[] urlList = ListEvent.ToList(urls);

            DateTime dt = DateTime.Now;
            string date = dt.ToString($"{dt:yyyyMMddHHmmss}");

            string result;

            string resultpath = path.FOLDER + "/" + date + ".txt";
            FileEvent.CreateFile(resultpath);

            if (onlyurl.Checked) {
                for (int i = 0; i <= urlList.Length - 1; i++) {
                    result = GCloud2WP_GUI_Edition.Events.Convert.Url(urlList[i]);
                    FileEvent.Addtxt(resultpath, $"{result}\n\n");
                }
            } else {
                for (int i = 0; i <= urlList.Length - 1; i++) {
                    result = GCloud2WP_GUI_Edition.Events.Convert.Html(urlList[i]);
                    FileEvent.Addtxt(resultpath, $"{result}\n\n");
                }
            }

            Process.Start("notepad.exe", resultpath);

        }

        private void openfolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            Process.Start("explorer.exe", path.FOLDER);
        }
    }
}
