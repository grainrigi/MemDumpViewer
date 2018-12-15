using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemDumpViewer {
    public struct DumpUnit : IComparable<DumpUnit>, IComparable<long> {
        public long start;
        public long end;

        public string path;

        /// <summary>
        /// 指定されたアドレスがダンプに含まれているかを取得します。
        /// </summary>
        /// <param name="addr">調べたいアドレス</param>
        /// <returns>指定されたアドレスがダンプに含まれていればTrue。</returns>
        public bool Includes(long addr) { return start <= addr && addr <= end; }

        public int CompareTo(DumpUnit other) {
            if (other.end <= this.start)
                return 1;
            else if (this.end <= other.start)
                return -1;
            else
                return 0;
        }

        public int CompareTo(long other) {
            if (other < this.start)
                return 1;
            else if (this.end < other)
                return -1;
            else
                return 0;
        }
    }
}
