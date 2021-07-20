using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Mo" };
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y'};
            var count = 0;

            foreach (var animal in animals)
            {
                    foreach(char vowel in vowels)
                    {
                        if (animal.Contains(vowel))
                        {
                            count++;
                            for (var i = 0; i < animal.Length; i++)
                            {
                                if ((animal[i] == vowel && i != animal.Length - 1) && (animal[i + 1] == 'a' || animal[i+1] == 'e' || animal[i+1] == 'i' || animal[i+1] == 'o' || animal[i+1] == 'u' || animal[i+1] == 'y'))
                            {
                                count--;
                            }
                            }
                        } 
                    }
                    if (count >= 2)
                    {
                        Console.WriteLine(animal);
                }
                count = 0;
            }

            Console.WriteLine("select a greeting: French, Spanish, Southern");
            var greeting = Console.ReadLine().ToLower();

            switch(greeting)
            {
                case "southern":
                    Console.WriteLine("Hey Y'all");
                    break;
                case "french":
                    Console.WriteLine("wesh");
                    break;
                case "spanish":
                    Console.WriteLine("Hola");
                    break;
                default:
                    Console.WriteLine("Hey Y'all");
                    break;
            }

            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");

            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();
            Random rnd = new Random();
            var randomAnimalIndex = rnd.Next(0, animals.Length);
            Console.WriteLine($"would you like a {color} {animals[randomAnimalIndex]}?");
        }
    }
}
