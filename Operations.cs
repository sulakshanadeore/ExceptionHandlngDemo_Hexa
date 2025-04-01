namespace LogicLibraryForExceptionHandling
{
    public class Operations
    {

        public int Divide(int i, int j)
        {
            int ans = 0;
            try
            {
                 ans = i / j;
            }
            catch (DivideByZeroException ex)
            {

                throw new DivideByZeroException("This is a invalid division.... Please check denominator");
            }
            
            return ans;
        }
    }
}
