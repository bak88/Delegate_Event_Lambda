using Delegate;

namespace Delegate_Event_Lambda
{
    delegate void Message();
    delegate int Operation(int x, int y);
    internal class Program
    {

        static void Main(string[] args)
        {
            //Message message;
            //message = new Message(Hi);
            //message();




            //Message? message1 = Welcome.Print;
            //message1();
            //message1 -= Welcome.Print;
            //if (message1 is not null) message1();




            //Hello hello = new Hello();
            //Message? message2 = new Hello().Display;
            //message2 += hello.HowAreYou;
            //message2();
            //message2 -= hello.HowAreYou;
            //message2();





            //Message ms1 = new Hello().Display;
            //Message ms2 = new Hello().HowAreYou;
            //Message ms3 = ms1 + ms2;
            //ms3();




            //Message mes1 = new Hello().Display;
            //mes1.Invoke();
            //Operation? operation = Add;
            //Console.WriteLine(operation.Invoke(3, 4));
            //operation -= Add;
            //Console.WriteLine(operation?.Invoke(3, 4));
            //Message? mes2 = null;
            //mes2?.Invoke();



            //Operation op = Add;
            //op += Subtract;
            //op += Multiply;
            //Console.WriteLine(op.Invoke(5, 5));



            //DoOperation(5, 4, Add);
            //DoOperation(5, 4, Multiply);
            //DoOperation(5, 4, Subtract);





            Operation op1 = SelectOperation(OperationType.Add);
            Console.WriteLine(op1.Invoke(4, 4));

            op1 = SelectOperation(OperationType.Subtract);
            Console.WriteLine(op1.Invoke(3,4));


            

        }
        static void Hi() => Console.WriteLine("Hi, you the best");
        static void DoOperation(int x, int y, Operation op) => Console.WriteLine(op.Invoke(x, y));
        static int Add (int x, int y) => x + y;
        static int Subtract (int x, int y) => x - y;
        static int Multiply (int x, int y) => x * y;

        static Operation SelectOperation(OperationType operationType)
        {
            switch (operationType)
            { 
                case OperationType.Add: return Add;
                case OperationType.Subtract: return Subtract;
                default: return Multiply;
            }

        }

    }
}
