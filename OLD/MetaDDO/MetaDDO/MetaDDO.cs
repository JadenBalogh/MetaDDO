using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDDO
{
    public enum StackingType
    {
        COMPETENCE = 0
    }

    public class MetaDDO
    {
        public List<Item> items;
        public List<string> statNames;
        public List<float> statWeights;
        public List<Gearset> gearsets;

        public MetaDDO()
        {
            items = new List<Item>();
            statNames = new List<string>();
            statWeights = new List<float>();
            gearsets = new List<Gearset>();
        }

        public List<Item> readItemsFromFile()
        {
            List<Item> result = new List<Item>();
            
            // Read from file
            // Stream stuff

            return result;
        }
    }
}
