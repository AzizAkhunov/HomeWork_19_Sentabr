using Vazifa19_09_2023.Service;

namespace HomeWork_19_Sentabr
{
    public class Test
    {
        public Guid Id { get; set; }
        public string LessonName { get; set; }
        public string TestName { get; set;}
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }


        public string Answer { get; set; }

        public Test(string lesson, string testName, string a, string b, string c, string d, string answer)
        {
            Id = Guid.NewGuid();
            LessonName = lesson;
            TestName = testName;
            A = a;
            B = b;
            C = c;
            D = d;
            Answer = answer;

            if (FileWriter.WriteNewTest(this))
            {
                Console.WriteLine("Test Added!");
            }
            else
            {
                Console.WriteLine("Something get wrong!");
            }
        }
            public override string ToString()
        {
            return $"{Id}%%{LessonName}%%{TestName}%%{A}%%{B}%%{C}%%{D}%%{Answer}";
        }
    }
}
