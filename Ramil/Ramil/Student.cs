

namespace ConsoleApp3
{
    internal class ReStudent
    {
        public string name;
        public string surname;
        public int age;

        public string GetFullName()
        {
            return name + " " + surname;
        }
        public string GetFullData()
        {
            return $"name: {name} surname :{surname} age:{age}";
        }
    }
}
