using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Repository
{
    public class Repository
    {
        static void Main(string[] args)
        {
        }

        public void Fortune1()
        {
            Console.Clear();
            var fortune = new Random();
            var fortuneList = new List<string> { "Watch out for a good time disguised as a bad reputation.", "A strong defense is better than no fence.", "Help! I'm being held prisoner in CyberSpace!" };
            int index = fortune.Next(fortuneList.Count);
            Console.WriteLine(fortuneList[index]);
        }
        public void Fortune2()
        {
            Console.Clear();
            var fortune = new Random();
            var fortuneList = new List<string> { "Believe in yourself. Your hardwork will pay off soon.", "Some say with age comes wisdom. I say with age comes forgetfulness.", "Oops. Lost your fortune. Try again." };
            int index = fortune.Next(fortuneList.Count);
            Console.WriteLine(fortuneList[index]);
        }
        public void Fortune3()
        {
            Console.Clear();
            var fortune = new Random();
            var fortuneList = new List<string> { "Help! I'm being held prisoner in CyberSpace!", "I forsee many codes breaking in your future.", "Practice makes perfect." };
            int index = fortune.Next(fortuneList.Count);
            Console.WriteLine(fortuneList[index]);
        }
        public void Fortune4()
        {
            Console.Clear();
            var fortune = new Random();
            var fortuneList = new List<string> { "Some say with age comes wisdom. I say with age comes forgetfulness.", "It might to be time to put your stock in something new, like a pot.", "Good job. You have won 1 free token to nap." };
            int index = fortune.Next(fortuneList.Count);
            Console.WriteLine(fortuneList[index]);
        }
        public void Fortune5()
        {
            Console.Clear();
            var fortune = new Random();
            var fortuneList = new List<string> { "Does anyone else smell Chinese food?", "Fortune not found ---- ERROR: 404", "Oops. Lost your fortune. Try again." };
            int index = fortune.Next(fortuneList.Count);
            Console.WriteLine(fortuneList[index]);
        }
        public void Fortune6()
        {
            Console.Clear();
            var fortune = new Random();
            var fortuneList = new List<string> { "I forsee many codes breaking in your future.", "A strong defense is better than no fence.", "Roses are red. Violets are blue. This Gold Badge you'll get through." };
            int index = fortune.Next(fortuneList.Count);
            Console.WriteLine(fortuneList[index]);
        }
        public void Fortune7()
        {
            Console.Clear();
            var fortune = new Random();
            var fortuneList = new List<string> { "Fortune not found ---- ERROR: 404", "Watch out for a good time disguised as a bad reputation.", "Is something burning? Nope, that's just me." };
            int index = fortune.Next(fortuneList.Count);
            Console.WriteLine(fortuneList[index]);
        }
        public void Fortune8()
        {
            Console.Clear();
            var fortune = new Random();
            var fortuneList = new List<string> { "Roses are red. Violets are blue. This Gold Badge you'll get through.", "You are a certified kitty cat cuddler.", "Believe in yourself. Your hardwork will pay off soon." };
            int index = fortune.Next(fortuneList.Count);
            Console.WriteLine(fortuneList[index]);
        }
    }
}
