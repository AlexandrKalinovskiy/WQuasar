using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using WQuasar.Models.Entities;

namespace WQuasar.Models
{
    public class SubscriptionsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; } //Название отображаемое пользователю
        public string Description { get; set; }
        public int Period { get; set; }
        public List<Service> Services { get; set; }
        public decimal Price { get; set; }
        public bool IsNew { get; set; }
        public string CssClass { get; set; }
    }

    public class PaymentViewModel
    {
        [Required]
        [HiddenInput(DisplayValue = false)]
        public int SubscriptionId { get; set; }
        public string SubscriptionName { get; set; }
        public List<Service> Services { get; set; }
        public List<Payment> Payments { get; set; }
        public decimal Price { get; set; }
    }
}