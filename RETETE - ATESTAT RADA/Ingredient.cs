using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RETETE__ATESTAT_RADA
{
    public class Ingredient
    {
        public int Id { get; set; }
        public int RetetaId { get; set; }
        public string NumeIngredient { get; set; }
        public string Cantitate { get; set; }
    }
}
