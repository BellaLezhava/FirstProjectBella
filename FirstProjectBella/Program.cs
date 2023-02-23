/* 1. შევქმნათ მეთოდი, რომელსაც გადავცემთ ორ სრულ რიცხვს. მეთოდმა უნდა დააბრუნოს ორი რიცხვის ჯამი. გამოვიყვანოთ ეს ჯამი შესვლის წერტილის მეთოდის მეშვეობით კონსოლში.
 * 2. შევქმნათ მეთოდი. ვთხოვოთ მომხმარებელს შეიყვანოს ოთხი ნებისმიეირ ტიპის რიცხვი (ანუ არა მხოლოდ ინტეჯერი). მეთოდის ფარგლებში უნდა მოიძებნოს ამ ოთხი რიცხვიდან ყველაზე 
 * დიდი და ყველაზე პატარა. მეთოდმა უნდა გამოიყვანოს კონსოლში ეს ორი რიცხვი.
 * 3. შევქმნათ მეთოდი, რომელმაც უნდა მიიღოს მეორე მეთოდის მეშვეობით მომხმარებლისგან ხილის დასახელება. ამ ხილის დასახელების მიღების შემდეგ switch ოპერატორის მეშვეობით 
 * ნახოს თუ რომელი ხილია და გამოიყვანოს შესაბამისი შეტყობინება. თუ ასეთი ხილი არ მოიძებნა, ამის შესახებაც მომხმარებელმა უნდა მიიღოს შეტყობინება. ხილი: apple, watermelon, 
 * melon, cherry, straweberry
 */
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Lesson4Bella
{
    static void Main(string[] args)
    {
        //დავალება 1:
        Console.WriteLine(getSum(10,7));
        Console.WriteLine();
        //დავალება 2:
        getCompare();
        Console.WriteLine();
        //დავალება 3:
        getFruite();

    }

    //დავალება 1. შევქმნათ მეთოდი, რომელსაც გადავცემთ ორ სრულ რიცხვს. მეთოდმა უნდა დააბრუნოს ორი რიცხვის ჯამი. გამოვიყვანოთ ეს ჯამი შესვლის წერტილის მეთოდის მეშვეობით კონსოლში.
    static int getSum(int x, int y) 
    {
        return (x + y);
    }
    /*დავალება 2. შევქმნათ მეთოდი. ვთხოვოთ მომხმარებელს შეიყვანოს ოთხი ნებისმიეირ ტიპის რიცხვი (ანუ არა მხოლოდ ინტეჯერი). მეთოდის ფარგლებში უნდა მოიძებნოს ამ ოთხი რიცხვიდან ყველაზე 
     * დიდი და ყველაზე პატარა.მეთოდმა უნდა გამოიყვანოს კონსოლში ეს ორი რიცხვი.
     */
    static void getCompare() 
    {
        //მომხმარებლის მიერ შესაყვანი ინფორმაცია: ოთხი ნებისმიეირ ტიპის რიცხვი
        Console.Write("Please enter 4 numbers: ");
        Console.WriteLine();
        double w = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double z = double.Parse(Console.ReadLine());

        //ოთხი რიცხვიდან ყველაზე დიდი რიცხვის პოვნა
        if (w > x && w > y && w > z)
        {
            Console.WriteLine("Bigger number is: " + w);
        }
        else if (x > y && x > z)
        {
            Console.WriteLine("Bigger number is: " + x);
        }
        else if (y > z)
        {
            Console.WriteLine("Bigger number is: " + y);
        }
        else
        {   
        Console.WriteLine("Bigger number is: " + z);
        }

        //ოთხი რიცხვიდან ყველაზე დიდი რიცხვის პოვნა
        if (w < x && w < y && w < z)
        {
        Console.WriteLine("Smallest number is: " + w);
        }
        else if (x < y && x < z)
        {
        Console.WriteLine("Smallest number is: " + x);
        }
        else if (y < z)
        {
        Console.WriteLine("Smallest number is: " + y);
        }
        else
        {
        Console.WriteLine("Smallest number is: " + z);
        }

    }
    /*3. შევქმნათ მეთოდი, რომელმაც უნდა მიიღოს მეორე მეთოდის მეშვეობით მომხმარებლისგან ხილის დასახელება. ამ ხილის დასახელების მიღების შემდეგ switch ოპერატორის მეშვეობით 
     * ნახოს თუ რომელი ხილია და გამოიყვანოს შესაბამისი შეტყობინება. თუ ასეთი ხილი არ მოიძებნა, ამის შესახებაც მომხმარებელმა უნდა მიიღოს შეტყობინება. ხილი: apple, watermelon, 
     * melon, cherry, straweberry
     * */
    static void getFruite() 
    {
        //ხილის დასახელებების შექმნა
        string apple = "Apple";
        string watermalon = "Watermalon";
        string melon = "Melon";
        string cherry = "Cherry";
        string straweberry = "Straweberry";

        //მომხმარებლისთვის ინფორმაცია მოთხოვნილი ხილის შესახებ
        Console.WriteLine("Please enter the fruit name you want: ");
        string enteredFruit = Console.ReadLine();
        if (enteredFruit.Equals(apple) || enteredFruit.Equals(watermalon) || enteredFruit.Equals(melon) || enteredFruit.Equals(cherry) || enteredFruit.Equals(straweberry))
        {
            Console.WriteLine("Yes, we have that fruite.");
        }
        else 
        {
            Console.WriteLine("We don't have that fruite");
        }
    }
}
