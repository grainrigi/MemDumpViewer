using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Be.Windows.Forms;

namespace MemDumpViewer {
    public partial class MyTabPage {
        Label cap_DW = new System.Windows.Forms.Label();
        Label cap_Addr = new System.Windows.Forms.Label();
        Label cap_UTF16 = new System.Windows.Forms.Label();
        Button b_JumpToAddr = new System.Windows.Forms.Button();
        Button b_cpUTF8 = new System.Windows.Forms.Button();
        Button b_cpUTF16 = new System.Windows.Forms.Button();
        Label cap_UTF8 = new System.Windows.Forms.Label();
        TextBox t_JumpTo = new System.Windows.Forms.TextBox();
        Button b_cpAddr = new System.Windows.Forms.Button();
        Button b_cpDW = new System.Windows.Forms.Button();
        Label cap_JumpTo = new System.Windows.Forms.Label();
        TextBox t_Offset = new System.Windows.Forms.TextBox();
        Button b_Jump = new System.Windows.Forms.Button();
        Label cap_Offset = new System.Windows.Forms.Label();
        Label l_Addr = new System.Windows.Forms.Label();
        Label l_DW = new System.Windows.Forms.Label();
        Label l_UTF8 = new System.Windows.Forms.Label();
        Label l_UTF16 = new System.Windows.Forms.Label();
        Label cap_PDW = new System.Windows.Forms.Label();
        Label l_PDW = new System.Windows.Forms.Label();
        Button b_cpPDW = new System.Windows.Forms.Button();
        Label cap_pinfo = new System.Windows.Forms.Label();
        Label l_prange = new System.Windows.Forms.Label();
        HexBox hbox = new Be.Windows.Forms.HexBox();

        public TabPage Tab { get; private set; } = new TabPage();

        int id;

        

