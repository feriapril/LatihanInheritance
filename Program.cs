namespace baru.LatihanInheritance
{
    public class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person("Dilan", 29);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Jono", 31, "3123", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("Ghema", 21, "2314", "Diansastro@gmail.com");
            student.GetNameAndAge();
        }
    }
}