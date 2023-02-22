/* 1. შევქმნათ სამი ცვლადი (x, z, y). მივანიჭოთ მნიშვნელობები. გამოვიყვანოთ კონსოლში: x+z*y=ჯამი; მაგ. 4,5,10-ის შედეგია 54.
 * 2. პროგრამა სთავაზობს მომხმარებელს შეიყვანოს სახელი (), გვარი (), ასაკი (), სიმაღლე () და წონა (). შევინახოთ ეს მონაცემები შესაბამისი ტიპის ცვლადებში. გამოვიყვანოთ მთალი ინფორმაცია კონსოლში.
 * 3. დაწერეთ კოდი, რომელიც ითვლის ადამიანის BMI (Body Mass Index).
 * 4. კონსოლში ნახატის დახატვა.
 */
class MyMain
{
    static void Main(string[] args)
    {   //დავალება #1: ცვლადების შექმნა და გამოთვლა:
        Console.Write("Enter numberX: ");
        int numberX = Int32.Parse(Console.ReadLine());
        Console.Write("Enter numberY: ");
        int numberY = Int32.Parse(Console.ReadLine());
        Console.Write("Enter numberZ: ");
        int numberZ = Int32.Parse(Console.ReadLine());
        int sum1 = numberX + (numberY * numberZ);
        Console.WriteLine("Unswer is:" + sum1);

        //დავალება#2: მომხმარებლის ინფორმაცია: სახელი (), გვარი (), ასაკი (), სიმაღლე () და წონა ().
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Please enter your surname: ");
        string surname = Console.ReadLine();
        Console.Write("Please enter your age: ");
        int age = Int32.Parse(Console.ReadLine());
        Console.Write("Please enter your height: ");
        float height = float.Parse(Console.ReadLine());
        Console.Write("Please enter your weight: ");
        float weight = float.Parse(Console.ReadLine());

        //გამოაქვს სრული ინფორმაცია მომხმარებელზე:
        Console.WriteLine(name + " " + surname);
        Console.WriteLine("Your age is: " + age);
        Console.WriteLine("Your height is: " + height);
        Console.WriteLine("Your weight is: " + weight);

        //დავალება#3: ადამიანის BMI (Body Mass Index) გამოთვლა:
        float sum2 = weight / ((height / 100) * (height / 100));
        Console.WriteLine("Your BMI equals: " + sum2);

        //დავალება#3: ნახატი
        Console.WriteLine("    |     |    ");
        Console.WriteLine(" 1  |  2  |  3 ");
        Console.WriteLine("    |     |    ");
        Console.WriteLine("_______________");
        Console.WriteLine("    |     |    ");
        Console.WriteLine(" 4  |  5  |  6 ");
        Console.WriteLine("    |     |    ");
        Console.WriteLine("_______________");
        Console.WriteLine("    |     |    ");
        Console.WriteLine(" 7  |  8  |  9 ");
        Console.WriteLine("    |     |    ");

    }
}