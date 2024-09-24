namespace _042_КлючевоеСловоREF
{

    // Ключевое слово ref

    // При работе с ссылочным типом при передаче его в качестве параметров
    // мы можем изменять его данные, но ничего не можем сделать с ссылкой

    // Когда мы передаем с ключевым словом ref мы можем изменять не только данные, но и ссылку

    internal class КлючевоеСловоREF
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 5, 10 };

            Bar(myArray);

            BarRef(ref myArray);
        }

        static void Bar(int[] arr) 
        {
            arr[0] = 25;
        }

        static void BarRef(ref int[] array)
        {
            array = null;
        }
    }
}
