using System.Collections.Generic;

namespace WQuasar.Models.Entities
{
    public class Subscription
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Period { get; set; } //Период действия подписки в месяцах, например: 1 месяц, 2 месяца, 6 месяцев и т.д.
        public virtual ICollection<Service> Services { get; set; }
        public bool IsNew { get; set; } //Новая подписка
        public string CssClass { get; set; }    //Служит для создания гибкости в дизайне интерфейса
    }
}