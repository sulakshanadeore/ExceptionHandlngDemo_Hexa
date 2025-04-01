using LogicLibraryForExceptionHandling;
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            Operations o = new Operations();
           int ans= o.Divide(number,secondnumber);
            //int ans = number / secondnumber;
            Console.WriteLine(ans);


        }
        catch (FormatException ex)
        {
            Console.WriteLine("Pls enter a number as the input");
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
            

        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Enter a non zero denominator");
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);

        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Pls enter a number in the range of Integer");
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }

      
        

        

    }
}