# Creational Design Patterns

#### **Prototype Pattern** ####

##### Обобщение
Определя прототипна инстанция на някакъв вид обект и създава нови обекти чрез копиране на прототипа.
Prototype е създаващ шаблон за дизайн. Създава обекти с помощта на обект-прототип. Новите обекти се създават чрез клониране на прототипа, вместо с използване на конструктор.

##### Имплементация

```c#    
using System;
using System.Collections.Generic;

namespace PrototypePattern
{
    class MainApp
    {
        static void Main()
        {
            ColorManager colormanager = new ColorManager();

            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);

            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["flame"] = new Color(211, 34, 20);

            Color color1 = colormanager["red"].Clone() as Color;
            Color color2 = colormanager["peace"].Clone() as Color;
            Color color3 = colormanager["flame"].Clone() as Color;

            Console.ReadKey();
        }
    }

    abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }

    class Color : ColorPrototype
    {
        private int red;
        private int green;
        private int blue;

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public override ColorPrototype Clone()
        {
            Console.WriteLine("Cloning color RGB: {0,3},{1,3},{2,3}", red, green, blue);
            return this.MemberwiseClone() as ColorPrototype;
        }
    }

    class ColorManager
    {
        private Dictionary<string, ColorPrototype> colors = new Dictionary<string, ColorPrototype>();

        public ColorPrototype this[string key]
        {
            get { return colors[key]; }
            set { colors.Add(key, value); }
        }
    }
}
```

##### UML Диаграма

![](https://upload.wikimedia.org/wikipedia/commons/a/af/Prototype_design_pattern.png)

