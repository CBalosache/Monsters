using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Monster_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            if(Monster.jump() == true)
            {
                Console.WriteLine("JUMP");
            }
            if(Monster.scare() == true)
            {
                Console.WriteLine("SCARE");
            }
            Monster m1 = new Monster("1","Blue","Black","5","Invisibility");
            Monster m2 = new Monster("1", "Blue", "Black", "5", "Invisibility");
            MonsterCohort MH = new MonsterCohort();
            MH.addMonster(m1);
            MH.addMonster(m2);
            MH.importMonster();
            MH.listMonster();
            Console.Read();
        }
    }

    class Monster
    {
        public string id;
        public string eyes;
        public string hair;
        public string scaryLevel;
        public string specialAbility;
        public Monster(string idIn, string eyesIn, string hairIn, string scaryLevelIn, string specialAbilityIn)
        {
            this.id = idIn;
            this.eyes = eyesIn;
            this.hair = hairIn;
            this.scaryLevel = scaryLevelIn;
            this.specialAbility = specialAbilityIn;
        }   
        public static bool jump()
        {
            return true;
        }
        public static bool scare()
        {
            return true;
        }
    }

    class MonsterCohort
    {
        private string subject;
        private string startDate;
        public List<Monster> listOfMonsters = new List<Monster>();
        public void addMonster(Monster monsterIn)
        {
            listOfMonsters.Add(monsterIn);
        }
        public void listMonster()
        {
            foreach(Monster monster in listOfMonsters)
            {
                Console.WriteLine(monster.id + " " + monster.eyes + " " + monster.hair + " " + monster.scaryLevel + " " + monster.specialAbility);
            }
        }
        public void importMonster()
        {
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Cosmin Balosache\Desktop\Monsters.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                listOfMonsters.Add(new Monster(words[0], words[1], words[2], words[3], words[4]));
            }

            file.Close();
        }
    }

}
