namespace Graphics2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Window window = new(1200, 900, "Graphics2"))
            {
                window.Run();
            }
        }
    }
}