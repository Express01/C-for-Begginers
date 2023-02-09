// See https://aka.ms/new-console-template for more information
//int[] cards = new int[]
//{
//    2,3,4,5,6,7,8,9,10,       //цифры
//    10,10,10,                //картинки
//    11 ,                      //туз
//      2,3,4,5,6,7,8,9,10,       //цифры
//    10,10,10,                //картинки
//    11  ,                     //туз
//      2,3,4,5,6,7,8,9,10,       //цифры
//    10,10,10,                //картинки
//    11 ,                    //туз
//      2,3,4,5,6,7,8,9,10,       //цифры
//    10,10,10,                //картинки
//    11                       //туз
//};
int[] cards = new int[] { 1, 2, 3, 4 };
cards = Shuffle(cards);
cards = Shuffle(cards);
cards = Shuffle(cards);

int[] Shuffle(int[] cards)
{
    int[] result = new int[cards.Length];
    Random random1 = new Random();
    random1.Next(0, cards.Length);
    for (int i = 0; i < cards.Length; i++)
    {

    }
    return result;
}

bool isPlayerContinue = true;
bool isComputerContinue = true;
Random random = new Random();
int decisionNumber = 0;
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

