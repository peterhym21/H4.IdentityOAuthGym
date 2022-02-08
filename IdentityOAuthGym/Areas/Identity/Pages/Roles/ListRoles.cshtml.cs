using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IdentityOAuthGym.Areas.Identity.Pages.Roles
{
    [Authorize(Roles = "Admin")]
    public class ListRolesModel : PageModel
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public ListRolesModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IEnumerable<IdentityRole> Roles { get; set; }

        public void OnGet() => Roles = _roleManager.Roles;
    }
}
