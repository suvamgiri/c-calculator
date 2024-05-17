using System;

class Program
{
    public static void Main(string[] args)
    {

        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());


        Console.Write("what is the ooperarot %,* ,/ ,-: ");
        string ooperarot = Console.ReadLine();

        Console.Write("Enter a number second:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        try
        {

            switch (ooperarot)
            {
                case "%":
                    Console.WriteLine("the mod of the number is" + "" + num % num2);
                    break;
                case "*":
                    Console.WriteLine("the multiplication of the number is" + "" + num * num2);
                    break;
                case "/":
                    Console.WriteLine("the divide of the number is" + " " + num / num2);
                    break;
                case "-":
                    Console.WriteLine("the subtract of the number is " + (num - num2));
                    break;
                case "++":
                    Console.WriteLine("the add of the number is " + (num + num2));
                    break;
                default:
                    Console.WriteLine("the ooperarot is not valid");
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }



    }
}
