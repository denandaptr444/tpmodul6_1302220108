using tpmodul6_1302220108;


namespace tpmodul6_1302220108;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Masukkan judul video: ");
        string title = Console.ReadLine();

        var video = new SayaTubeVideo(title);

        Console.Write("Masukkan jumlah penambahan play count: ");
        int increaseAmount = int.Parse(Console.ReadLine());

        video.IncreasePlayCount(increaseAmount);

        Console.Write("Masukkan Deskripsi: ");
        string customOutput = Console.ReadLine();

        video.PrintVideoDetails();
    }
}