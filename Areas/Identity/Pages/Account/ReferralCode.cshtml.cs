using _789.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace _789.Areas.Identity.Pages.Account
{
    public class ReferralCodeModel : PageModel
    {
        private IDataService servicer;

        public ReferralCodeModel(IDataService servicer)
        {
            this.servicer = servicer;
        }
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }
        public class InputModel
        {
            [Required]
            [StringLength(16)]
            [Display(Name = "ReferralCode")]
            public string RefCode { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            var taskState = VerifyRefCode();
            if (taskState == true)
            {
                returnUrl ??= Url.Content("~/");
                return RedirectToPage("Register", new { referralCode = Input.RefCode, returnUrl = returnUrl });
            }
            return Page();
        }
        public bool VerifyRefCode()
        {
            var result = servicer.VerifyReferralCode(Input.RefCode);
            return result.IsCompletedSuccessfully;
        }
    }
}
