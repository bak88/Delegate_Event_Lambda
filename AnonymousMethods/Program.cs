namespace AnonymousMethods
{
    internal class Program
    {
        delegate void MessageHandler(string message);
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {

            //MessageHandler handler = delegate (string message)
            //{
            //    Console.WriteLine(message);
            //};
            //handler("Hi");

            //ShowMessage("Hello", delegate (string mes)
            //{
            //    Console.WriteLine(mes);
            //});

            //ShowMessage("Hello", handler);






            //MessageHandler messageHandler = delegate
            //{
            //    Console.WriteLine("Anonyms method");
            //};
            //messageHandler("Hello");



            int z = 9;
            Operation operation = delegate (int x, int y)
            {
                return x + y + z;
            };            
            Console.WriteLine(operation.Invoke(4,5));

        }

        static void ShowMessage(string message, MessageHandler hand)
        {
            hand(message);
        }
    }
}
