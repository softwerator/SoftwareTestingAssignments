using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            baslat:
            Process p = new Process();
            Console.Write("Hane Sayısı: ");
            int haneSayisi = Convert.ToInt32(Console.ReadLine());
            haneSayisi = Convert.ToInt32(Math.Pow(2, haneSayisi));
            p.AddItem(haneSayisi);
            Console.WriteLine(p.TrueList.Count);
            goto baslat;
        }
    }
}
