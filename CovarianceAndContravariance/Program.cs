using System.Text;
using System.Threading.Channels;

namespace CovarianceAndContravariance
{
    internal class Program
    {
        delegate Message MessageBuilder(string test);
        delegate void EmailReceiver(EmailMessage message);
        delegate T MessageBuilder<out T>(string message);
        delegate void MessReceiver<in T>(T message);
        static void Main(string[] args)
        {

            //MessageBuilder messageBuilder = WriteEmailMessage;
            //Message message = messageBuilder("Hello");
            //message.Print();





            //EmailReceiver emailReceiver = ReceiveMessage;
            //emailReceiver(new EmailMessage("test"));



            //MessageBuilder<Message> message = messageBuilder;
            //Message mes = message.Invoke("LOL");
            //mes.Print();

            MessReceiver<Message> messReceiver = (Message message) => message.Print();

            MessReceiver<EmailMessage> mr = messReceiver;
            mr.Invoke(new EmailMessage("werwer"));
            






        }
        static EmailMessage WriteEmailMessage(string text) => new EmailMessage(text);
        static void ReceiveMessage(Message message) => message.Print();

        static MessageBuilder<EmailMessage> messageBuilder = (string text) => new EmailMessage(text);



    }
}