        private void InitializeComponent() {
            id = obtainID();

            Tab.SuspendLayout();

            // 
            // tabPage1
            // 
            this.Tab.Controls.Add(this.l_UTF16);
            this.Tab.Controls.Add(this.l_UTF8);
            this.Tab.Controls.Add(this.l_DW);
            this.Tab.Controls.Add(this.l_Addr);
            this.Tab.Controls.Add(this.cap_Offset);
            this.Tab.Controls.Add(this.b_Jump);
            this.Tab.Controls.Add(this.t_Offset);
            this.Tab.Controls.Add(this.cap_JumpTo);
            this.Tab.Controls.Add(this.b_cpDW);
            this.Tab.Controls.Add(this.b_cpAddr);
            this.Tab.Controls.Add(this.t_JumpTo);
            this.Tab.Controls.Add(this.cap_UTF8);
            this.Tab.Controls.Add(this.b_cpUTF16);
            this.Tab.Controls.Add(this.b_cpUTF8);
            this.Tab.Controls.Add(this.b_JumpToAddr);
            this.Tab.Controls.Add(this.cap_UTF16);
            this.Tab.Controls.Add(this.cap_Addr);
            this.Tab.Controls.Add(this.cap_DW);
            this.Tab.Controls.Add(this.b_cpPDW);
            this.Tab.Controls.Add(this.l_PDW);
            this.Tab.Controls.Add(this.cap_PDW);
            this.Tab.Controls.Add(this.l_prange);
            this.Tab.Controls.Add(this.cap_pinfo);
            this.Tab.Controls.Add(this.hbox);
            this.Tab.Location = new System.Drawing.Point(4, 22);
            this.Tab.Name = GenName("tab");
            this.Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Tab.Size = new System.Drawing.Size(952, 432);
            this.Tab.TabIndex = 0;
            this.Tab.Text = "0x00000000";
            this.Tab.UseVisualStyleBackColor = true;
            // 
            // hbox
            // 
            this.hbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hbox.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.hbox.LineInfoOffset = ((long)(49445216));
            this.hbox.LineInfoVisible = true;
            this.hbox.Location = new System.Drawing.Point(0, 0);
            this.hbox.Name = GenName("hbox");
            this.hbox.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hbox.Size = new System.Drawing.Size(720, 432);
            this.hbox.StringViewVisible = true;
            this.hbox.TabIndex = 0;
            this.hbox.UseFixedBytesPerLine = true;
            this.hbox.VScrollBarVisible = true;
            this.hbox.SelectionStartChanged += new System.EventHandler(this.hbox_SelectionStartChanged);
            // 
            // l_UTF16
            // 
            this.l_UTF16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_UTF16.AutoSize = true;
            this.l_UTF16.Location = new System.Drawing.Point(793, 126);
            this.l_UTF16.Name = "l_UTF16";
            this.l_UTF16.Size = new System.Drawing.Size(13, 12);
            this.l_UTF16.TabIndex = 18;
            this.l_UTF16.Text = "A";
            // 
            // l_UTF8
            // 
            this.l_UTF8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_UTF8.AutoSize = true;
            this.l_UTF8.Location = new System.Drawing.Point(789, 104);
            this.l_UTF8.Name = "l_UTF8";
            this.l_UTF8.Size = new System.Drawing.Size(13, 12);
            this.l_UTF8.TabIndex = 17;
            this.l_UTF8.Text = "A";
            // 
            // l_DW
            // 
            this.l_DW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_DW.AutoSize = true;
            this.l_DW.Location = new System.Drawing.Point(793, 59);
            this.l_DW.Name = "l_DW";
            this.l_DW.Size = new System.Drawing.Size(65, 12);
            this.l_DW.TabIndex = 16;
            this.l_DW.Text = "0x00000000";
            // 
            // l_Addr
            // 
            this.l_Addr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_Addr.AutoSize = true;
            this.l_Addr.Location = new System.Drawing.Point(773, 29);
            this.l_Addr.Name = "l_Addr";
            this.l_Addr.Size = new System.Drawing.Size(65, 12);
            this.l_Addr.TabIndex = 15;
            this.l_Addr.Text = "0x00000000";
            // 
            // cap_Offset
            // 
            this.cap_Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cap_Offset.AutoSize = true;
            this.cap_Offset.Location = new System.Drawing.Point(755, 294);
            this.cap_Offset.Name = "cap_Offset";
            this.cap_Offset.Size = new System.Drawing.Size(39, 12);
            this.cap_Offset.TabIndex = 14;
            this.cap_Offset.Text = "Offset:";
            // 
            // b_Jump
            // 
            this.b_Jump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Jump.Location = new System.Drawing.Point(864, 289);
            this.b_Jump.Name = "b_Jump";
            this.b_Jump.Size = new System.Drawing.Size(55, 23);
            this.b_Jump.TabIndex = 13;
            this.b_Jump.Text = "Jump";
            this.b_Jump.UseVisualStyleBackColor = true;
            this.b_Jump.Click += new System.EventHandler(b_Jump_Click);
            // 
            // t_Offset
            // 
            this.t_Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.t_Offset.Location = new System.Drawing.Point(800, 291);
            this.t_Offset.Name = "t_Offset";
            this.t_Offset.Size = new System.Drawing.Size(57, 19);
            this.t_Offset.TabIndex = 12;
            // 
            // cap_JumpTo
            // 
            this.cap_JumpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cap_JumpTo.AutoSize = true;
            this.cap_JumpTo.Location = new System.Drawing.Point(745, 268);
            this.cap_JumpTo.Name = "cap_JumpTo";
            this.cap_JumpTo.Size = new System.Drawing.Size(49, 12);
            this.cap_JumpTo.TabIndex = 11;
            this.cap_JumpTo.Text = "Jump to:";
            // 
            // b_cpDW
            // 
            this.b_cpDW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_cpDW.Location = new System.Drawing.Point(873, 54);
            this.b_cpDW.Name = "b_cpDW";
            this.b_cpDW.Size = new System.Drawing.Size(55, 23);
            this.b_cpDW.TabIndex = 10;
            this.b_cpDW.Text = "Copy";
            this.b_cpDW.UseVisualStyleBackColor = true;
            this.b_cpDW.Click += copyButtonHandler(l_DW);
            // 
            // b_cpAddr
            // 
            this.b_cpAddr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_cpAddr.Location = new System.Drawing.Point(850, 24);
            this.b_cpAddr.Name = "b_cpAddr";
            this.b_cpAddr.Size = new System.Drawing.Size(55, 23);
            this.b_cpAddr.TabIndex = 9;
            this.b_cpAddr.Text = "Copy";
            this.b_cpAddr.UseVisualStyleBackColor = true;
            this.b_cpAddr.Click += this.copyButtonHandler(this.l_Addr);
            // 
            // t_JumpTo
            // 
            this.t_JumpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.t_JumpTo.Location = new System.Drawing.Point(800, 265);
            this.t_JumpTo.Name = "t_JumpTo";
            this.t_JumpTo.Size = new System.Drawing.Size(119, 19);
            this.t_JumpTo.TabIndex = 8;
            // 
            // cap_UTF8
            // 
            this.cap_UTF8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cap_UTF8.AutoSize = true;
            this.cap_UTF8.Location = new System.Drawing.Point(745, 104);
            this.cap_UTF8.Name = "cap_UTF8";
            this.cap_UTF8.Size = new System.Drawing.Size(41, 12);
            this.cap_UTF8.TabIndex = 7;
            this.cap_UTF8.Text = "UTF-8:";
            // 
            // b_cpUTF16
            // 
            this.b_cpUTF16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_cpUTF16.Location = new System.Drawing.Point(747, 218);
            this.b_cpUTF16.Name = "b_cpUTF16";
            this.b_cpUTF16.Size = new System.Drawing.Size(172, 23);
            this.b_cpUTF16.TabIndex = 6;
            this.b_cpUTF16.Text = "Copy as UTF-16 String";
            this.b_cpUTF16.UseVisualStyleBackColor = true;
            // 
            // b_cpUTF8
            // 
            this.b_cpUTF8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_cpUTF8.Location = new System.Drawing.Point(747, 189);
            this.b_cpUTF8.Name = "b_cpUTF8";
            this.b_cpUTF8.Size = new System.Drawing.Size(172, 23);
            this.b_cpUTF8.TabIndex = 5;
            this.b_cpUTF8.Text = "Copy as UTF-8 String";
            this.b_cpUTF8.UseVisualStyleBackColor = true;
            // 
            // b_JumpToAddr
            // 
            this.b_JumpToAddr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_JumpToAddr.Location = new System.Drawing.Point(747, 160);
            this.b_JumpToAddr.Name = "b_JumpToAddr";
            this.b_JumpToAddr.Size = new System.Drawing.Size(172, 23);
            this.b_JumpToAddr.TabIndex = 4;
            this.b_JumpToAddr.Text = "Jump to the Address";
            this.b_JumpToAddr.UseVisualStyleBackColor = true;
            this.b_JumpToAddr.Click += new System.EventHandler(b_JumpToAddr_Click);
            // 
            // cap_UTF16
            // 
            this.cap_UTF16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cap_UTF16.AutoSize = true;
            this.cap_UTF16.Location = new System.Drawing.Point(745, 126);
            this.cap_UTF16.Name = "cap_UTF16";
            this.cap_UTF16.Size = new System.Drawing.Size(47, 12);
            this.cap_UTF16.TabIndex = 3;
            this.cap_UTF16.Text = "UTF-16:";
            // 
            // cap_Addr
            // 
            this.cap_Addr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cap_Addr.AutoSize = true;
            this.cap_Addr.Location = new System.Drawing.Point(726, 29);
            this.cap_Addr.Name = "cap_Addr";
            this.cap_Addr.Size = new System.Drawing.Size(49, 12);
            this.cap_Addr.TabIndex = 2;
            this.cap_Addr.Text = "Address:";
            // 
            // cap_DW
            // 
            this.cap_DW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cap_DW.AutoSize = true;
            this.cap_DW.Location = new System.Drawing.Point(745, 59);
            this.cap_DW.Name = "cap_DW";
            this.cap_DW.Size = new System.Drawing.Size(48, 12);
            this.cap_DW.TabIndex = 1;
            this.cap_DW.Text = "DWORD:";
            // 
            // cap_PDW
            // 
            this.cap_PDW.AutoSize = true;
            this.cap_PDW.Location = new System.Drawing.Point(747, 83);
            this.cap_PDW.Name = "cap_PDW";
            this.cap_PDW.Size = new System.Drawing.Size(54, 12);
            this.cap_PDW.TabIndex = 19;
            this.cap_PDW.Text = "*DWORD:";
            // 
            // l_PDW
            // 
            this.l_PDW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_PDW.AutoSize = true;
            this.l_PDW.Location = new System.Drawing.Point(803, 83);
            this.l_PDW.Name = "l_PDW";
            this.l_PDW.Size = new System.Drawing.Size(65, 12);
            this.l_PDW.TabIndex = 20;
            this.l_PDW.Text = "0x00000000";
            // 
            // b_cpPDW
            // 
            this.b_cpPDW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_cpPDW.Location = new System.Drawing.Point(883, 78);
            this.b_cpPDW.Name = "b_cpPDW";
            this.b_cpPDW.Size = new System.Drawing.Size(55, 23);
            this.b_cpPDW.TabIndex = 21;
            this.b_cpPDW.Text = "Copy";
            this.b_cpPDW.UseVisualStyleBackColor = true;
            this.b_cpPDW.Click += copyButtonHandler(this.l_PDW);
            // 
            // cap_pinfo
            // 
            this.cap_pinfo.AutoSize = true;
            this.cap_pinfo.Location = new System.Drawing.Point(728, 332);
            this.cap_pinfo.Name = "cap_pinfo";
            this.cap_pinfo.Size = new System.Drawing.Size(51, 12);
            this.cap_pinfo.TabIndex = 22;
            this.cap_pinfo.Text = "PageInfo:";
            // 
            // l_prange
            // 
            this.l_prange.AutoSize = true;
            this.l_prange.Location = new System.Drawing.Point(755, 354);
            this.l_prange.Name = "l_prange";
            this.l_prange.Size = new System.Drawing.Size(115, 12);
            this.l_prange.TabIndex = 23;
            this.l_prange.Text = "00000000-FFFFFFFF";

            Tab.ResumeLayout();
        }

        private string GenName(string cname) {
            return $"{cname}_{id}";
        }


        public static int ID = 0;
        private static int obtainID() { return ID++; }
    }
}
