/* დავალება: თამაშის დაწერა, მომხმარებელს უნდა ჰქონდეს შესაძლებლობა, რომ სამჯერ სცადოს რიცხვის გამოცნობა. თუ რიცხვი მესამე ცდის შემდეგ ვერ გამოიცნო უნდა გამოვიდეს შეტყობინება
 * წაგების შესახებ, თუ გამოიცნო უნდა გამოვიდეს შეტყობინება გამარჯვების შესახებ.
 * უნდა დაუმატოთ შესაძლებლობა პროგრამას, რომ მომხმარებელმა ხელახლა დაიწყოს თამაში.
 * კომენტარი: ყველაფერი კეთდება ციკლების მეშვეობით. კერძოდ დაგვჭირდება 2 ციკლი
 */

using System;

class Lesson5Bella
{
    static void Main(string[] args)
    {
        startGame();

    }
    
    //თამაშის ეტაპები
    static void startGame() 
    {
        welcomingMessage();
        int randomNumber = getRandomNumber();
        int userNumber;
        //ციკლი რომელიც მოთამაშეს საშუალებას 3 შეცდომის დაშვების საშუალებას აძლევს, მესამე შეცდომის დაშვების შემედეგ გამოაქვს შეტყობინება თამაშის წაგების შესახებ.
        for (int counter = 1; counter <= 3; counter++)
        {
            userNumber = enterNumber();
            if (checkGame(userNumber, randomNumber, counter))
            {
                return;
            }
        }
        Console.WriteLine("GAME OVER!"); 
        //თამაშის ხელახლა დაწყება
        newChance();
    }

    //მოთამაშისთვის ინფორმაციის მიწოდება თამაშის წესების შესახებ
    static void welcomingMessage() 
    {
        Console.WriteLine("Let's start the game. I have hidden numbers for you.");
        Console.WriteLine("This number is between 0 to 20. Please, guess it.");
        Console.WriteLine("You have three attemps. Good Luck!");
    }

    //შემთხვევითი რიცხვის 0-დან 20-ის ჩათვლით
    static int getRandomNumber() 
    {
        return new Random().Next(0, 21);
    }

    //მოთამაშეს ეკითხება რიცხვს.
    static int enterNumber() 
    {
        Console.Write("Please enter a number: ");
        return Int32.Parse(Console.ReadLine());
    }

    //ამოწმებს მოთამაშის მიერ შეყვანილი რიცხვი ემთხვევა თუ არა თამაშის მიერ შემთხვევით შერჩეულ რიცხვს
    static bool checkGame(int userNumber, int randomNumber, int counter) 
    {
        if (randomNumber == userNumber)
        {
            Console.WriteLine("You have won!");
            newChance();
            return true;
        }
        else if (randomNumber > userNumber && counter != 3)
        {
            Console.WriteLine("Your number is lower than random number.");
        }
        else if (randomNumber < userNumber && counter != 3) 
        {
            Console.WriteLine("Your number is higher than random number");
        }
        return false;
    }

    //თამაშის დასრულების შემდეგ მოთამაშეს აძლევს საშუალებას თავიდან დაიწყოს თამაში ან დაასრულოს.
    static void newChance() 
    {
        Console.WriteLine();
        string playAgain = "yes";
        Console.WriteLine("Play again (yes / no)?");
        string enteredAnswer = Console.ReadLine();
        
        if (enteredAnswer == playAgain)
        {

            startGame();
            return;
        }
        else 
        {
            Console.WriteLine("Good Bye");
        }

    }

}
