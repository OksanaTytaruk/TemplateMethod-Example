using System;

// Абстрактний клас
public abstract class AbstractClass
{
    // Шаблонний метод
    public void TemplateMethod()
    {
        Step1();
        Step2();
        Step3();
    }

    protected abstract void Step1();
    protected abstract void Step2();
    
    private void Step3()
    {
        Console.WriteLine("Виконання кроку 3");
    }
}

// Конкретний клас 1
public class ConcreteClassA : AbstractClass
{
    protected override void Step1()
    {
        Console.WriteLine("Виконання кроку 1 в ConcreteClassA");
    }

    protected override void Step2()
    {
        Console.WriteLine("Виконання кроку 2 в ConcreteClassA");
    }
}

// Конкретний клас 2
public class ConcreteClassB : AbstractClass
{
    protected override void Step1()
    {
        Console.WriteLine("Виконання кроку 1 в ConcreteClassB");
    }

    protected override void Step2()
    {
        Console.WriteLine("Виконання кроку 2 в ConcreteClassB");
    }
}

class Program
{
    static void Main(string[] args)
    {
        AbstractClass classA = new ConcreteClassA();
        classA.TemplateMethod();

        Console.WriteLine();

        AbstractClass classB = new ConcreteClassB();
        classB.TemplateMethod();
    }
}
