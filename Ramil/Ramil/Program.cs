#region
using ConsoleApp3;

ReStudent stu1 = new ReStudent();

stu1.name = "Mahir";
stu1.surname = "Abbasov";
stu1.age = 25;

ReStudent stu2 = new()
{
    name = "Eli",
    surname = "Ekberov",
    age = 18
};

////object aid melumatlari cagirmaq.

//Console.WriteLine($"{stu1.name} {stu1.surname} {stu1.age}");

//Console.WriteLine("---------------------------");

////ferqli objektleri cagirmaq

//Console.WriteLine(stu1.name + " " + stu2.surname);

//Console.WriteLine("----------------------------------");

ReStudent[] Students = { stu1, stu2 };                                 //butun object lere catmaq ucun birinci array etmek lazimdir.

//foreach (Student item in Students)                               //ve sonra loop a salmaq lazimdir.
//{
//    Console.WriteLine($"{item.name} {item.surname} - {item.age}  ");
//    Console.WriteLine(item.GetFullData()); // Loop da method cagirmaq ve isletmek.
//}
//Console.WriteLine("-------------------------------================================");


//Console.WriteLine(stu1.GetFullName());
//                                        // Class da yaratdigimiz methodu program.cs  de cagirib isletmek.
//Console.WriteLine(stu1.GetFullData());

Search(Students, "A");
static void Search(ReStudent[] students, string searchText)
{
    var datas = Array.FindAll(students, m => m.name.Contains(searchText) || m.surname.Contains(searchText)); // 

    foreach (var item in datas)                          // Search etmek ucun method.............
    {
        Console.WriteLine(item.GetFullData());
        Console.WriteLine(item.name);
    }
}
#endregion