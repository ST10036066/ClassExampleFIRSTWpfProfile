using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExampleFIRSTWpfProfile
{
     class validation
    {
        public validation() { }

        public bool valid(string input)
        {
            int x; 
            bool val = int.TryParse(input, out x);
            return val;

            //checking if input is valid
        }
    }
}
