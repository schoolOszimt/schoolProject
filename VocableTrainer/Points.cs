using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocableTrainer
{
    class Points
    {
        public int right { get; protected set; } = 0;
        public int wrong { get; protected set; } = 0;
        private static Points instance;
        private Points() { }
        public static Points GetInstance()
        {
            if (instance == null)
            {
                instance = new Points();
            }
            return instance;
        }
        public void WasAnswerRight(bool answer)
        {
            if (answer) instance.right += 1;
            else instance.wrong += 1;
        }

        public void Reset()
        {
            instance.right = 0;
            instance.wrong = 0;
        }
    }
}
