using System;
namespace Lab1
{
    public class StudentProfile
    {
        public string Vardas { get; set; } = "Tomas";
        public string Pavarde { get; set; } = "Seikauskas";
        public string Grupe { get; set; } = "PS-5";
        public DateOnly PaskaitosData { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public string ToReadmeBlock(int taskNo)
        {
            return $"# Užduotis {taskNo}\n\nStudentas: {Vardas} {Pavarde}\nGrupė: {Grupe}";
        }

    }
}

