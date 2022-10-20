Console.Clear();
// mark ramirez 
// 10/20/2022
// mini challenge #8
// you will choose a difficulty and then you i will try to guess a randomly selected number from what ever difficulty you selected

Console.WriteLine("to day you are going to play a guessing game try to guess the correct number");
Console.WriteLine("choose easy medium or hard");
Console.WriteLine("you will guess from 1-10 1-50 1-100 respectivally");
bool playing = true;
string no;
long WrongI = 0;
bool Number;
while (playing == true)
{
    bool Wguess = true;
    bool wNumber = true;
    int T = 0;

bool yessir = true;
Console.WriteLine($"choose \"easy\" or \"medium\" \"hard\" ");
string userinput = Console.ReadLine();
while(yessir == true)
{
userinput.ToLower();
if(userinput == "easy" ){
yessir = false;
}else if(userinput == "medium" ){
yessir = false;
}else if(userinput == "hard"){
yessir = false;
}else{
Console.WriteLine($"no \"easy\" or \"medium\" or \"hard\" not this \"{userinput}\" ");
userinput = Console.ReadLine();
}
}



    switch (userinput)
    {

        case "easy":

            Console.Clear();
            Random rndNum = new Random();
            int Rnum = rndNum.Next(1, 10);
            Console.WriteLine("you chose " + userinput);
            while (Wguess == true)
            {

                Console.WriteLine("guess a number");

                string IntInput = Console.ReadLine();
                while (wNumber)
                {
                    Number = Int64.TryParse(IntInput, out WrongI);
                    if (Number == true)
                    {
                        Console.WriteLine($"{IntInput} is a number");
                        wNumber = false;
                    }
                    else
                    {
                        Console.WriteLine("guess a number");
                        IntInput = Console.ReadLine();
                        wNumber = true;
                    }
                }
                int Vnum = Convert.ToInt32(IntInput);

                if (Vnum > Rnum)
                {
                    Wguess = true;
                    Console.WriteLine("your guess is greater than the number");
                    T++;
                }
                else if (Vnum < Rnum)
                {
                    Wguess = true;
                    Console.WriteLine("your guess is less than the number");
                    T++;
                }
                else
                {
                    Console.WriteLine("you guessed right!!!");
                    Wguess = false;
                }
                wNumber = true;
            }
            Console.WriteLine($"you guessed wrong {T} time");
            break;
        case "medium":

            Console.Clear();
            Random RndNum = new Random();
            int RnUm = RndNum.Next(1, 50);
            Console.WriteLine("you chose " + userinput);
            while (Wguess == true)
            {

                Console.WriteLine("guess a number");

                string IntInput = Console.ReadLine();
                while (wNumber)
                {
                    Number = Int64.TryParse(IntInput, out WrongI);
                    if (Number == true)
                    {
                        Console.WriteLine($"{IntInput} is a number");
                        wNumber = false;
                    }
                    else
                    {
                        Console.WriteLine("guess a number");
                        IntInput = Console.ReadLine();
                        wNumber = true;
                    }
                }
                int Vnum = Convert.ToInt32(IntInput);
                if (Vnum > RnUm)
                {
                    Wguess = true;
                    Console.WriteLine("your guess is greater than the number");
                    T++;
                }
                else if (Vnum < RnUm)
                {
                    Wguess = true;
                    Console.WriteLine("your guess is less than the number");
                    T++;
                }
                else
                {
                    Console.WriteLine("you guessed right!!!");
                    Wguess = false;
                }
                wNumber = true;
            }
            Console.WriteLine($"you guessed wrong {T} time");
            break;
        case "hard":

            Console.Clear();
            Random rNdNum = new Random();
            int RNum = rNdNum.Next(1, 100);
            Console.WriteLine("you chose " + userinput);
            while (Wguess == true)
            {

                Console.WriteLine("guess a number");

                string IntInput = Console.ReadLine();
                while (wNumber)
                {
                    Number = Int64.TryParse(IntInput, out WrongI);
                    if (Number == true)
                    {
                        Console.WriteLine($"{IntInput} is a number");
                        wNumber = false;
                    }
                    else
                    {
                        Console.WriteLine("guess a number");
                        IntInput = Console.ReadLine();
                        wNumber = true;
                    }
                }
                int Vnum = Convert.ToInt32(IntInput);
                if (Vnum > RNum)
                {
                    Wguess = true;
                    Console.WriteLine("your guess is greater than the number");
                    T++;
                }
                else if (Vnum < RNum)
                {
                    Wguess = true;
                    Console.WriteLine("your guess is less than the number");
                    T++;
                }
                else
                {
                    Console.WriteLine("you guessed right!!!");
                    Wguess = false;

                }
                wNumber = true;
            }
            Console.WriteLine($"you guessed wrong {T} time");
            break;
    }
    Console.WriteLine("Would you like to play again? yes or no");
    no = Console.ReadLine();
    if (no == "no")
    {
        playing = false;
    }
}