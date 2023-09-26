using HomeWork_19_Sentabr.Service;

while (true)
{
    Console.WriteLine(" 1.Test tuzish \n 2. Testlarni bo`lish\n 0. Chiqish");
    int switch_change = int.Parse(Console.ReadLine());
    switch (switch_change)
    {
        case 1:
            TestBuild.Build_Question();
            break;
        case 2:
            TestBuild.Generation();
            break;
        case 0:
            return 0;
        default:
            Console.WriteLine("Error!!");
            break;
    }
}