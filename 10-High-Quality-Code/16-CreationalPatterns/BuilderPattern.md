# Creational Design Patterns

#### **Builder Pattern** ####

##### Обобщение
Builder позволява създаването на сложен обект стъпка по стъпка използвайки конкретна поредица от действия, така че един и същи процес да може да създава обекти с различно представяне. Конструкцията се контролира от директор.
Целта е да се раздели създаването на сложен обект от неговото представяне (интерфейс), за да може с един и същ процес да се създават обекти с различно представяне.

##### Имплементация

```c#   
public class Car
{
    public int Wheels { get; set; }

    public string Colour { get; set; }
}

public interface ICarBuilder
{
    void SetColour(string colour);

    void SetWheels(int count);

    Car GetResult();
}

public class CarBuilder : ICarBuilder
{
    private Car car;

    public CarBuilder()
    {
        this.car = new Car();
    }

    public void SetColour(string colour)
    {
        this.car.Colour = colour;
    }

    public void SetWheels(int count)
    {
        this.car.Wheels = count;
    }

    public Car GetResult()
    {
        return this.car;
    }
}

public class CarBuildDirector
{
    public Car Construct()
    {
        CarBuilder builder = new CarBuilder();

        builder.SetColour("Red");
        builder.SetWheels(4);

        return builder.GetResult();
    }
}
```

##### UML Диаграма

![](https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Builder_UML_class_diagram.svg/500px-Builder_UML_class_diagram.svg.png)

