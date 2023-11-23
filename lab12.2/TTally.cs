using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12._2
{
    internal class TTallyList
    {
        protected List<string> tallylist;
        internal void Fill(string tally) 
        {
            //.WriteLine("Для завершения ввода нажмите Enter...");
            while (tally != "") 
            {
                if (tallylist.Contains(tally.ToLower()) == false)
                    tallylist.Add(tally.ToLower());
                tally = Console.ReadLine();
            }
        }
        internal void Delete(string? tally)
        {
            //Console.WriteLine("Для завершения удаления нажмите Enter...");
            while (tally != "")
            {
                tallylist.Remove(tally);
                tally = Console.ReadLine();
            }
        }
        internal void Print()
        {
            foreach (string tally in tallylist)
            { Console.WriteLine(tally); }
            Console.WriteLine();
        }
    }
}
    