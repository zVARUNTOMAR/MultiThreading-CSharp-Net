namespace MultiThreading;
class Program
{
    public static int sum = 0;
    static void Main(string[] args)
    {
        // Console.WriteLine("Main Thread Started");

        // NumberHelper nHelper = new NumberHelper(10);

        // // It is not TypeSafe
        // // ParameterizedThreadStart ptStart = new ParameterizedThreadStart(nHelper.Method1);

        // //TypeSafe
        // ThreadStart tStart = new ThreadStart(nHelper.Method1);

        // Thread t1 = new Thread(tStart){
        //     Name = "Method1 Thread"
        // };

        // ThreadStart t2Start =  Method2;

        //  Thread t2 = new Thread(t2Start){
        //     Name = "Method2 Thread"
        // };

        // //Used of Anonymous Function
        // ThreadStart t3Start = delegate() { Method3();};

        //  Thread t3 = new Thread(t3Start){
        //     Name = "Method3 Thread"
        // };

        // t1.Start();
        // //t1.Start("Varun"); // Return error as String cannot work on loop due to type safety
        // t2.Start();
        // t3.Start();

        // Console.WriteLine("Main Thread Finished");

        Thread t1 = new Thread(Addition){
            Name = "Addition"
        };

        Thread t2 = new Thread(Addition){
            Name = "Addition"
        };

        Thread t3 = new Thread(Addition){
            Name = "Addition"
        };

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("Total Sum is - "+ sum);
        Console.ReadLine();


    }

    // public static void Method2(){

    //     Console.WriteLine("Method 2 started");

    //     for (int i = 0; i <10;i++){
    //         Console.WriteLine(i);
    //     }

    //     Console.WriteLine("Method 2 finished");

    // }

    // public static void Method3(){

    //     Console.WriteLine("Method 3 started");

    //     for (int i = 0; i <10;i++){
    //         Console.WriteLine(i);
    //     }

    //     Console.WriteLine("Method 3 finished");
    // }

    public static void Addition(){
        for(int i=0;i<5000;i++){
            Interlocked.Increment(ref sum);
        }
    }
}


// public class NumberHelper{
    
//     private int _number;

//     public NumberHelper(int number){
//         _number = number;
//     }

//     public void Method1(){

//         Console.WriteLine("Method 1 started");

//         for (int i = 0; i < _number; i++) {
//             Console.WriteLine(i);
//         }

//         Console.WriteLine("Method 1 finished");
//     }
// }