// See https://aka.ms/new-console-template for more information
Console.WriteLine("***Basic For Loop Lab***");
//print sum and product of all numbers

do
{
    Console.WriteLine("Enter a number");
    int strNum = Convert.ToInt32(Console.ReadLine());
    int sumNum = 0;
    //long mulNum = 1;
    for (int i = 1; i <= strNum; i++)
    {
        sumNum = sumNum + i;
        //mulNum = mulNum * i;
    }
    Console.WriteLine($" Sum of all numbers is {sumNum}");
    //Console.WriteLine($" Product of all numbers is {mulNum}");

} while (GetPlayAgainAnswer() == true);

bool GetPlayAgainAnswer(string strMessage = "Would you like to Continue? y/n")
{
    Console.WriteLine(strMessage);
    string userAnswer = Console.ReadLine();
    if (userAnswer.ToLower() != "y")
    {
        return false;
    }

    //Console.WriteLine("YEAH LETS PLAY");
    return true;
}
