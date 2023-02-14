// Mäng, kus kasutaja proovib ära arvata arvuti poolt suvaliselt genereeritud numbri
Random rnd= new Random();
int cpuRandom;

bool loopActive = true; // bool - true/false

while (loopActive) // Teeb loop-i kuni =true
{
    cpuRandom = rnd.Next(1, 4); // Arvuti genereetib numbri 1-3
    Console.WriteLine($"CPU has generated number: {cpuRandom}."); // Kuvab arvuti genereeritud numbri
    Console.WriteLine("Guess a number from 1-3"); // Kasutaja sisestab numbri 1-3
    int userNumber = Int32.Parse(Console.ReadLine()); // Salvestab numbrid

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        // loopActive = false; // Lõpetab loop (mängu), kui vastus oli õige
        break;
    }
    else
    {
        Console.WriteLine("Oops, try again.");
    }

}

Console.WriteLine("Have a nice day!");