// John Magpantay
// 10-20-2022
// Revamp Odd or even ! 

//Peer reviewed by : Rafael Manzo nice classic if else runs cool

bool reRun = true;


// string playAgain = "yes";
while (reRun)
{
    string validateMe;

    bool moreValid = false;
    bool newNum;
    int numNow = 0;


    while(!moreValid){
Console.WriteLine("Put your own number!");

    validateMe = Console.ReadLine();

    newNum = Int32.TryParse(validateMe, out numNow );


    if(newNum == true){

        moreValid = true;
        Console.WriteLine("Good job!");
    }else{
        Console.WriteLine("Invalid!");
    }
    }



    int numLock = numNow % 2;






    if (numLock == 1)
    {
        Console.WriteLine("Odd num");
    }
    else
    {
        Console.WriteLine("even num");
    }

    Console.WriteLine("play again? press enter or type done");
    string overNow = Console.ReadLine();

    if (overNow == "done"){


        reRun = false;
    }




    }
    Console.WriteLine(" GGs");

