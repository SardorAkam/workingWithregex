using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {

            //// task 1, 2
            //string pattern = @"[A-Z,a-z,0-9]+.@[a-z]+\.[a-z]{2,3}";
            //string str = "da12dds123shuhfkbnn uktam@gmail.com vevs vshbviugwyvgsdbvsvdv s egf ismoil@dsah.ru gfgdsc gdsafbkv ewgfgewkfhkbfv uefj wgfkjdfuw Muhammad2007Ali@sdffw.uz sdffs";
            //Regex regex = new Regex(pattern);
            //Console.WriteLine(regex.IsMatch(str));
            //var emails = regex.Matches(str);
            //foreach (var item in emails)
            //{
            //    Console.WriteLine(item);
            //}
            //// task 3
            //string salomPattern = @"(salom|Salom)";
            //string text = "wkdkkijsalomdnnsalomNSsdcnnSalomcdsalom";
            //Regex regexForSalom = new Regex(salomPattern);
            //var salomlar = regexForSalom.Matches(text);
            //foreach (var salom in salomlar)
            //{
            //    Console.Write($" {salom}");
            //}
            //Console.WriteLine();
            //// task 4
            //string findNumberPattern = @"(\d)";
            //string textWithNumbers = "gs3caefs5dfdsfdscb5ecs7dwfwb8weww9e0c";
            //Regex regexForNumbers = new Regex(findNumberPattern);
            //var sonlar = regexForNumbers.Matches(textWithNumbers);
            //foreach (var son in sonlar)
            //{
            //    Console.Write($" {son}");
            //}
            //Console.WriteLine();
            //// task 5
            //string findSpacePattern = @"\s"; 
            //string textWithSpace = "Hello world I am regex";
            //Regex regexForSpace = new Regex(findSpacePattern);
            //textWithSpace = regexForSpace.Replace(textWithSpace, "..");
            //Console.WriteLine(textWithSpace);

            // parol checking 
            string parolPattern = @"([A-Z]+,[a-z]+)";
            string parol = "tfgyAAhdd";
            Regex parolRegex = new Regex(parolPattern);
            Console.WriteLine(parolRegex.IsMatch(parol));
            Console.WriteLine(parolRegex.Match(parol));

        }
    }
}