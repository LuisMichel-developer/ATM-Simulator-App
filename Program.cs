Console.WriteLine("Welcome to the ATM Simulator"); // This is a simple ATM simulator that allows users to check balance, deposit money, and withdraw money.
Console.WriteLine("Please select an option:");
Console.WriteLine("1. Check Balance");
Console.WriteLine("2. Deposit Money");
Console.WriteLine("3. Withdraw Money");
Console.WriteLine("4. Exit"); // Displaying the options available to the user

Random random = new Random(); // Creating a random number generator (not used in this snippet, but can be useful for future enhancements)
int balance = random.Next(3500, 5000); // Generating a random balance between 3500 and 5000


switch (Console.ReadLine()) // Reading user input
{
    case "1":
        Console.WriteLine($"Your current balance is " + balance ); // Placeholder for balance check
        break;
    case "2":
        Console.WriteLine($"Your current balance is " + balance); // Displaying the current balance before deposit
        Console.WriteLine("Enter amount to deposit: ");
        int depositAmount = Convert.ToInt32(Console.ReadLine()); // Reading deposit amount
        Console.WriteLine($"You have deposited {depositAmount}"); // Placeholder for deposit confirmation
        balance += depositAmount; // Updating the balance after deposit
        Console.WriteLine($"Your new balance is {balance}"); // Displaying the updated balance
        break;
    case "3":
        Console.WriteLine($"Your current balance is " + balance ); // Displaying the current balance before withdrawal  
        Console.WriteLine("Enter amount to withdraw: ");
        int withdrawAmount = Convert.ToInt32(Console.ReadLine()); // Reading withdrawal amount
        Console.WriteLine($"You have withdrawn ${withdrawAmount}"); // Placeholder for withdrawal confirmation
        if (withdrawAmount > balance) // Checking if the withdrawal amount exceeds the balance
        {
            Console.WriteLine("Insufficient funds for this withdrawal."); // Error message for insufficient funds
        }
        else
        {
            Console.WriteLine($"You have withdrawn ${withdrawAmount}"); // Placeholder for withdrawal confirmation
            balance -= withdrawAmount; // Updating the balance after withdrawal
            Console.WriteLine($"Your new balance is {balance}"); // Displaying the updated balance
        }
        break;
    case "4":
        Console.WriteLine("Thank you for using the ATM Simulator. Goodbye!"); // Exit message
        break;
    
}