using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
   public static class Extensions
    {
        public static bool fdVersionCheck(this string args)
        {
            string argsLower = args.ToLower();
            return (argsLower == "-v" || argsLower == "--v" || argsLower == "--version" || argsLower == "/v") ? true : false;
        }
        public static bool fdSizeCheck(this string args)
        {
            string argsLower = args.ToLower();
            return (argsLower == "-s" || argsLower == "--s" || argsLower == "--size" || argsLower == "/s") ? true : false;
        }
    }
}
