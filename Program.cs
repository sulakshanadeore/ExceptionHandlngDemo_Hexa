using LogicLibraryForExceptionHandling;
internal class Program
{
    private static void Main(string[] args)
    {
        //BasicsOfExceptionHandling();

        try
        {
            List<Student> students = new List<Student>();
            students.Add(new Student {Rollno=1,StudName="Alka" });
            students.Add(new Student { Rollno = 2, StudName = "Ulka" });
            students.Add(new Student { Rollno = 3, StudName = "Rekka" });
            students.Add(new Student { Rollno = 4, StudName = "Seema" });
            students.Add(new Student { Rollno = 5, StudName = "Ankita" });
           
            Console.WriteLine("Enter a student rollno to search");
            int rollno=Convert.ToInt32(Console.ReadLine());

         
            bool flag = false;
            for (int i = 0; i < students.Count; i++)
            {


                if (students[i].Rollno == rollno)
                {
                    Console.WriteLine(students[i].Rollno);
                    Console.WriteLine(students[i].StudName);
                    flag=true;
                    break;
                }

                
            }
            if (flag == false)
            {
                throw new StudentNotFoundException("This is a invalid Rollno....Pls recheck...");

            }


            



        }
        catch (StudentNotFoundException ex)
        {

            Console.WriteLine(ex.Message);
        }

    }

    private static void BasicsOfExceptionHandling()
    {
        try
        {

            Operations o = new Operations();
            string username = null;
            o.GreetUser(username);

            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            int secondnumber = Convert.ToInt32(Console.ReadLine());

            int ans = o.Divide(number, secondnumber);
            //int ans = number / secondnumber;
            Console.WriteLine(ans);


        }
        catch (FormatException ex)
        {
            Console.WriteLine("Pls enter a number as the input");
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);


        }
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("Enter a non zero denominator");
        //    Console.WriteLine(ex.Message);
        //    Console.WriteLine(ex.StackTrace);

        //}
        catch (OverflowException ex)
        {
            Console.WriteLine("Pls enter a number in the range of Integer");
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);

        }
        finally
        {
            Console.WriteLine("Finally executed.........");

        }
    }
}