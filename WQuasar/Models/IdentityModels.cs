using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using WQuasar.Models.Entities;
using System.Collections.Generic;

namespace WQuasar.Models
{
    // Чтобы добавить данные профиля для пользователя, можно добавить дополнительные свойства в класс User. Дополнительные сведения см. по адресу: http://go.microsoft.com/fwlink/?LinkID=317594.
    public class User : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Здесь добавьте утверждения пользователя
            return userIdentity;
        }

        public bool Active { get; set; }    //Состояние пользователя
        public ICollection<Service> Services { get; set; }  //Сервисы пользователя
    }

    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole(string name)
            : base(name)
        { }

        public ApplicationRole()
        { }

        public int NumberOfThreads { get; set; }    //Количество потоков для обслуживания сеансов пользователей с этой ролью

    }

    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext()
            : base("QuasarDatabase")
        {
            //Database.SetInitializer<ApplicationDbContext>(null);
        }

        new public DbSet<ApplicationRole> Roles { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}