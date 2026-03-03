namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hesen = 1300;
            int shakir = 1450;
            int pasha = 3000;
            int miragha = 1500;
            int ortamaash = (hesen + shakir + pasha + miragha) / 4;
            Console.WriteLine($"4 neferin orta maashi:{ortamaash}");
        }
    }
}
