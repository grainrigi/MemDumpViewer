namespace MemDumpViewer {
    partial class MyTabPageTemplate {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.l_prange = new System.Windows.Forms.Label();
            this.cap_pinfo = new System.Windows.Forms.Label();
            this.b_cpPDW = new System.Windows.Forms.Button();
            this.l_PDW = new System.Windows.Forms.Label();
            this.cap_PDW = new System.Windows.Forms.Label();
            this.l_UTF16 = new System.Windows.Forms.Label();
            this.l_UTF8 = new System.Windows.Forms.Label();
            this.l_DW = new System.Windows.Forms.Label();
            this.l_Addr = new System.Windows.Forms.Label();
            this.cap_Offset = new System.Windows.Forms.Label();
            this.b_Jump = new System.Windows.Forms.Button();
            this.t_Offset = new System.Windows.Forms.TextBox();
            this.cap_JumpTo = new System.Windows.Forms.Label();
            this.b_cpDW = new System.Windows.Forms.Button();
            this.b_cpAddr = new System.Windows.Forms.Button();
            this.t_JumpTo = new System.Windows.Forms.TextBox();
            this.cap_UTF8 = new System.Windows.Forms.Label();
            this.b_cpUTF16 = new System.Windows.Forms.Button();
            this.b_cpUTF8 = new System.Windows.Forms.Button();
            this.b_JumpToAddr = new System.Windows.Forms.Button();
            this.cap_UTF16 = new System.Windows.Forms.Label();
            this.cap_Addr = new System.Windows.Forms.Label();
            this.cap_DW = new System.Windows.Forms.Label();
            this.hbox = new Be.Windows.Forms.HexBox();
            this.SuspendLayout();
            // 
            // l_prange
            // 
            this.l_prange.AutoSize = true;
            this.l_prange.Location = new System.Drawing.Point(762, 354);
            this.l_prange.Name = "l_prange";
            this.l_prange.Size = new System.Drawing.Size(115, 12);
            this.l_prange.TabIndex = 47;
            this.l_prange.Text = "00000000-FFFFFFFF";
            // 
            // cap_pinfo
            // 
            this.cap_pinfo.AutoSize = true;
            this.cap_pinfo.Location = new System.Drawing.Point(735, 332);
            this.cap_pinfo.Name = "cap_pinfo";
            this.cap_pinfo.Size = new System.Drawing.Size(51, 12);
            this.cap_pinfo.TabIndex = 46;
            this.cap_pinfo.Text = "PageInfo:";
            // 
            // b_cpPDW
            // 
            this.b_cpPDW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_cpPDW.Location = new System.Drawing.Point(890, 78);
            this.b_cpPDW.Name = "b_cpPDW";
            this.b_cpPDW.Size = new System.Drawing.Size(55, 23);
            this.b_cpPDW.TabIndex = 45;
            this.b_cpPDW.Text = "Copy";
            this.b_cpPDW.UseVisualStyleBackColor = true;
            // 
            // l_PDW
            // 
            this.l_PDW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_PDW.AutoSize = true;
            this.l_PDW.Location = new System.Drawing.Point(810, 83);
            this.l_PDW.Name = "l_PDW";
            this.l_PDW.Size = new System.Drawing.Size(65, 12);
            this.l_PDW.TabIndex = 44;
            this.l_PDW.Text = "0x00000000";
            // 
            // cap_PDW
            // 
            this.cap_PDW.AutoSize = true;
            this.cap_PDW.Location = new System.Drawing.Point(754, 83);
            this.cap_PDW.Name = "cap_PDW";
            this.cap_PDW.Size = new System.Drawing.Size(54, 12);
            this.cap_PDW.TabIndex = 43;
            this.cap_PDW.Text = "*DWORD:";
            // 
            // l_UTF16
            // 
            this.l_UTF16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_UTF16.AutoSize = true;
            this.l_UTF16.Location = new System.Drawing.Point(800, 126);
            this.l_UTF16.Name = "l_UTF16";
            this.l_UTF16.Size = new System.Drawing.Size(13, 12);
            this.l_UTF16.TabIndex = 42;
            this.l_UTF16.Text = "A";
            // 
            // l_UTF8
            // 
            this.l_UTF8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_UTF8.AutoSize = true;
            this.l_UTF8.Location = new System.Drawing.Point(796, 104);
            this.l_UTF8.Name = "l_UTF8";
            this.l_UTF8.Size = new System.Drawing.Size(13, 12);
            this.l_UTF8.TabIndex = 41;
            this.l_UTF8.Text = "A";
            // 
            // l_DW
            // 
            this.l_DW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_DW.AutoSize = true;
            this.l_DW.Location = new System.Drawing.Point(800, 59);
            this.l_DW.Name = "l_DW";
            this.l_DW.Size = new System.Drawing.Size(65, 12);
            this.l_DW.TabIndex = 40;
            this.l_DW.Text = "0x00000000";
            // 
            // l_Addr
            // 
            this.l_Addr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_Addr.AutoSize = true;
            this.l_Addr.Location = new System.Drawing.Point(780, 29);
            this.l_Addr.Name = "l_Addr";
            this.l_Addr.Size = new System.Drawing.Size(65, 12);
            this.l_Addr.TabIndex = 39;
            this.l_Addr.Text = "0x00000000";
            // 
            // cap_Offset
            // 
            this.cap_Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cap_Offset.AutoSize = true;
            this.cap_Offset.Location = new System.Drawing.Point(762, 294);
            this.cap_Offset.Name = "cap_Offset";
            this.cap_Offset.Size = new System.Drawing.Size(39, 12);
            this.cap_Offset.TabIndex = 38;
            this.cap_Offset.Text = "Offset:";
            // 
            // b_Jump
            // 
            this.b_Jump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Jump.Location = new System.Drawing.Point(871, 289);
            this.b_Jump.Name = "b_Jump";
            this.b_Jump.Size = new System.Drawing.Size(55, 23);
            this.b_Jump.TabIndex = 37;
            this.b_Jump.Text = "Jump";
            this.b_Jump.UseVisualStyleBackColor = true;
            // 
            // t_Offset
            // 
            this.t_Offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.t_Offset.Location = new System.Drawing.Point(807, 291);
            this.t_Offset.Name = "t_Offset";
            this.t_Offset.Size = new System.Drawing.Size(57, 19);
            this.t_Offset.TabIndex = 36;
            // 
            // cap_JumpTo
            // 
            this.cap_JumpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cap_JumpTo.AutoSize = true;
            this.cap_JumpTo.Location = new System.Drawing.Point(752, 268);
            this.cap_JumpTo.Name = "cap_JumpTo";
            this.cap_JumpTo.Size = new System.Drawing.Size(49, 12);
            this.cap_JumpTo.TabIndex = 35;
            this.cap_JumpTo.Text = "Jump to:";
            // 
            // b_cpDW
            // 
            this.b_cpDW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_cpDW.Location = new System.Drawing.Point(880, 54);
            this.b_cpDW.Name = "b_cpDW";
            this.b_cpDW.Size = new System.Drawing.Size(55, 23);
            this.b_cpDW.TabIndex = 34;
            this.b_cpDW.Text = "Copy";
            this.b_cpDW.UseVisualStyleBackColor = true;
            // 
            // b_cpAddr
            // 
            this.b_cpAddr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_cpAddr.Location = new System.Drawing.Point(857, 24);
            this.b_cpAddr.Name = "b_cpAddr";
            this.b_cpAddr.Size = new System.Drawing.Size(55, 23);
            this.b_cpAddr.TabIndex = 33;
            this.b_cpAddr.Text = "Copy";
            this.b_cpAddr.UseVisualStyleBackColor = true;
            // 
            // t_JumpTo
            // 
            this.t_JumpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.t_JumpTo.Location = new System.Drawing.Point(807, 265);
            this.t_JumpTo.Name = "t_JumpTo";
            this.t_JumpTo.Size = new System.Drawing.Size(119, 19);
            this.t_JumpTo.TabIndex = 32;
            // 
            // cap_UTF8
            // 
            this.cap_UTF8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cap_UTF8.AutoSize = true;
            this.cap_UTF8.Location = new System.Drawing.Point(752, 104);
            this.cap_UTF8.Name = "cap_UTF8";
            this.cap_UTF8.Size = new System.Drawing.Size(41, 12);
            this.cap_UTF8.TabIndex = 31;
            this.cap_UTF8.Text = "UTF-8:";
            // 
            // b_cpUTF16
            // 
            this.b_cpUTF16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_cpUTF16.Location = new System.Drawing.Point(754, 218);
            this.b_cpUTF16.Name = "b_cpUTF16";
            this.b_cpUTF16.Size = new System.Drawing.Size(172, 23);
            this.b_cpUTF16.TabIndex = 30;
            this.b_cpUTF16.Text = "Copy as UTF-16 String";
            this.b_cpUTF16.UseVisualStyleBackColor = true;
            // 
            // b_cpUTF8
            // 
            this.b_cpUTF8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_cpUTF8.Location = new System.Drawing.Point(754, 189);
            this.b_cpUTF8.Name = "b_cpUTF8";
            this.b_cpUTF8.Size = new System.Drawing.Size(172, 23);
            this.b_cpUTF8.TabIndex = 29;
            this.b_cpUTF8.Text = "Copy as UTF-8 String";
            this.b_cpUTF8.UseVisualStyleBackColor = true;
            // 
            // b_JumpToAddr
            // 
            this.b_JumpToAddr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_JumpToAddr.Location = new System.Drawing.Point(754, 160);
            this.b_JumpToAddr.Name = "b_JumpToAddr";
            this.b_JumpToAddr.Size = new System.Drawing.Size(172, 23);
            this.b_JumpToAddr.TabIndex = 28;
            this.b_JumpToAddr.Text = "Jump to the Address";
            this.b_JumpToAddr.UseVisualStyleBackColor = true;
            // 
            // cap_UTF16
            // 
            this.cap_UTF16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cap_UTF16.AutoSize = true;
            this.cap_UTF16.Location = new System.Drawing.Point(752, 126);
            this.cap_UTF16.Name = "cap_UTF16";
            this.cap_UTF16.Size = new System.Drawing.Size(47, 12);
            this.cap_UTF16.TabIndex = 27;
            this.cap_UTF16.Text = "UTF-16:";
            // 
            // cap_Addr
            // 
            this.cap_Addr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cap_Addr.AutoSize = true;
            this.cap_Addr.Location = new System.Drawing.Point(733, 29);
            this.cap_Addr.Name = "cap_Addr";
            this.cap_Addr.Size = new System.Drawing.Size(49, 12);
            this.cap_Addr.TabIndex = 26;
            this.cap_Addr.Text = "Address:";
            // 
            // cap_DW
            // 
            this.cap_DW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cap_DW.AutoSize = true;
            this.cap_DW.Location = new System.Drawing.Point(752, 59);
            this.cap_DW.Name = "cap_DW";
            this.cap_DW.Size = new System.Drawing.Size(48, 12);
            this.cap_DW.TabIndex = 25;
            this.cap_DW.Text = "DWORD:";
            // 
            // hbox
            // 
            this.hbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hbox.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.hbox.LineInfoVisible = true;
            this.hbox.Location = new System.Drawing.Point(7, 0);
            this.hbox.Name = "hbox";
            this.hbox.ReadOnly = true;
            this.hbox.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hbox.Size = new System.Drawing.Size(720, 432);
            this.hbox.StringViewVisible = true;
            this.hbox.TabIndex = 24;
            this.hbox.UseFixedBytesPerLine = true;
            this.hbox.VScrollBarVisible = true;
            // 
            // MyTabPageTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 432);
            this.Controls.Add(this.l_prange);
            this.Controls.Add(this.cap_pinfo);
            this.Controls.Add(this.b_cpPDW);
            this.Controls.Add(this.l_PDW);
            this.Controls.Add(this.cap_PDW);
            this.Controls.Add(this.l_UTF16);
            this.Controls.Add(this.l_UTF8);
            this.Controls.Add(this.l_DW);
            this.Controls.Add(this.l_Addr);
            this.Controls.Add(this.cap_Offset);
            this.Controls.Add(this.b_Jump);
            this.Controls.Add(this.t_Offset);
            this.Controls.Add(this.cap_JumpTo);
            this.Controls.Add(this.b_cpDW);
            this.Controls.Add(this.b_cpAddr);
            this.Controls.Add(this.t_JumpTo);
            this.Controls.Add(this.cap_UTF8);
            this.Controls.Add(this.b_cpUTF16);
            this.Controls.Add(this.b_cpUTF8);
            this.Controls.Add(this.b_JumpToAddr);
            this.Controls.Add(this.cap_UTF16);
            this.Controls.Add(this.cap_Addr);
            this.Controls.Add(this.cap_DW);
            this.Controls.Add(this.hbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyTabPageTemplate";
            this.Text = "MyTabPageTemplate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_prange;
        private System.Windows.Forms.Label cap_pinfo;
        private System.Windows.Forms.Button b_cpPDW;
        private System.Windows.Forms.Label l_PDW;
        private System.Windows.Forms.Label cap_PDW;
        private System.Windows.Forms.Label l_UTF16;
        private System.Windows.Forms.Label l_UTF8;
        private System.Windows.Forms.Label l_DW;
        private System.Windows.Forms.Label l_Addr;
        private System.Windows.Forms.Label cap_Offset;
        private System.Windows.Forms.Button b_Jump;
        private System.Windows.Forms.TextBox t_Offset;
        private System.Windows.Forms.Label cap_JumpTo;
        private System.Windows.Forms.Button b_cpDW;
        private System.Windows.Forms.Button b_cpAddr;
        private System.Windows.Forms.TextBox t_JumpTo;
        private System.Windows.Forms.Label cap_UTF8;
        private System.Windows.Forms.Button b_cpUTF16;
        private System.Windows.Forms.Button b_cpUTF8;
        private System.Windows.Forms.Button b_JumpToAddr;
        private System.Windows.Forms.Label cap_UTF16;
        private System.Windows.Forms.Label cap_Addr;
        private System.Windows.Forms.Label cap_DW;
        private Be.Windows.Forms.HexBox hbox;
    }
}