Random rnd= new Random(); // Alustab käsklust, et genereerida suvalisi numbreid

int myRandomNum;

int randomSum = 0;

for (int i = 0; i < 10; i++) // Genereerib 3 suvalist numbrit
{
    myRandomNum = rnd.Next(0, 11); // Genereeritakse väärtusi x kuni y
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}."); // Kuvab vastavad numbrid
}

Console.WriteLine($"My random sum total is: {randomSum}");
