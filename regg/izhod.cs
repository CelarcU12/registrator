using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regg
{
    public class izhod
    {
        int id { get; set; }
        DateTime prihod { get; set; }
        DateTime izhod_ { get; set; }
        
        public TimeSpan skupaj
        {
            get
            {
                 return prihod.Subtract(izhod_);
            }
            set
            {
                skupaj = prihod.Subtract(izhod_);
            }
            
        }

        public double ure
        {
            get
            {
                return skupaj.TotalHours;
            }
        }

    }


}
