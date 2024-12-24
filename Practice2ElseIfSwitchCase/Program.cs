using System;

class Program
{
    static void Main(string[] args)
    {
        //Aynı uygulamayı hem switch case hem de if yapıları ile yapılmıştır.
        //Switch Case ile yapılana uygulama1, if ile yapılana uygulama 2 denilmiştir.

        //Switch Case ile yapılan.
        Console.WriteLine("Uygulama1");
        Console.WriteLine("Rüya manavına hoşgeldiniz.");
        string apple, pear, strawberry, banana, other;
        apple = "Elma";
        pear = "Armut";
        strawberry = "Çilek";
        banana = "Muz";
        other = "Diğer";
        Console.WriteLine("Elma = 2 TL");
        Console.WriteLine("Armut = 3 TL");
        Console.WriteLine("Çilek = 2 TL");
        Console.WriteLine("Muz = 3 TL");
        Console.WriteLine("Diğer = 4 TL");
        Console.Write("Hangi meyveyi satın almak istersiniz? (Elma, Armut, Çilek, Muz, Diğer)");
        string userInput = Console.ReadLine();
        if (userInput != null)
        {
            userInput = userInput.ToLower();
            switch (userInput)
            {
                case "elma":
                    Console.WriteLine($"Seçtiğiniz meyve {apple} fiyatı: 2 TL");
                    break;
                case "armut":
                    Console.WriteLine($"Seçtiğiniz meyve {pear} fiyatı 3 TL");
                    break;
                case "çilek":
                    Console.WriteLine($"Seçtiğiniz meyve {strawberry} fiyatı 2 TL");
                    break;
                case "muz":
                    Console.WriteLine($"Seçtiğiniz meyve {banana} fiyatı 3 TL");
                    break;
                case "diğer":
                    Console.WriteLine($"Seçtiğiniz meyve {other} fiyatı 4 TL");
                    break;
                default:
                    Console.WriteLine("Girdiğiniz bilgi yanlıştır.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Girdiğiniz bilgi yanlıştır.");
        }

        Console.WriteLine("----------------------------");
        Console.WriteLine("----------------------------");
        Console.WriteLine("----------------------------");

        //if ile yapılan.
        Console.WriteLine("Uygulama2");
        Console.WriteLine("Rüya manavına hoşgeldiniz.");
        string apple2, pear2, strawberry2, banana2, other2;
        apple2 = "Elma";
        pear2 = "Armut";
        strawberry2 = "Çilek";
        banana2 = "Muz";
        other2 = "Diğer";
        Console.WriteLine("Elma = 2 TL");
        Console.WriteLine("Armut = 3 TL");
        Console.WriteLine("Çilek = 2 TL");
        Console.WriteLine("Muz = 3 TL");
        Console.WriteLine("Diğer = 4 TL");
        Console.Write("Hangi meyveyi satın almak istersiniz? (Elma, Armut, Çilek, Muz, Diğer)");
        string userInput2 = Console.ReadLine();
        if (userInput2 != null)
        {
            userInput2 = userInput2.ToLower();
            if (userInput2 == "elma")
            {
                Console.WriteLine($"Seçtiğiniz meyve {apple2} fiyatı: 2 TL");
            }
            else if (userInput2 == "armut")
            {
                Console.WriteLine($"Seçtiğiniz meyve {pear2} fiyatı 3 TL");
            }
            else if (userInput2 == "çilek")
            {
                Console.WriteLine($"Seçtiğiniz meyve {strawberry2} fiyatı 2 TL");
            }
            else if (userInput2 == "muz")
            {
                Console.WriteLine($"Seçtiğiniz meyve {banana2} fiyatı 3 TL");
            }
            else if (userInput2 == "diğer")
            {
                Console.WriteLine($"Seçtiğiniz meyve {other2} fiyatı 4 TL");
            }
            else
            {
                Console.WriteLine("Girdiğiniz bilgi yanlıştır.");
            }


        }
        else
        {
            Console.WriteLine("Geçersiz bilgi girilmiştir.");
        }



    }
}