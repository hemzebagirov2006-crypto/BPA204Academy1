namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad = "Casper";
            int qiymet = 3500;
            int endirim = 25;
            int yekunqiymet = 3500-((3500 * 25) / 100);


            Console.WriteLine($"Komputerin adi:{ad}, Qiymeti:{qiymet},Endirim faizi:{endirim},Yekun qiymet:{yekunqiymet}");
        }
    }
}
