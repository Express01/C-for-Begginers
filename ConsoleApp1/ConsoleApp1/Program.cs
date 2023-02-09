// See https://aka.ms/new-console-template for more information
bool isPlayerContinue = true;
bool isComputerContinue = true;
Random random = new Random();
do
{
Console.WriteLine("Будешь тянуть карту?(y/n)");
string answer = Console.ReadLine();

if (answer=="y")
{
    Console.WriteLine("Вы тяните карту");
}
if (answer=="n")
{
    Console.WriteLine("Вы пассуете");
        isPlayerContinue = false;
}
    int decisionNumber = 0;
    if (isComputerContinue)
    {

      decisionNumber = random.Next(0,2);

    }
    if (decisionNumber==0)
    {
        Console.WriteLine("Компьютер тянут карту");
    }
    if (decisionNumber==1)
    {
        Console.WriteLine("Компьютер пассует");
        isComputerContinue = false;
    }
} while (isPlayerContinue||isComputerContinue);

