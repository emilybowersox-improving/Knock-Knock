using System;

namespace Knock_Knock
{
    class Program
    {
        static void Main(string[] args) {

        WhosThere:
            Console.WriteLine("Knock knock!");
            String resp = Console.ReadLine().ToLower();
            if (resp.Contains("who's there"))
            {
                goto OwlsSay;
            }
            else
            {
                goto WhosThere;
            }

        OwlsSay:
            Console.WriteLine("Owls say");
            String nextResp = Console.ReadLine().ToLower();
            if (nextResp.Contains("owls say who"))
            {
                Console.WriteLine("Yes. Yes, they do.");
                goto WhosThere;
            }
            else
            {
                goto OwlsSay;
            }


        }
    }
}
