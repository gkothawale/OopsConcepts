namespace OopsConcepts.Classes
{
    public class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public virtual void Speak()
        {
            Console.WriteLine("Animal Sound");
        }

    }
}
