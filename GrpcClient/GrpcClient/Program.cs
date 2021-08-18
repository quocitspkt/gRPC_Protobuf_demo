using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            while(true)
            {
                using var channel = GrpcChannel.ForAddress("https://localhost:5001");
                var client = new Greeter.GreeterClient(channel);
                Console.WriteLine("Select the conculation: 1. Summation,2. Subtraction, 3. Multiplication, 4. Division");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            Int32 num1;
                            Int32 num2;
                            Console.WriteLine("Enter the first number: ");
                            num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the second number: ");
                            num2 = int.Parse(Console.ReadLine());

                            var reply = await client.SumAsync(new SumRequest { Number1 = num1, Number2 = num2 });
                            Console.WriteLine("Result: " + reply.Result);
                            break;
                        }
                    case 2:
                        {
                            Int32 num1;
                            Int32 num2;
                            Console.WriteLine("Enter the first number: ");
                            num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the second number: ");
                            num2 = int.Parse(Console.ReadLine());

                            var reply = await client.SubAsync(new SubRequest { Number1 = num1, Number2 = num2 });
                            Console.WriteLine("Result: " + reply.Result);
                            break;
                        }
                    case 3:
                        {
                            Int32 num1;
                            Int32 num2;
                            Console.WriteLine("Enter the first number: ");
                            num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the second number: ");
                            num2 = int.Parse(Console.ReadLine());

                            var reply = await client.MulAsync(new MulRequest { Number1 = num1, Number2 = num2 });
                            Console.WriteLine("Result: " + reply.Result);
                            break;
                        }
                    case 4:
                        {
                            Int32 num1;
                            Int32 num2;
                            Console.WriteLine("Enter the first number: ");
                            num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the second number: ");
                            num2 = int.Parse(Console.ReadLine());

                            var reply = await client.DivAsync(new DivRequest { Number1 = num1, Number2 = num2 });
                            Console.WriteLine("Result: " + reply.Result);
                            break;
                        }
                    default:
                        break;
                }
                Console.ReadLine();
            }    
            
            
        }
    }
}
