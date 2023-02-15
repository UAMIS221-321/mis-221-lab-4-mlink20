// start main
int userChoice = GetUserChoice();
while(userChoice!=3){
    RouteEm(userChoice);
    userChoice = GetUserChoice();
}
// end main

static int GetUserChoice() {
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
    }
    else return 0;
}

static void DisplayMenu() {
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

static bool IsValidChoice(string userInput) {
    if(userInput == "1" || userInput =="2" || userInput == "3") {
        return true;
    }
    else return false;
}

static void DisplayFull() {
    Full();
    PauseAction();
}

static void DisplayPartial() {
    Partial();
    PauseAction();
}

static void SayInvalid() {
    Console.WriteLine("Invalid");
    PauseAction();
}

static void RouteEm(int menuChoice) {
    if(menuChoice==1){
        DisplayFull();
    }
    if(menuChoice==2) {
        DisplayPartial();
    }
    if(menuChoice!=3) {
        SayInvalid();
    }
}

static void PauseAction() {
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

static void Full() {
    Random rnd= new Random();
    int rows = rnd.Next(2,10);

    for(int i = 0; i <= rows; i++) {
        for(int j = 0; j<= i; j++) {
            Console.Write(0);
        }
        Console.WriteLine();
    }
}

static void Partial() {
    Random rnd= new Random();

    for(int i = 3; i <= 9; i++) {
        for(int j = 0; j < i; j++) {
            if(rnd.Next(2) == 0) {
                Console.Write(" ");
            } else {
                Console.Write("0");
            }
        }
        Console.WriteLine();
    }
}