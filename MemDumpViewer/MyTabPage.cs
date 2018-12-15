using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Be.Windows.Forms;

namespace MemDumpViewer {
    public partial class MyTabPage {
        public DumpUnit CurrentDump => _handle.Unit;
        public long Address => CurrentDump.start + hbox.SelectionStart;
        public uint DWORD => _handle.ReadDWORD(Address);
        public bool IsAutomaticTab { get; private set; } = false;

        private DumpHandle _handle;
        private bool isDefault;
        
        public MyTabPage() {
            isDefault = true;
            InitializeComponent();
            LoadDefault();
        }

        public MyTabPage(DumpHandle handle, bool IsAutomatic = false) {
            isDefault = false;
            this.IsAutomaticTab = IsAutomatic;
            InitializeComponent();
            LoadHandle(handle);
        }

        public void Seek(long address) {
            if (!trySeekHBox(address))
                throw new IndexOutOfRangeException("Specified address is out of range.");
            updateStatusLabels();
        }

        public void OnFocus() {
            this.hbox.Focus();
            this.updateStatusLabels();
        }

        private void LoadDefault() {
            this.LoadHandle(DumpManager.Inst.GetDefaultHandle());
            this.hbox.Focus();
            updateStatusLabels();
            // Init PageInfo
            this.l_prange.Text = $"{CurrentDump.start:X8}-{CurrentDump.end:X8}";
        }

        private void LoadHandle(DumpHandle handle) {
            _handle = handle;
            hbox.ByteProvider = _handle.Provider;
            hbox.LineInfoOffset = CurrentDump.start;
            updateStatusLabels();
            // Init PageInfo
            this.l_prange.Text = $"{CurrentDump.start:X8}-{CurrentDump.end:X8}";
        }

        private void hbox_SelectionStartChanged(object sender, EventArgs e) {
            updateStatusLabels();
        }

        private EventHandler copyButtonHandler(Label label) {
            return new EventHandler((sender, e) => {
                Clipboard.SetText(label.Text.Replace("0x", ""));
            });
        }

        private void b_JumpToAddr_Click(object sender, EventArgs e) {
            jumpTo(DWORD, true);
            isDefault = false;
        }

        private void b_Jump_Click(object sender, EventArgs e) {
            var re = new System.Text.RegularExpressions.Regex("(?:0x)?[0-9a-fA-F]+");
            long addr = 0, off = 0;
            if (!re.IsMatch(t_JumpTo.Text)) {
                MessageBox.Show("The specified address is invalid.");
            }
            addr = Convert.ToInt64(t_JumpTo.Text, 16);
            if(re.IsMatch(t_Offset.Text))
                off = Convert.ToInt64(t_Offset.Text, 16);

            if (isDefault)
                jumpToInternal(addr + off);
            else
                jumpTo(addr + off, false);
        }

        // 必ず現在のタブページでジャンプ先を開きます
        private void jumpToInternal(long address) {
            bool result = trySeekHBox(address);
            if(!result) {
                var handle = DumpManager.Inst.GetDumpHandle(address);
                if(handle == default(DumpHandle))
                    MessageBox.Show($"Address 0x{address:X8} is not available.");
                else {
                    this.LoadHandle(handle);
                    this.Seek(address);
                }
            }
        }

        private void jumpTo(long address, bool isAutomatic) {
            bool result = trySeekHBox(address);
            if (!result) {
                result = TabManager.Inst.LaunchViewer(address, isAutomatic);
                if (!result)
                    MessageBox.Show($"Address 0x{address:X8} is not available.");
            }
        }

        private void updateStatusLabels() {
            this.l_Addr.Text = $"0x{Address:X8}";
            this.Tab.Text = IsAutomaticTab ? "[A]" + this.l_Addr.Text : this.l_Addr.Text;

            uint dw, pdw;
            dw = this.DWORD;
            this.l_DW.Text = $"0x{dw:X8}";
            if (!DumpManager.Inst.TryReadDWORD(dw, out pdw))
                this.l_PDW.Text = "Unavailable";
            else
                this.l_PDW.Text = $"0x{pdw:X8}";
            

            this.l_UTF8.Text = _handle.ReadUTF8(Address).ToString();
            this.l_UTF16.Text = _handle.ReadUTF16(Address).ToString();

        }

        private bool trySeekHBox(long addr) {
            if (!CurrentDump.Includes(addr))
                return false;

            long rpos = addr - CurrentDump.start;
            hbox.SelectionStart = (long)rpos;
            hbox.Focus();
            return true;
        }
    }
}
