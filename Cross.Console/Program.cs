using System;
namespace Cross.Consol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new bool?[9];
            var player = true;
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(2, 2 + i);
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("#");
                }
                
            }
            Console.WriteLine();
            
            for (int l = 0; l < 9; l++)
            {
                var read = Console.ReadLine();
                var index = int.Parse(read);
                nums[index] = player;
                player = !player;
                for (int i = 0; i < 3; i++)
                {
                    Console.SetCursorPosition(2, 2 + i);
                    for (int j = 0; j < 3; j++)
                    {
                        
                        var cindex = i * 3 + j;
                        var cells = nums[cindex] switch
                        {
                            true => "x",
                            false => "0",
                            _ => "#"
                        };
                        Console.Write(cells);
                    }
                    
                }
                Console.WriteLine();
            }


        }
    }
}
