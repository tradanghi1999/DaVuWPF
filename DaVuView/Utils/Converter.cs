using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class Converter
    {
        public static string FromBytesToBase64(byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }

        public static byte[] FromBase64ToBytes(this string base64String)
        {
            return Convert.FromBase64String(base64String);
        }

    }
}
