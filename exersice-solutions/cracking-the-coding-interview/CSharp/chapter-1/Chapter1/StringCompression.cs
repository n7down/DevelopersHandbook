using System.Linq;
using System.Text;

namespace Chapter1
{
    public static class StringCompression
    {
        public static string CompressString(string s)
        {
            StringBuilder sb = new StringBuilder();
            var r = s
                .Aggregate(" ", (seed, next) => seed + (seed.Last() == next ? "" : " ") + next)
                .Trim()
                .Split(' ');
            foreach(string ss in r)
            {
                sb.Append(ss[0] + ss.Length.ToString());
            }
            if(sb.Length < s.Length)
            {
                return sb.ToString();
            }
            else
            {
                return s;
            }
        }
    }
}