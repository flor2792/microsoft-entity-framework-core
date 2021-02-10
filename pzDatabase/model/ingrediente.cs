using System;
using System.Collections.Generic;
using System.Text;

namespace pzDatabase.model
{
    public class ingrediente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public List<pizza> pizza { get; set; }
    }
}
