using System;

namespace TerjeOppgave1Rewrite2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\GET Academy\\Desktop\\Modul 3 Prosjekter\\TerjeOppgave1Rewrite2\\TerjeOppgave1Rewrite2\\myWalks – Kopi – Kopi – Kopi.txt";
            var WalkList = WalkCollection.ReadWalksFromFile(filePath);
            Console.WriteLine(WalkList.GetDescription());
        }
    }
}
