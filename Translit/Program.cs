using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translit
{
   
    class Program
    {
          static void Main(string[] args) {
           Dictionary<string, string> translate = new Dictionary<string, string>();
            translate.Add("A", "A");
            translate.Add("Б", "B");
            translate.Add("B", "V");
            translate.Add("Г", "G");
            translate.Add("Д", "D");
            translate.Add("Е", "E");
            translate.Add("Ё", "YO");
            translate.Add("Ж", "ZH");
            translate.Add("З", "Z");
            translate.Add("И", "I");
            translate.Add("Й", "I");
            translate.Add("К", "K");
            translate.Add("Л", "L");
            translate.Add("М", "M");
            translate.Add("Н", "N");
            translate.Add("О", "O");
            translate.Add("П", "P");
            translate.Add("Р", "R");
            translate.Add("С", "S");
            translate.Add("Т", "T");
            translate.Add("У", "U");
            translate.Add("Ф", "F");
            translate.Add("Х", "H");
            translate.Add("Ц", "C");
            translate.Add("Ч", "CH");
            translate.Add("Ш", "SH");
            translate.Add("Щ", "SH");
            translate.Add("Ы", "IH");
            translate.Add("Э", "EH");
            translate.Add("Ю", "YU");
            translate.Add("Я", "YA");
            translate.Add("а", "a");
            translate.Add("б", "b");
            translate.Add("в", "v");
            translate.Add("г", "g");
            translate.Add("д", "d");
            translate.Add("е", "e");
            translate.Add("ё", "yo");
            translate.Add("ж", "zh");
            translate.Add("з", "z");
            translate.Add("и", "i");
            translate.Add("й", "i");
            translate.Add("к", "k");
            translate.Add("л", "l");
            translate.Add("м", "m");
            translate.Add("н", "n");
            translate.Add("о", "o");
            translate.Add("п", "p");
            translate.Add("р", "r");
            translate.Add("с", "s");
            translate.Add("т", "t");
            translate.Add("у", "u");
            translate.Add("ф", "f");
            translate.Add("х", "h");
            translate.Add("ц", "c");
            translate.Add("ч", "ch");
            translate.Add("ш", "sh");
            translate.Add("щ", "sh");
             translate.Add("ы", "ih");
             translate.Add("э", "eh");
            translate.Add("ю", "yu");
            translate.Add("я", "ya");
            string readytranslte;
            string perevod = Console.ReadLine();
            bool Proverka = translate.TryGetValue(perevod, out readytranslte);
            if (Proverka)
                Console.WriteLine(readytranslte);
            //Переводит только по одну букву.
            //Не добавил Мягкий и твердый знак.
            //Транслит работает только в одну сторону.
             
            // Нужно вынести все в отдельный класс и метод, Main должен только вызвать методы.
            //Можно обойтись в словаре символами только в одном регистре, проверять на равенство при помощи ToUpper, ToLower
            Console.ReadLine();





        }
        
          
    }  
            

    }
    

