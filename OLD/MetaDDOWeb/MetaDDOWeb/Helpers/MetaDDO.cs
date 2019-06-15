using System;
using System.Collections.Generic;
using CsvHelper;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDDOWeb.Helpers
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

        public List<Item> ReadItemsFromFile()
        {
            List<Item> result = new List<Item>();

            string itemPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\Items.csv");
            var itemReader = new StreamReader(itemPath);
            var itemCSV = new CsvReader(itemReader);
            itemCSV.Read();
            itemCSV.ReadHeader();
            string effectPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\Items.csv");
            var effectReader = new StreamReader(effectPath);
            var effectCSV = new CsvReader(effectReader);
            while (itemCSV.Read())
            {
                Item item = new Item()
                {
                    ID = itemCSV.GetField<int>("ID"),
                    Name = itemCSV.GetField("Name")
                };
                result.Add(item);
            }

            return result;
        }
    }
}
