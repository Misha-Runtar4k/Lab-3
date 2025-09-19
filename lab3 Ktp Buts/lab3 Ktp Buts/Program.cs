namespace _Lab3_Ktp_Buts
{
    class example2

    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть значення x: ");
            double.TryParse(Console.ReadLine(), out double x);
           
            
            {
                double y = Math.Cos(2 * x);
                double w = Math.Cos(2 * x) - Math.Sin(x);

                Console.WriteLine($"y = cos(2x) = {Math.Round(y, 5)}");
                Console.WriteLine($"w = cos(2x) - sin(x) = {Math.Round(w, 5)}");
            }
             

        }
    }
}
