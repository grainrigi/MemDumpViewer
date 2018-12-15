using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemDumpViewer {
    public partial class OpenDialog : Form {
        private Form1 frm;

        public OpenDialog() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            using(var fbd = new FolderBrowserDialog()) {
                DialogResult res = fbd.ShowDialog();
                if(res == DialogResult.OK) {
                    this.textBox1.Text = fbd.SelectedPath;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            frm = new Form1(this.textBox1.Text, this.textBox2.Text);
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void OpenDialog_Load(object sender, EventArgs e) {

        }
    }
}
