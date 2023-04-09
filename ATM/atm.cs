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
            currentUser.setBalance(deposit); // deposit + currentBalance
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
        }
    }
}