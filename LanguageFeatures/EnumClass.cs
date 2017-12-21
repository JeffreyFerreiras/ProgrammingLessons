using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    static class EnumClass
    {
        enum Box
        {
            HEIGHT,
            WIDTH,
            DEPTH
        }

        public static void UseEnum()
        {
            int height = Box.HEIGHT.GetEnumValue<int>();
            int width = Box.WIDTH.GetEnumValue<int>();
            int depth = Box.DEPTH.GetEnumValue<int>();
        }

        public static T GetEnumValue<T>(this object e) => (T)e;
    }
}
