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
        public string VocableValue { get; set; }
        public string Translation { get; set; }
    }
}
