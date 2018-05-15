using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regg
{
    public class oseba
    {
        public string ID { get; set; }
        public string ime { get; set; }
        public string priimek { get; set; }
        public string id_kartice { get; set; }

        public string fullInfo
        {
            get
            {
                return $"{ime} {priimek} Id : {id_kartice}";
            }
        }
        
            

    }
}
