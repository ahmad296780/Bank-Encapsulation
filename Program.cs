

using Bank_Encapsulation;

BankAccount chase = new BankAccount();
chase.deposit(22);
chase.getBalance();
Console.WriteLine("------");
chase.withdraw(15);
chase.getBalance();
Console.WriteLine("-----");

Console.WriteLine("What would you like to do with your bank account! Deposit or Withdraw ?");
string user = Console.ReadLine();
if (user == "deposit")
{
    Console.WriteLine("how much");
    int thismuch = int.Parse(Console.ReadLine());
    chase.deposit(thismuch);
    Console.WriteLine("your new balance is:");
    chase.getBalance();
}
else if (user == "Deposit")
{
    Console.WriteLine("how much");
    int thismuch = int.Parse(Console.ReadLine());
    chase.deposit(thismuch);
    Console.WriteLine("your new balance is:");
    chase.getBalance();
}
else if (user == "withdraw")
{
    Console.WriteLine("how much");
    int thismuch = int.Parse(Console.ReadLine());
    chase.withdraw(thismuch);
    Console.WriteLine("your new balance is:");
    chase.getBalance();
}
else if (user == "Withdraw")
{
    Console.WriteLine("how much");
    int thismuch = int.Parse(Console.ReadLine());
    chase.withdraw(thismuch);
    Console.WriteLine("your new balance is:");
    chase.getBalance();

}
else
{
    Console.WriteLine("CHOOSE ONE OF THE ABOVE");
}

