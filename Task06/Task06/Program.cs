using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на русском языке");
            var text = Console.ReadLine();

            Console.WriteLine("\nНа азбуке Морзе:");
            Console.WriteLine(MorseTranslate(text));

            Console.ReadKey();
        }

        static string MorseTranslate(string s)
        {
            return s
                .ToUpper()
                .Replace(" ","  ")
                .Replace("А", "∙– ")
                .Replace("Б", "–∙∙∙ ")
                .Replace("В", "∙–– ")
                .Replace("Г", "––∙ ")
                .Replace("Д", "–∙∙ ")
                .Replace("Е", "∙ ")
                .Replace("Ё", "∙ ")
                .Replace("Ж", "∙∙∙– ")
                .Replace("З", "––∙∙ ")
                .Replace("И", "∙∙ ")
                .Replace("Й", "∙––– ")
                .Replace("К", "–∙– ")
                .Replace("Л", "∙–∙∙ ")
                .Replace("М", "–– ")
                .Replace("Н", "–∙ ")
                .Replace("О", "––– ")
                .Replace("П", "∙––∙ ")
                .Replace("Р", "∙–∙ ")
                .Replace("С", "∙∙∙ ")
                .Replace("Т", "– ")
                .Replace("У", "∙∙– ")
                .Replace("Ф", "∙∙–∙ ")
                .Replace("Х", "∙∙∙∙ ")
                .Replace("Ц", "–∙–∙ ")
                .Replace("Ч", "–––∙ ")
                .Replace("Ш", "–––– ")
                .Replace("Щ", "––∙– ")
                .Replace("Ъ", "––∙–– ")
                .Replace("Ы", "–∙–– ")
                .Replace("Ь", "–∙∙– ")
                .Replace("Э", "∙∙–∙∙ ")
                .Replace("Ю", "∙∙–– ")
                .Replace("Я", "∙–∙– ")
                .Replace(".", "∙∙∙∙∙ ")
                .Replace(",", "∙–∙–∙– ")
                .Replace(":", "–––∙∙∙ ")
                .Replace(";", "∙–∙–∙– ")
                .Replace("—", "–∙∙∙∙– ")
                .Replace("?", "∙∙––∙∙ ")
                .Replace("!", "––∙∙–– ")
                ;          
        }
    }
}
