internal class Program
{
    private static void Main(string[] args)
    {
        string[] pallets = [ "B14", "A11", "B12", "A13" ];
        Console.WriteLine("");

        Array.Clear(pallets, 0, 2);
        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        
    }
}