using System.Collections.Generic;

namespace WQuasar.Models.Entities
{
    public class Subscription
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ServiceId { get; set; }
        public List<Service> Services { get; set; }
    }
}