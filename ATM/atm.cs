using System;
public class cardHolder
{
    string cardName;
    int pin;
    string firstName;
    string lastName;
    double balance;
    public cardHolder(string cardName, int pin, string firstName, string lastName, double balance)
    {
        this.cardName = cardName;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }
    public string getName()
    {
        return cardName;
    }
    public int getPin()
    {
        return pin;
    }
    public string getFirstName()
    {
        return firstName;
    }
    public string getLastName()
    {
        return lastName;
    }
    public double getBalance()
    {
        return balance;
    }
    public void setName(string newCardName)
    {
        cardName = newCardName;
    }
    public void setPin(int newPin)
    {
        pin = newPin;
    }
    public void setfirstName(string newFirstName)
    {
        firstName = newFirstName;
    }
    public void setlastName(string newLastName)
    {
        lastName = newLastName;
    }
    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }
    public static void Main(string[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose one: ");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }
        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much $$ would you like deposit? ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit); 
            Console.WriteLine("It is done, new balance: " + currentUser.getBalance);
        }
        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("Amount of withdraw? ");
            double withdraw = Double.Parse(Console.ReadLine());
            // check if the amount is enough
            if (currentUser.getBalance() < withdraw)
            {
                Console.WriteLine("Sorry! Insufficient balance ");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdraw);
            }
            void balance(cardHolder currentUser)
            {
                Console.WriteLine("Current balance: " + currentUser.getBalance());
            }
            List<cardHolder> cardHolders = new List<cardHolder>();
            cardHolders.Add(new cardHolder("123456", 1235, "alperen", "akdogan", 123.45));
            cardHolders.Add(new cardHolder("123457", 1236, "azra", "akdogan", 145.45));
            cardHolders.Add(new cardHolder("123458", 1237, "adjoa", "akdogan", 187.45));
            cardHolders.Add(new cardHolder("123459", 1238, "esra", "akdogan", 923.45));
            cardHolders.Add(new cardHolder("123451", 1239, "sultan", "akdogan", 423.45));

            // Prompt user
            Console.WriteLine("Welcome to SimpleATM");
            Console.WriteLine("Type your debit card number: ");
            String debitCardNumber = "";
            cardHolder currentUser;

            while(true)
            {
                try
                {
                    debitCardNumber = Console.ReadLine();
                    // check against our db
                    currentUser = cardHolders.FirstOrDefault(a => a.cardName == debitCardNumber);
                    if (currentUser != null) { break; }
                    else { Console.WriteLine("cardHolder not recognized. Please try again"); }
                }
                catch {Console.WriteLine("cardHolder not recognized. Please try again");}
            }

            Console.WriteLine("Please enter your pin: ");
            int userPin = 0;
             while(true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    // check against our db
                    if (currentUser.getPin() == userPin) { break; }
                    else { Console.WriteLine("incorrent Pin. Please try again"); }
                }
                catch {Console.WriteLine("incorrent pin. Please try again");}
            }

            System.Console.WriteLine("Welcome " + currentUser.getFirstName());
            int option = 0;
            do
            {
                printOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { }
                if (option == 1) { deposit(currentUser); }
                else if (option == 2) { withdraw(currentUser); }
                else if (option == 3) { balance(currentUser); }
                else if (option == 4) { break; }
                else { option = 0; }
                
            } while (option != 4);
            System.Console.WriteLine("Thamk you, have a wonderful day");
        }
    }
} 