namespace TryCatch
{
    public class TryCatchBlock
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number.");
                var a = Convert.ToInt32(Console.ReadLine());
                var result = Math.Sqrt(a);
                Console.WriteLine(result);

                 if( a < 0)
                {
                    throw new Exception("Number must be positive");
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine($"Invalid format. {e.Message}");
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
        }
    }
}