using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            loopingFunction();
           
            
        }

        public static void loopingFunction()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i + " Sheep");
                System.Threading.Thread.Sleep(1000);
               
                if (i == 5) 
                {
                    Console.WriteLine("Press Enter to count sheep");
                    string enter = Console.ReadLine();
                   
                    if (enter == enter) 
                    {
                        
                        for (i += 1; i <= 10;  i++)
                        {
                            Console.WriteLine(i+" Sheep");
                            System.Threading.Thread.Sleep(1000);
                            if(i == 10)
                            {
                                Console.WriteLine("Press Enter to continue counting");
                                string enter1 = Console.ReadLine();
                                if(enter1 == enter)
                                {
                                    for (i += 1; i <= 20; i++)
                                    {
                                        Console.WriteLine(i + " Sheep");
                                        System.Threading.Thread.Sleep(1000);
                                        if( i == 20)
                                        {
                                            Console.WriteLine("Pag turog dn animal!!");
                                        }
                                    }

                                }
                            }
                          
                        }
                    }
                }
            }
        }
        
    }
}