using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Threading.Tasks.Dataflow;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Tu mas kostky, hrajes sam nebo proti pocitaci? \n" +
                 "Jestli sam - zmackni enter \n" +
                 " Proti pocitaci - P \n " +
                 "Jestli chces odejit - ESC");

        Random rnd = new Random();

        string ruka = "Hazis levou rukou nebo pravou? \n" +
            "Prava - P \n " +
            "Leva - L";
        string vypadlo = "Mas: ";
        string hrajes = "Hrajes dal? - Enter";
        string esc = "Chces opustit programm? - ESC.";
        string pc = "Pocitac hodil:";
      
        while (true)
        {
            // play with yourself
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine(ruka);

                 // new cycle wich started by pressing again 
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.P || key.Key == ConsoleKey.L)
                {
                   
                    while (true)
                    {
                        int cos1 = rnd.Next(1, 7);
                        int cos2 = rnd.Next(1, 7);

                        Console.Clear();
                        Console.WriteLine($"{vypadlo}{cos1}a{cos2}");
                        Console.WriteLine($"{hrajes}  {esc}");

                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.Escape)
                        {
                            return;
                        }
                        else if (key.Key == ConsoleKey.Enter)
                        {
                            continue;
                        }
                    }   
                }
            }
            // Play againist the  pc 
            else if (key.Key == ConsoleKey.P)
            {
                Console.Clear();
                Console.WriteLine(ruka);
                
                // new cycle wich started by pressing again 
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.P || key.Key == ConsoleKey.L)
                {
                    Console.Clear();
                    while (true)
                    {
                        int cos1 = rnd.Next(1, 7);
                        int cos2 = rnd.Next(1, 7);
                        int pc1 = rnd.Next(1, 7);
                        int pc2 = rnd.Next(1, 7);
                        Console.Clear();
                        Console.WriteLine($"{vypadlo} {cos1}a{cos2}");
                        Console.WriteLine($"{pc} {pc1}a{pc2}");
                        Console.WriteLine($"{hrajes} {esc}");

                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.Escape)
                        {
                            return;
                        }
                      //else if ??
                    }
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    return;
                }
            }          
        }                
    }     
}