using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Entites
{
    public class Ingredient : Base
    {
        public TypeIng TypeID { get; set; }

        public int Price { get; set; }
    }
}
