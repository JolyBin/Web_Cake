using DataBase.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.DataBase.Entites
{
    public class Cake: Base
    {
        public int Price { get; set; }

        public Design DesigID { get; set; }
    }
}
