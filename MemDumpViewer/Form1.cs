using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
using Be.Windows.Forms;

namespace MemDumpViewer {
    public partial class Form1 : Form {
        public Form1(string dir, string pattern) {
            DumpManager.Init(dir, pattern);
            InitializeComponent();
        }

        List<MyTabPage> mtabs = new List<MyTabPage>();

        private void Form1_Load(object sender, EventArgs e) {
            TabManager.Init(tabControl1);
        }
    }
}
