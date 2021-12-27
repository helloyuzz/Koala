using Koala.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Koala.Extensions {
    public class CookieUtils {
        public static Account Get(List<Claim> claims) {
            Account user = null;
            if (claims.Count > 0) {
                string xmlContent = claims.FirstOrDefault(t => t.Type.Contains("emailaddress")).Value;
                if (string.IsNullOrEmpty(xmlContent) == false) {
                    user = JsonConvert.DeserializeObject<Account>(xmlContent);
                    user.HashedPassword = null;
                } else {
                    user = new Account();
                }
            }
            return user;
        }
    }
}
