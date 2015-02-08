using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pikworker_Windows
{
    public class places : IEnumerable
    {
        public IEnumerable Autoplaces = new List<string>()
        { "Mumbai"

          };


        public IEnumerator GetEnumerator()
        {
            return Autoplaces.GetEnumerator();

        }
    }


}




