using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Diagnostics;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponseModel response)
        {
            if (ModelState.IsValid)
            {
                RepositoryModel.AddResponse(response);
                return View("Thanks", response);
            }
            else
            {
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            return View(RepositoryModel.Responses.Where(x => x.WillAttend == true));
        }

    }
}