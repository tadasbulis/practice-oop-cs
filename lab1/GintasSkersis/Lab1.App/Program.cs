public class StudentProfile
{
    public string Vardas { get; set; } = "";
    public string Pavarde { get; set; } = "";
    public string Grupe { get; set; } = "";

    public DateOnly PaskaitosData { get; set; }

    public string toReadmeBlock(int taskNo)
    {
        return $"## {taskNo} Užduotis\n" +
               $"**Vardas:** {Vardas}\n" +
               $"**Pavardė:** {Pavarde}\n" +
               $"**Grupė:** {Grupe}\n" +
               $"**Paskaitos data:** {PaskaitosData:yyyy-MM-dd}\n";
    }

    public static void Main(string[] args)
    {
        Random random = new Random();
        bool allowChallenge = args.Contains("--challenge");
        int max = allowChallenge ? 5 : 4;
        int task = random.Next(1, max + 1);

        if (task == 5)
        {
            int fallback = random.Next(1, 5);
        }

        var student = new StudentProfile
        {
            Vardas = "Jonas",
            Pavarde = "Jonaitis",
            Grupe = "1A",
            PaskaitosData = DateOnly.FromDateTime(DateTime.Now)
        };

        string readmeContent = student.toReadmeBlock(1);
        System.IO.File.WriteAllText("README.md", readmeContent);
    }
}