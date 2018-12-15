using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemDumpViewer {
    public class TabManager {
        public static TabManager Inst;

        private TabControl _ctrl;
        private List<MyTabPage> _tabs = new List<MyTabPage>();

        public static void Init(TabControl ctrl) {
            Inst = new TabManager(ctrl);
        }

        private TabManager(TabControl ctrl) {
            this._ctrl = ctrl;
            _ctrl.Controls.Add(createNewTab());
            addDefaultTab();
            _ctrl.SelectedIndexChanged += new System.EventHandler(ctrl_SelectedIndexChanged);
        }

        // 指定されたアドレスを含むダンプをすでに開いているタブに切り替えるか、または新規にタブを開きます
        public bool LaunchViewer(long address, bool isAutomatic = false) {
            int i = 0;
            // Search for opened tabs
            for(; i < _tabs.Count; i++) {
                if (_tabs[i].IsAutomaticTab && _tabs[i].CurrentDump.Includes(address))
                    break;
            }
            if (i == _tabs.Count) { // No opened tabs
                var handle = DumpManager.Inst.GetDumpHandle(address);
                if (handle == default(DumpHandle))
                    return false;
                var idx = addTab(handle, isAutomatic, address);
                switchTab(idx);
                return true;
            }

            switchTab(i);

            return true;
        }

        private TabPage createNewTab() {
            TabPage ntab = new TabPage();
            ntab.Text = "New";
            return ntab;
        }

        private void ctrl_SelectedIndexChanged(object sender, EventArgs e) {
            if(_ctrl.Controls[_ctrl.SelectedIndex].Text == "New")
                addDefaultTab();
        }

        private void switchTab(int index) {
            this._ctrl.SelectedIndex = index;
            this._tabs[index].OnFocus();
        }

        private int addDefaultTab() {
            var tab = new MyTabPage();
            var idx = appendTab(tab.Tab);
            _tabs.Add(tab);
            return idx;
        }

        private int addTab(DumpHandle handle, bool isAutomatic, long address = -1) {
            var tab = new MyTabPage(handle, isAutomatic);
            if (address != -1)
                tab.Seek(address);
            var idx = appendTab(tab.Tab);
            _tabs.Add(tab);
            return idx;
        }

        // Newページの存在を考慮して末尾にTabPageを追加します。
        // returns:追加されたページのインデックス
        private int appendTab(TabPage tab) {
            _ctrl.SuspendLayout();
            var cnt = this._ctrl.Controls.Count - 1;
            var ntab = this._ctrl.Controls[cnt];
            if(cnt >= 1)
                this._ctrl.SelectedIndex = cnt - 1;
            this._ctrl.Controls.RemoveAt(cnt);
            this._ctrl.Controls.Add(tab);
            this._ctrl.Controls.Add(ntab);
            this._ctrl.SelectedIndex = cnt;
            _ctrl.ResumeLayout();
            return cnt++;
        }
    }
}
