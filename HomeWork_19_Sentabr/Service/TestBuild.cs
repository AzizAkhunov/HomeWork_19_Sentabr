using System.Threading.Tasks;
using Vazifa19_09_2023.Service;

namespace HomeWork_19_Sentabr.Service
{
    public static class TestBuild
    {
        public static void Build_Question()
        {
            Console.WriteLine("Fan Nomi: ");
            string lessonName = Console.ReadLine();
            Console.WriteLine("Savol kiriting: ");
            string testName = Console.ReadLine();
            Console.WriteLine("Variant A: ");
            string a = Console.ReadLine();
            Console.WriteLine("Variant B: ");
            string b = Console.ReadLine();
            Console.WriteLine("Variant C: ");
            string c = Console.ReadLine();
            Console.WriteLine("Variant D: ");
            string d = Console.ReadLine();
            Console.WriteLine("Tug'ri variantni kiriting (A,B,C,D): ");
            string current = Console.ReadLine();
            var test = new Test(lessonName,testName,a,b,c,d,current);
        }

        public static void Generation()
        {
            Console.WriteLine("Qaysi fan?: ");
            string lessonName = Console.ReadLine();

            Console.WriteLine("Students Number: ");
            int studentsNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Test Number: ");
            int testsNumber = int.Parse(Console.ReadLine());
            FileWriter.Generatsion(lessonName,studentsNumber,testsNumber);
        }
    }
}
