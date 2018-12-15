using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemDumpViewer {
    public static class ListExtension {
        public static IEnumerable<T> Find<T,TComp>(this IEnumerable<T> source, TComp val) where T : IComparable<TComp> {
            foreach(var item in source) {
                if (item.CompareTo(val) == 0)
                    yield return item;
            }
        }
    }
}
