using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WQuasar.Models;

namespace WQuasar.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;

        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]
        public ActionResult Subscriptions()
        {
            var model = new List<SubscriptionsViewModel>();
            var subscriptions = _dbContext.Subscriptions.ToList();

            foreach (var subscription in subscriptions)
            {
                var m = new SubscriptionsViewModel
                {
                    Id = subscription.Id,
                    Name = subscription.Name,
                    Description = subscription.Description,
                    Period = subscription.Period,
                    Services = subscription.Services.ToList(),
                    IsNew = subscription.IsNew,
                    Price = subscription.Services.Sum(s => s.Price),
                    CssClass = subscription.CssClass
                };

                model.Add(m);
            }
            return View(model);
        }
    }
}