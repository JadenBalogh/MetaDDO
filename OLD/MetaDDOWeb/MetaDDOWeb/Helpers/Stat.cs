using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDDOWeb.Helpers
{
    public class Stat
    {
        public string name;
        public float relativeAmount;
        public int total;
        public int max;
        public Dictionary<StackingType, int> amounts;
        public float weight;

        public Stat(string name)
        {
            this.name = name;
            amounts = new Dictionary<StackingType, int>();
        }
    }
}
