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
    if(userInput == "1" || userInput =="3" || userInput == "3") {
        return true;
    }
    else return false;
}

static void DisplayFull() {

}

static void DisplayPartial() {

}

static void SayInvalid() {

}

static void RouteEm(int userInput) {
    if(userInput==1){
        DisplayFull();
    }
    if(userInput==2) {
        DisplayPartial();
    }
    if(userInput!=3) {
        SayInvalid();
    }
}