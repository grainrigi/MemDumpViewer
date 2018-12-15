using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Be.Windows.Forms;

namespace MemDumpViewer {
    public class DumpHandle : IComparable<long> {
        public DumpUnit Unit { get; private set; }

        public FileByteProvider Provider { get; private set; }

        public DumpHandle(DumpUnit unit) {
            this.Unit = unit;
            this.Provider = new FileByteProvider(unit.path);
        }

        public uint ReadDWORD(long address) {
            long rel = address - Unit.start;
            return (uint)((uint)Provider.ReadByte(rel)
                + ((uint)Provider.ReadByte(rel + 1) << 8)
                + ((uint)Provider.ReadByte(rel + 2) << 16)
                + ((uint)Provider.ReadByte(rel + 3) << 24));
        }

        public char ReadUTF8(long address) {
            const char invalid = '\0';

            long rel = address - Unit.start;
            byte[] vs = new byte[4];
            vs[0] = Provider.ReadByte(rel);
            if ((vs[0] & 0x80) == 0)
                return Encoding.UTF8.GetChars(vs)[0];
            else {
                vs[1] = Provider.ReadByte(rel + 1);
                if ((vs[0] & 0xE0) == 0xC0) {
                    if ((vs[1] & 0xC0) != 0x80)
                        return invalid;
                    else
                        return Encoding.UTF8.GetChars(vs)[0];
                }
                else if ((vs[0] & 0xF0) == 0xE0) {
                    vs[2] = Provider.ReadByte(rel + 2);
                    if ((vs[1] & 0xC0) != 0x80 || (vs[2] & 0xC0) != 0x80)
                        return invalid;
                    else
                        return Encoding.UTF8.GetChars(vs)[0];
                }
                else if ((vs[0] & 0xF8) == 0xF0) {
                    vs[3] = Provider.ReadByte(rel + 3);
                    if ((vs[1] & 0xC0) != 0x80 || (vs[2] & 0xC0) != 0x80 || (vs[3] & 0xC0) != 0x80)
                        return invalid;
                    else
                        return Encoding.UTF8.GetChars(vs)[0];
                }
                else
                    return invalid;
            }
        }

        public char ReadUTF16(long address) {
            long rel = address - Unit.start;
            return (char)(Provider.ReadByte(rel) + Provider.ReadByte(rel + 1) << 8);
        }

        public int CompareTo(long other) {
            return Unit.CompareTo(other);
        }
    }
}
