using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WQuasar.Models;

namespace WQuasar.Controllers
{
    public class SubscriptionsController : Controller
    {
        private ApplicationDbContext _dbContext;

        public SubscriptionsController()
        {
            _dbContext = new ApplicationDbContext();
        }

        // GET: Subscriptions
        [Authorize]
        public ActionResult Index()
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
                    CssClass = subscription.CssClass,
                };

                model.Add(m);
            }
            return View(model);
        }

        [Authorize]
        public ActionResult Payment(PaymentViewModel model)
        {
            var subscription = _dbContext.Subscriptions.FirstOrDefault(s => s.Id == model.SubscriptionId);

            if (subscription == null)
            {
                ModelState.AddModelError("", "Ошибка обработки данных.");
                model = null;
                return View(model);
            }

            model.SubscriptionId = subscription.Id;
            model.SubscriptionName = subscription.Name;
            model.Price = subscription.Services.Sum(s => s.Price);
            model.Services = subscription.Services.ToList();
            model.Payments = _dbContext.Payments.ToList();

            if (ModelState.IsValid)
            {
                return View(model);
            }

            ModelState.AddModelError("", "Ошибка обработки данных.");
            model = null;
            return View(model);
        }
    }
}