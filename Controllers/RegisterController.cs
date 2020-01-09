using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Registration.Models;
using Registration.Data;

namespace Registration.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ILogger<RegisterController> _logger;
        private readonly DatabaseContext _dbContext;

        public RegisterController(ILogger<RegisterController> logger, DatabaseContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Register");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegistrationModel registration)
        {
            // Check if model state is valid.
            if(!ModelState.IsValid) {
                return View(registration);
            }

            // // Check if email is already registered.
            // if(_dbContext.Registrations.Any(reg => reg.Email == registration.Email)) {
            //     // Add Email already registered error.
            //     ModelState.AddModelError("Email", $"Email {registration.Email} is already registered.");
            //     return View(registration);
            // }

            // Add register model to data context.
            _dbContext.Registrations.Add(registration);

            // Save changes.
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Submitted");

        }

        public IActionResult Submitted() {
            return View();
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyEmail(string email)
        {
            // Check if email already registered.
            if (_dbContext.Registrations.Any(reg => reg.Email == email))
            {
                return Json($"Email {email} is already registered.");
            }

            return Json(true);

        }

    }
}
