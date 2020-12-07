using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.Infracstructure.InterfaceService;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Application
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailsController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        // POST api/emails/password-reset
        [HttpPost("password-reset")]
        public async Task<IActionResult> ResetPassword([FromForm] PasswordVM passwordVM)
        {
            if (passwordVM.Token == null)
            {
                return BadRequest(new
                {
                    message = "can't access like that !",
                    is_erro = true
                });
            }
            var result = await _emailService.ResetPassword(passwordVM);
            if (result)
            {
                return Ok(new
                {
                    message = "Your password has reset !",
                    is_erro = false
                });
            }
            else
            {
                return BadRequest(new
                {
                    message = "can't reset password, something wrong !",
                    is_erro = true
                });
            }
        }

        // GET api/emails/email-confirm/?tokenEmail=
        [HttpGet("email-confirm")]
        public async Task<IActionResult> ConfirmEmail(string tokenEmail)
        {
            if (tokenEmail == null)
            {
                return BadRequest(new
                {
                    message = "can't access like that !",
                    is_erro = true
                });
            }
            var result = await _emailService.ConfirmEmail(tokenEmail);
            if (result)
            {
                return Ok(new
                {
                    message = "Your email has confirm !",
                    is_erro = false
                });
            }
            else
            {
                return BadRequest(new
                {
                    message = "can't confirm email, something wrong !",
                    is_erro = true
                });
            }
        }
    }
}
