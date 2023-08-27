namespace MultiThreading;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main Thread Started");

        Thread t1 = new Thread(Method1){
            Name = "Method1 Thread"
        };

        ThreadStart 

         Thread t2 = new Thread(Method2){
            Name = "Method2 Thread"
        };

         Thread t3 = new Thread(Method3){
            Name = "Method3 Thread"
        };

        t1.Start();
        t2.Start();
        t3.Start();

        Console.WriteLine("Main Thread Finished");
    }

    public static void Method1(){

        Console.WriteLine("Method 1 started");

        for (int i = 0; i <10;i++){
            Console.WriteLine(i);
        }

        Console.WriteLine("Method 1 finished");

    }

     public static void Method2(){

        Console.WriteLine("Method 2 started");

        for (int i = 0; i <10;i++){
            Console.WriteLine(i);
        }

        Console.WriteLine("Method 2 finished");

    }

     public static void Method3(){

        Console.WriteLine("Method 3 started");

        for (int i = 0; i <10;i++){
            Console.WriteLine(i);
        }

        Console.WriteLine("Method 3 finished");

    }
}
