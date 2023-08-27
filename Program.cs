namespace MultiThreading;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main Thread Started");

        // It is not TypeSafe
        ParameterizedThreadStart ptStart = new ParameterizedThreadStart(Method1);

        Thread t1 = new Thread(ptStart){
            Name = "Method1 Thread"
        };

        ThreadStart t2Start =  Method2;

         Thread t2 = new Thread(t2Start){
            Name = "Method2 Thread"
        };

        //Used of Anonymous Function
        ThreadStart t3Start = delegate() { Method3();};

         Thread t3 = new Thread(t3Start){
            Name = "Method3 Thread"
        };

        t1.Start(10);
        t1.Start("Varun"); // Return error as String cannot work on loop due to type safety
        t2.Start();
        t3.Start();

        Console.WriteLine("Main Thread Finished");
    }

    public static void Method1(object o){

        Console.WriteLine("Method 1 started");

        int max = (int)o;

        for (int i = 0; i < max; i++) {
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
