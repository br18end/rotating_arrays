namespace rotating_arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rotating arrays game!");

            rotLeft();
        }

        private static void rotLeft()
        {
            try
            {
                Console.WriteLine("Enter number of elements");
                var n = int.Parse(Console.ReadLine());
                Console.WriteLine($"n = {n}\n");

                Console.WriteLine("Enter number of rotations");
                var d = int.Parse(Console.ReadLine());
                Console.WriteLine($"d = {d}");

                var array = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("\nEnter a number");
                    var temp = int.Parse(Console.ReadLine());
                    array[i] = temp;
                }

                Console.WriteLine("\nArray before");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"[{i}] = {array[i]}");

                }

                Console.WriteLine("\nRotating array\n");

                for (int i = 0; i < d; i++)
                {
                    var temp = array[0];
                    for (int j = 0; j < array.Length; j++)
                    {
                        var next = j + 1;
                        if (next < array.Length)
                        {
                            array[j] = array[next];
                        }
                        else
                        {
                            array[j] = temp;
                        }
                    }
                }

                Console.WriteLine("Array after");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"[{i}] = {array[i]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}