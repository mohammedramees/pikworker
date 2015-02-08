using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pikworker_Windows
{
    public class  works : IEnumerable
    {
        public IEnumerable AutoCompletions = new List<string>()
        { "painter","plumber","carpenter", "Electrician","Cleaner", "Welder", "Cook", "driver", "sweeper"
          };

        
        public IEnumerator GetEnumerator()
        {
            return AutoCompletions.GetEnumerator();
            
        }
    }
   

    }

    


