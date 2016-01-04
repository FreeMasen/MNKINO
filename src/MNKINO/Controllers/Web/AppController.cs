using Microsoft.AspNet.Mvc;
using MNKINO.Models;
using MNKINO.Services;

namespace MNKINO.Controllers.Web
{

    public class AppController : Controller
    {
        private IMailService _mailService;
        private IScreeningRepository _repository;

        public AppController(IMailService service, IScreeningRepository repository)
        {
            _mailService = service;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}