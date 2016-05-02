using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WQuasar.Models.Entities
{
    public class UserService
    {
        [Key, Column(Order = 0)]
        public int User_Id { get; set; }
        [Key, Column(Order = 1)]
        public int Service_Id { get; set; }
        public DateTime From { get; set; }  //Дата с которой услуга будет действовать или действует
        public DateTime To { get; set; }    //Дата по которую услуга будет действовать
    }
}