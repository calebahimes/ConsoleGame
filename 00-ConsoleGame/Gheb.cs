using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_ConsoleGame
{
    public class Gheb
    {
        public Gheb()
        {
            HP = 30;
            string killerAxeName = "1. Killer Axe";
            string killerAxeDescription = "Gheb's favorite axe. He never leaves home without it!";
            string ironAxeName = "2. Iron Axe";
            string ironAxeDescription = "Gheb carries this axe around too for some reason. Gheb doesn't like bows. Don't use this. Gheb will surely lose without his Killer Axe!";
            string crumpetsName = "3. Crumpets";
            string crumpetsDescription = "Gheb doesn't really like tea, but he craves crumpets. Restores 10HP.";
            AddItem(killerAxeName,killerAxeDescription);
            AddItem(ironAxeName,ironAxeDescription);
            AddItem(crumpetsName,crumpetsDescription);
        }
        public int HP { get; set; }
        private List<Item> Items { get; set; } = new List<Item>();

        public Item CreateItem(string name, string description)
        {
            Item item = new Item();
            item.Name = name;
            item.Description = description;
            return item;
        }

        public void AddItem(string name, string description)
        {
            Item item = CreateItem(name, description);
            Items.Add(item);
        }
        public void DisplayItems()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
