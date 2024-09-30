namespace CovarianceAndContravariance
{
    internal class Program
    {
        delegate Message MessageBuilder(string test);
        static void Main(string[] args)
        {

            MessageBuilder messageBuilder = WriteEmailMessage;
            Message message = messageBuilder("Hello");
            message.Print();

        }
        static EmailMessage WriteEmailMessage(string text) => new EmailMessage(text);  


    }
}
