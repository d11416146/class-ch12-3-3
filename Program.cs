namespace _12_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 2;
                int c;
                if (b > 10)
                {
                    throw new MyExce("值大於10");
                }
                if (a > 10)
                {
                    throw new MyExce("A值大於10");
                }
                c = a / b;
                string[] names = new string[5];
                string id = names[4];
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            catch (MyExce ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            finally
            {
                Console.WriteLine("END");
            }
        }
    }
}
