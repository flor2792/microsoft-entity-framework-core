using System;
using System.Collections.Generic;
using System.Text;

namespace pzDatabase.model
{
    public class pizza
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }
        public List<ingrediente> ingrediente { get; set; }


    }
}
