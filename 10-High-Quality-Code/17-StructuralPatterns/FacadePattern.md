## Structural Design Patterns

### **Facade Pattern** ###

##### Обобщение
Моделът Facade е модел дизайн, който се използва, за да се опрости достъпа до функционалност в сложни или недобре разработени подсистеми.
Класът на Facade осигурява прост, еднокласови интерфейс, който крие подробностите по изпълнението на основните код.
Можем да кажем, че моделът е някаква обвивка, която съдържа набор от членовете които са лесни за разбиране и ползване.
Предоставя уеднаквен интерфейс за редица интерфейси. Дефинира интерфейс от по-високо ниво, което прави по-лесна употребата на подсистемата.
Моделът прави софтуерната библиотека лесна за използване, разбиране и тестване. Прави библиотеката по-разбираема и може да намали зависимостите. 
Този модел е много полезен, когато се занимава с много независими класове или групи, които изискват използването на множество методи, особено когато те са трудни за използване или трудни за разбиране.
Този модел се използва, когато подсистемата е лошо проектирана и може да няма възможност за рефактуриране на кода.

##### Имплементация

```c#    
namespace FacadePattern
{
    using System;

    class CarModel
    {
        public void SetModel()
        {
            Console.WriteLine(" CarModel - SetModel");
        }
    }

    class CarEngine
    {
        public void SetEngine()
        {
            Console.WriteLine(" CarEngine - SetEngine");
        }
    }

    class CarBody
    {
        public void SetBody()
        {
            Console.WriteLine(" CarBody - SetBody");
        }
    }

    class CarAccessories
    {
        public void SetAccessories()
        {
            Console.WriteLine(" CarAccessories - SetAccessories");
        }
    }

    public class CarFacade
    {
        private CarModel model;
        private CarEngine engine;
        private CarBody body;
        private CarAccessories accessories;

        public CarFacade()
        {
            model = new CarModel();
            engine = new CarEngine();
            body = new CarBody();
            accessories = new CarAccessories();
        }

        public void CreateCompleteCar()
        {
            Console.WriteLine("******** Creating a Car **********\n");
            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            accessories.SetAccessories();

            Console.WriteLine("\n******** Car creation is completed**********");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CarFacade facade = new CarFacade();

            facade.CreateCompleteCar();

            Console.ReadKey();

        }
    }
}
```

##### UML Диаграма

![](https://upload.wikimedia.org/wikipedia/en/5/57/Example_of_Facade_design_pattern_in_UML.png)
