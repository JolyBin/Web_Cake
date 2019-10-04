using DataBase.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.DataBase.Entites
{
    public class Client: Base
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public int Number { get; set; }
        
        public string SurName { get; set; }

        public string Patronymic { get; set; }
    }
}
