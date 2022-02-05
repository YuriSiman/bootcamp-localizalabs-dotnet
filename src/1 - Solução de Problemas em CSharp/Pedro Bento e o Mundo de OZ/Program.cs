class Program
{

    static void Main(string[] args)
    {
        List<string> joias = new List<string>();

        do
        {
            string joia = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(joia))
            {
                joias.Add(joia);
            }
            else
            {
                break;
            }

        } while (true);

        IEnumerable<string> joiasDistinta = joias.Distinct();
        Console.WriteLine(joiasDistinta.Count());
    }
}