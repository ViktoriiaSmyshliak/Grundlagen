public delegate void AccountHandler(string message);

public class Account
{
    int sum;

    // Create a delegate variable
    AccountHandler? taken;

    public Account(int sum) => this.sum = sum;

    // Register the delegate
    public void RegisterHandler(AccountHandler del)
    {
        taken = del;
    }

    public void Add(int sum) => this.sum += sum;

    public void Take(int sum)
    {
        if (this.sum >= sum)
        {
            this.sum -= sum;

            // Invoke the delegate, passing a message
            taken?.Invoke($"Withdrawn {sum} units from the account.");
        }
        else
        {
            taken?.Invoke($"Insufficient funds. Balance: {this.sum} units.");
        }
    }
}