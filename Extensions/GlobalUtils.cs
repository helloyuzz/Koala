using Koala.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koala {
    public class GlobalUtils {
        public static string Parse(string value) {
            string result = "";

            if (value.Equals("新建")) {
                result = "🟢"+value;
            } else {
                result = value;
            }
            return result;
        }
    }
}
