namespace counter_with_columns
{
class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "counter";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please insert a number (positive and integer): ");
            try
            {
                UInt64 n = Convert.ToUInt64(Console.ReadLine());
                Console.WriteLine("Insert number of colums: ");
                UInt16 columns = Convert.ToUInt16(Console.ReadLine());
                Console.Clear();
                for (UInt64 i = 0; i <= n; i++)
                {

                    if (i % columns == 0 && i!=0)
                    {
                        Console.Write("\n"+i+"  ");
                    }
                    else
                    {
                        Console.Write(i + "  ");
                    }
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error: The format of the number must be an Integer 
                +" and also a positive number please check it");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: The format is wrong " +
                    " you must insert a number nor a letter or symbol" +
                    " and the number must be positive and integer");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
                Console.WriteLine(ex);
            }
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();