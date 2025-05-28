namespace OopsConcepts.Classes
{
    public class Dog : Animal
    {
        public Dog(string name)
        {
            base.Name = name;
            base.Color = "Unknown";
        }
        public Dog(string name , string color)
        {
            base.Name = name;
            base.Color = color;
        }
        public new void Speak()
        {
            Console.WriteLine(this.Name + ":Barking...");
        }

       
    }
}
