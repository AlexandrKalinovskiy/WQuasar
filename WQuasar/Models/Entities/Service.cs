using System.Collections.Generic;

namespace WQuasar.Models.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; } //Название отображаемое пользователю
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ICollection<User> Users { get; set; }  //Пользователи сервиса
        public virtual ICollection<Subscription> Subscriptions { get; set; }    //Подписки содержащие данную услугу
    }
}