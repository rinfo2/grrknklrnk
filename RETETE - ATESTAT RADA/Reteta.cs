using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RETETE__ATESTAT_RADA
{
    public class Reteta
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public int TipId { get; set; }
    }
}
