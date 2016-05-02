using System.Collections.Generic;
using WQuasar.Models.Entities;

namespace WQuasar.Models
{
    public class HomeViewModels
    {

    }

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
    }
}