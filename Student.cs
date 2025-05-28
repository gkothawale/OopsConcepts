namespace OopsConcepts
{
    public class Student
    {
        private int Id { get; set; }
        public Student(int _id)
        {
            this.Id = _id;
        }

        public int GetRollNo()
        {
            return Id;
        }

        public void SetId(int _Id)
        {
            Id = _Id;
        }
        ~Student()
        {
            GC.SuppressFinalize(this);
        }
    }
}
