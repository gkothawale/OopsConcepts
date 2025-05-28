namespace OopsConcepts.Classes
{
    public class Test
    {
        private int a; // only inside Test Class
        protected int b; // Only Test + subclasses
        internal int c;// Same Project
        protected internal int d;// Project + subclasses
        private protected int e; // same project + subclass
        public int f; // Anywhere.
    }
}
