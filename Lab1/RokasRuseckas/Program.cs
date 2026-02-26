namespace Uzduotis4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();

            group.Add(new Student(1, "Jonas", "Jonas@gmail.com"));
            group.Add(new Student(2, "Tadas", "Tadas@gmail.com"));

            // paieska pagal id (rastas)
            var foundById = group.FindById(2);

            if (foundById != null)
                Console.WriteLine("Rasta pagal ID: " + foundById);
            else
                Console.WriteLine("Studentas su tokiu ID nerastas");

            // paieska pagal id (nerastas)
            var notFoundById = group.FindById(99);

            if (notFoundById != null)
                Console.WriteLine("Rasta pagal ID: " + notFoundById);
            else
                Console.WriteLine("Studentas su tokiu ID nerastas.");

            // paieska pagal email (rastas)
            var foundByEmail = group.FindByEmail("JONAS@GMAIL.com");

            if (foundByEmail != null)
                Console.WriteLine("Rasta pagal email: " + foundByEmail);
            else
                Console.WriteLine("Studentas su tokiu email nerastas");

            // paieska pagal email (nerastas)
            var notFoundByEmail = group.FindByEmail("test@test.com");

            if (notFoundByEmail != null)
                Console.WriteLine("Rasta pagal email: " + notFoundByEmail);
            else
                Console.WriteLine("Studentas su tokiu email nerastas");

        }
    }
}
