using System;
using System.Threading.Tasks;
namespace Async{
class Program
{
    static async Task DownloadFileAsync()
    {
        Console.WriteLine("Download Started");
        await Task.Delay(3000);
        Console.WriteLine("Download Completed");
    }

    static async Task Main()
    {
        Console.WriteLine("Process Started");

        await DownloadFileAsync();

        Console.WriteLine("Processing Data");
        Console.WriteLine("Sending Email");
    }
}
}