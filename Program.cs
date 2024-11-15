class Program
{
    static void Main(string[] args)
    {
        string filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "resources", "filter.txt");
        if (File.Exists(filename))
        {
            string content = File.ReadAllText(filename);
            Console.WriteLine(content);
        }
        Console.WriteLine(filename);
    }

}
