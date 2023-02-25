/* დავალება: თამაშის დაწერა, მომხმარებელს უნდა ჰქონდეს შესაძლებლობა, რომ სამჯერ სცადოს რიცხვის გამოცნობა. თუ რიცხვი მესამე ცდის შემდეგ ვერ გამოიცნო უნდა გამოვიდეს შეტყობინება
 * წაგების შესახებ, თუ გამოიცნო უნდა გამოვიდეს შეტყობინება გამარჯვების შესახებ.
 * უნდა დაუმატოთ შესაძლებლობა პროგრამას, რომ მომხმარებელმა ხელახლა დაიწყოს თამაში.
 * კომენტარი: ყველაფერი კეთდება ციკლების მეშვეობით. კერძოდ დაგვჭირდება 2 ციკლი
 */

class Lesson5Bella
{
    static void Main(string[] args)
    {
        welcomingMessage();
        startGame();
    }
    //მომხმარებლისთვის ინფორმაციის მიწოდება თამაშის ჟანრის შესახებ
    static void welcomingMessage() 
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Welcome to the game " + name);
        Console.WriteLine("I have hidden numbers for you.");
        Console.WriteLine("This number is between 0 to 20. Please, guess it.");
        Console.WriteLine("You have three attemps.");
        Console.WriteLine("Let's start the game. Good Luck! :)");
    }
    static void startGame() 
    {
        int randomNumber = getRandomNumber();
        int usersNumber = enterNumber();

        //მომხმარებლისთვის შეტყობინების გამოტანა თამაშის შედეგის შესახებ.
        if (randomNumber == usersNumber)
        {
            Console.WriteLine("Congratulation, You have Won");
        }
        else if (randomNumber > usersNumber)
        {
            Console.WriteLine("Your number is lower than random number.");
        }
        else if (randomNumber < usersNumber) 
        {
            Console.WriteLine("Your number is higher than random number.");
        }
    }
    //თამაშის შემთხვევითი რიცხვების დიაპაზონი
    static int getRandomNumber() 
    {
        return new Random().Next(0,21);
    }
    //მომხმარებლის მიერ რიცხვის შერჩევა
    static int enterNumber() 
    {
        Console.WriteLine("Please, enter a number: ");
        return Int32.Parse(Console.ReadLine());
    }
}
