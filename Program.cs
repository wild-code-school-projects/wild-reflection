namespace ReflectionInspection
{
    internal class User
    {
        public string Name { get; set; }
        private int age => 25;
    }
    internal class Program
    {

        static void Main(string[] args)
        {

            Inspection inspect = new(new User { Name = "Ninja" });
            inspect.GetAllFields();
            inspect.GetAllProperties();
            inspect.GetAllMethods();
        }
    }
}
