using AuthenticationServer.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthenticationServer.Controllers
{
    [ApiController]
    [Route("api")]
    public class AccountVerificationController : ControllerBase
    {

        private IAuthenticationService authenticationService;

        public AccountVerificationController(IAuthenticationService _service)
        {
            authenticationService = _service;
        }

        [HttpGet("verifyaccount")]
        public IActionResult VerifyAccount(string token)
        {
            authenticationService.VerifyAccount(token);
            return RedirectToAction("AccountVerified","Home");
        }
    }
}

