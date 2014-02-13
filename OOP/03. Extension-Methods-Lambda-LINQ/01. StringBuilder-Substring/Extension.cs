using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_Substring
{
    public static class Extension
    {
        public static StringBuilder Substring(this StringBuilder strBuilder, int startIndex, int length)
        {
            StringBuilder result = new StringBuilder();

            for (int i = startIndex; i < startIndex + length; i++)
            {
                result.Append(strBuilder[i]);
            }

            return result;
        }
    }
}
