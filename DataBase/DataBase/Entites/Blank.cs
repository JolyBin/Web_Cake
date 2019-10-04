using DataBase.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.DataBase.Entites
{
    public class Blank : Base
    {
        public Ingredient IngredientID { get; set; }

        public int Weight { get; set; }

        public Cake CakeID { get; set; }
    }
}
