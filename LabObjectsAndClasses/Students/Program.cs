//поставяме using-и, ако имаме нужда

//поставяме си допълнителния / помощния клас

//описвам всеки един студент
public class Student
{
    //част 1: характеристики -> описват чрез properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }

    //default конструктор -> създава празен обект: new Student()

    //custom конструктор -> създаваме специфични обекти от класа
    public Student(string firstName, string lastName, int age, string homeTown)
    {
        //нов празен обект
        //FirstName = null
        //LastName = null
        //Age = 0
        //HomeTown = null

        FirstName = firstName;
        LastName = lastName;
        Age = age;
        HomeTown = homeTown;
    }

}

//поставяме логиката за изпълнение на задачата
public class Program
{
    public static void Main(string[] args)
    {
        //ето тук поставяме логиката на изпълнение на задачата
        //логиката на изпълнение на задачата
        List<Student> studentsList = new List<Student>();

        string input = Console.ReadLine();

        //повтарям: въвеждам входни данни
        //While
        //спирам: входни данни == "end"
        //продължавам: входни данни != "end"

        while (input != "end")
        {
            //входни данни: input = "John Smith 15 Sofia".Split(" ")
            string[] studentData = input.Split(" ");
            //studentData = ["John", "Smith", "15", "Sofia"]

            string firstName = studentData[0];      //"John"
            string lastName = studentData[1];       //"Smith"
            int age = int.Parse(studentData[2]);    //"15" -> parse -> 15
            string town = studentData[3];           //"Sofia"

            //създаваме студент спрямо данните
            Student student = new Student(firstName, lastName, age, town);

            //съхраним създадения студент
            studentsList.Add(student);


            input = Console.ReadLine();
        }

        //списък с обекти от клас Student

        string searchedCity = Console.ReadLine(); //търся всички студенти от този град

        foreach (Student student in studentsList)
        {
            if (student.HomeTown == searchedCity)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

    }
}