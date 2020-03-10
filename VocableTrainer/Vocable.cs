using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocableTrainer
{
    class Vocable
    {
        public Vocable(string voc, string trans)
        {
            VocableValue = voc;
            Translation = trans;
        }
        public String VocableValue { get; set; }
        public String Translation { get; set; }
    }
}
