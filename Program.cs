
using System;


public class Program
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Type Start to Math");
       String cont = Console.ReadLine();
       int x = 0;
       int y = 0;
       while(cont.ToLower().Equals("start")||cont.ToLower().Equals("cont")){
        Console.WriteLine("Give me 2 seperate numbers you want to Math with\nPS: on different lines. NOTHING BESIDES NUMBERS!");
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());
        Console.WriteLine("What do you want to Math\n\"add\" = Addition\n\"sub\" = Subtration\n\"tim\" = Multiplication\n\"div\" = Division\"mod\" = Divide with a Remainder");
        cont = Console.ReadLine();
        if(cont.ToLower().Equals("add"))
         Console.WriteLine(x + " + " + y + " = " + (x+y));
        else if(cont.ToLower().Equals("sub"))
         Console.WriteLine(x + " - " + y + " = " + (x+y));
        else if(cont.ToLower().Equals("tim"))
         Console.WriteLine(x + " x " + y + " = " + (x*y));
        else if(cont.ToLower().Equals("div"))
         Console.WriteLine(x + " ÷ " + y + " = " + (x.ToDouble()/y.ToDouble()));
        else if(cont.ToLower().Equals("mod"))
         Console.WriteLine(x + " ÷ " + )
        else
        cont = Console.ReadLine();
       }
    }
}
