using Koala.Extensions;
using Koala.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Koala.Pages {
    public class IndexModel : PageModel {
        private readonly koalaContext koalaContext;
        public IndexModel(koalaContext _koalaContext)  {
            koalaContext = _koalaContext;
        }
        [BindProperty(SupportsGet = true)]
        public Account Account { get; set; }
        public IActionResult OnGet() {
            Account account = CookieUtils.Get(HttpContext.User.Claims.ToList());
            if (account != null) {
                if (account.IsAdmin.Value) {
                    return Redirect("/Administration/Index");
                } else {
                    return Redirect("/Client/Index");
                }
            } else {
                return Page();
            }
        }
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            var result = koalaContext.Accounts.FirstOrDefault(t => t.Login.Equals(Account.Login) && t.HashedPassword.Equals(Account.HashedPassword));
            if (result != null) {
                result.LastLoginOn = DateTime.Now;
                koalaContext.SaveChanges();

                var claims = new List<Claim>() {
                            new Claim(ClaimTypes.NameIdentifier,Convert.ToString(result.Id)),
                            new Claim(ClaimTypes.Name,result.Login),
                            new Claim(ClaimTypes.Email,JsonConvert.SerializeObject(result)),
                            new Claim(ClaimTypes.Role,result.IsAdmin.ToString()),
                            new Claim("FavoriteDrink","Tea")
                        };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties() { IsPersistent = true, ExpiresUtc = DateTime.Now.AddMinutes(16) });
                if (result.IsAdmin.Value) {
                    return RedirectToPage("/Administration/Index");
                } else {
                    return RedirectToPage("/Client/Index");
                }
            } else {
                TempData["loginMessage"] = "用户名或密码错误！";
                return Page();
            }
        }
    }
}
