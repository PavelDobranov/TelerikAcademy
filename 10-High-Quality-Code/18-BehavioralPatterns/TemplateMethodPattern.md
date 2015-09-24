## Behavioral Patterns

##### **Тemplate Method**

##### Обобщение
Този шаблон за дизайн се използва когато имаме даден алгоритъм който изпълнява дадена задача в определена последователност, но част от стъпките могат да се изпълняват по различен начин в зависимост от имплементацията. Това може да бъде постигнато с наследяване, вместо с имплементирането на Strategy Pattern.
При ползването на Тemplate Method имаме определен скелет на един алгоритъм при дадена операция, отстъпвайки някои стъпки за имплементиране от подкласове. Те от своя страна предефинират някои стъпки, но без да се променя цялостната структурата на алгоритъма.

##### Имплементация

```c#
public abstract class HiringProcess
{
    public void HirePerson()
    {
        this.FirstRoundTest();
        this.CaseSolving();
        this.HRInterview();
    }

    protected abstract void CaseSolving();

    protected abstract void FirstRoundTest();

    private void HRInterview()
    {
        Console.WriteLine("Interview with the HR and Department Managers");
    }
}

public class CustomerSupportDepartment : HiringProcess
{
    protected override void CaseSolving()
    {
        Console.WriteLine("Writing an article about Communication with difficult clients");
    }

    protected override void FirstRoundTest()
    {
        Console.WriteLine("Conducted Test in English");
    }
}

public class DotNetDepartment : HiringProcess
{
    protected override void CaseSolving()
    {
        Console.WriteLine("Implementing Template method design pattern");
    }

    protected override void FirstRoundTest()
    {
        Console.WriteLine("Taking a tricky test in C#");
    }
}

public class Client
{
    public static void Main()
    {
        Console.WriteLine("--- How to hire Developer ---");
        HiringProcess newDev = new DotNetDepartment();
        newDev.HirePerson();

        Console.WriteLine("--- How to hire Customer Support ---");
        HiringProcess newSupport = new CustomerSupportDepartment();
        newSupport.HirePerson();
    }
}
```
##### UML Диаграма

![](http://www.dofactory.com/images/diagrams/net/template.gif)