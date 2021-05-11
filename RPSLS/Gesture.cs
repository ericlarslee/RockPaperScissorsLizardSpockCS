using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Gesture
    {
        public string name;
        public string lose1;
        public string lose2;
        public string tie;
        public string beat1;
        public string beat2;

        public Gesture(string name, string lose1, string lose2, string tie, string beat1, string beat2)
        {
            this.name = name;
            this.lose1 = lose1;
            this.lose2 = lose2;
            this.tie = tie;
            this.beat1 = beat1;
            this.beat2 = beat2;
        }
    }
}
