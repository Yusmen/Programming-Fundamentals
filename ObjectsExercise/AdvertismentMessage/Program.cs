using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertismentMessage
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] phrases = { "Excellent product.",
                    "Such a great product.",
                    "I always use that product.",
                    "Best product of its category.",
                    "Exceptional product.", "I can’t live without this product."};
            string[] events = { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.",
                "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella",
                "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] citeis = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            Random p = new Random();
            int phr = p.Next(phrases.Length);
            Console.Write(phrases[phr] + " ");
            int ev = p.Next(events.Length);
            Console.Write(events[ev] + " ");
            int au = p.Next(authors.Length);
            Console.Write(authors[au] + " " + "-" + " ");
            int c = p.Next(citeis.Length);
            Console.Write(citeis[c]+"  ");
        }
    }
}
