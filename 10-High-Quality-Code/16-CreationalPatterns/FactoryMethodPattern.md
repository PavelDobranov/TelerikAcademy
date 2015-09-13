# Creational Design Patterns

#### **Factory Method Pattern** ####

##### Обобщение
Factory Method дефинира интерфейс за създаване на обекти, но оставя на подкласовете да решат от кои класове да направят инстанции.
Фабриката има за цел инстанцирането на различни обекти, чиито типове не са предефинирани. Обектите се създават динамично в зависимост от параметрите предадени на фабриката.

##### Имплементация

```c#    
public interface IPeople
{
    string GetName();
}

public class Villagers : IPeople
{
    public string GetName()
    {
        return "Village Guy";
    }
}

public class CityPeople : IPeople
{
    public string GetName()
    {
        return "City Guy";
    }
}

public enum PeopleType
{
    RURAL,
    URBAN
}

public class Factory
{
    public IPeople GetPeople(PeopleType type)
    {
        IPeople people = null;
        switch (type)
        {
            case PeopleType.RURAL:
                people = new Villagers();
                break;
            case PeopleType.URBAN:
                people = new CityPeople();
                break;
            default:
                break;
        }
        return people;
    }
}
```

##### UML Диаграма

![](https://upload.wikimedia.org/wikipedia/commons/thumb/a/a3/FactoryMethod.svg/349px-FactoryMethod.svg.png)
