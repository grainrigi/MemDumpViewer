using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;

namespace MemDumpViewer {
    public class DumpManager {
        public static DumpManager Inst { get; private set; }

        public DumpUnit[] Dumps { get; private set; }

        private DumpHandle[] handles;

        public static void Init(string dir, string pattern) {
            Inst = new DumpManager(dir, pattern);
        }

        private DumpManager() { }

        public DumpManager(string dir, string pattern) {
            var files = Directory.GetFiles(dir);

            // パターン生成
            if (pattern.IndexOf("${S}") == -1 || pattern.IndexOf("${E}") == -1)
                throw new ArgumentException("Pattern is Invalid.");
            var reg = new Regex(pattern.Replace("${S}", "([0-9A-Fa-f]+)").Replace("${E}", "([0-9A-Fa-f]+)"));

            // ソートして格納
            Dumps = FileListToDumpUnits(files, dir, reg).OrderBy(x => x).ToArray();
            handles = new DumpHandle[Dumps.Length];
            for(int i = 0; i < Dumps.Length; i++) {
                handles[i] = new DumpHandle(Dumps[i]);
            }
            if (Dumps.Length == 0)
                throw new FileNotFoundException("No files matched the pattern.");
        }

        public DumpHandle GetDumpHandle(long address) {
            int i = 0;
            for (; i < Dumps.Length; i++)
                if (Dumps[i].Includes(address))
                    break;
            if (i == Dumps.Length)
                return default(DumpHandle);

            if (handles[i] == null)
                handles[i] = new DumpHandle(Dumps[i]);
            return handles[i];
        }

        public DumpHandle GetDefaultHandle() {
            if (handles[0] == null)
                handles[0] = new DumpHandle(Dumps[0]);
            return handles[0];
        }

        public bool TryReadDWORD(long address, out uint value) {
            var handle = this.handles.Find(address).FirstOrDefault();
            if (handle == default(DumpHandle)) {
                value = 0;
                return false;
            }
            else {
                value = handle.ReadDWORD(address);
                return true;
            }
        }


        private IEnumerable<DumpUnit> FileListToDumpUnits(IEnumerable<string> files, string dir, Regex cond) {
            DumpUnit unit = default(DumpUnit);
            foreach (var file in files) {
                var match = cond.Match(file);
                if (!match.Success)
                    continue;

                unit.start = Convert.ToUInt32(match.Groups[1].Value, 16);
                unit.end = Convert.ToUInt32(match.Groups[2].Value, 16);
                unit.path = Path.Combine(dir, file);
                yield return unit;
            }
        }
    }
}
