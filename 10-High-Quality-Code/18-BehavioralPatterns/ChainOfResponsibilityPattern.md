## Chain of Responsibility

### **Behavioral Design Pattern**

##### Обобщение

Когато пишем приложения от най-различен тип, често се налага някое събитие генерирано от даден обект да бъде обработено от друг обект.
В тези случаи може да използваме шаблона за дизайн Chain of Responsibility. Той ни позволява да изпратим команда, без да знаем предварително кой точно обект ще я изпълни.
Предварително условие за това е всички обекти които биха могли да изпълнят командата ни да пазят референция един към друг, за да може да си прехвърлят заявката докато някой успее да я изпълни.
Chain of Responsibility ни позволява да разкачим дадена заявка от това кой точно ще я изпълни, давайки ни по-голяма гъвкавост, да достигнем до най-подходящия "Handler".
Най-големия недостатък на този шаблон за дизайн е, че много лесно може да бъде "счупен", ако например програмистта който го имплементира забрави да добави връзка за следващия Handler на дадена заявка.

##### Имплементация

```c#
internal class Loan
{
    public Loan(string purpose, decimal amount)
    {
        this.Purpose = purpose;
        this.Amount = amount;
    }

    public string Purpose { get; set; }

    public decimal Amount { get; set; }
}

internal abstract class LoanHandler
{
    protected LoanHandler Successor { get; set; }

    public void SetSuccessor(LoanHandler successor)
    {
        this.Successor = successor;
    }

    public abstract void ApproveRequest(Loan loanRequest);
}

internal class Clerk : LoanHandler
{
    private const decimal ApproveLimit = 10000M;

    public override void ApproveRequest(Loan loanRequest)
    {
        if (loanRequest.Amount < ApproveLimit)
        {
            Console.WriteLine("Approved {0:C2} loan for {1} by the Bank {2}", loanRequest.Amount, loanRequest.Purpose, this.GetType().Name);
        }
        else if (this.Successor != null)
        {
            this.Successor.ApproveRequest(loanRequest);
        }
    }
}

public class Client
{
    public static void Main()
    {
        LoanHandler lowLevelClerk = new Clerk();
        LoanHandler midLevelManager = new AssistanManager();
        LoanHandler topExecuive = new GeneralManager();

        lowLevelClerk.SetSuccessor(midLevelManager);
        midLevelManager.SetSuccessor(topExecuive);

        var loan = new Loan("New Laptop", 1999);
        lowLevelClerk.ApproveRequest(loan);

        loan = new Loan("Fancy Sport Car", 180000);
        lowLevelClerk.ApproveRequest(loan);

        loan = new Loan("House in Miami", 1750000);
        lowLevelClerk.ApproveRequest(loan);

        loan = new Loan("Shiny Yacht", 12000000);
        lowLevelClerk.ApproveRequest(loan);
    }
}
```

##### UML Диаграма

![](http://www.dofactory.com/images/diagrams/net/chain.gif)