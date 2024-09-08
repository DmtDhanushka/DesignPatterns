// Builder Example usage
using DesignPatterns;

class Program
{
    static void Main(string[] args)
    {
        // Building a custom computer using the builder pattern
        // Computer 2
        Computer myComputer = new Computer.ComputerBuilder("Intel i9", "NVIDIA RTX 3080", 32, 1024)
            .AddWiFi(true)
            .AddBluetooth(true)
            .Build();

        Console.WriteLine(myComputer);


        Console.WriteLine("--------------------");


        // Building a custom computer using the builder pattern
        // Computer 2
        Computer myComputer2 = new Computer.ComputerBuilder("Intel i7", "NVIDIA RTX 3080", 32, 1024)
            .AddWiFi(true)
            .Build();

        Console.WriteLine(myComputer2);


        // If you don't use the pattern you will end up with longer lists of parameters.
        // Computer computer3 = new Computer("Intel i7", "NVIDIA RTX 3080", 32, 1024, true, true)

    }
}
