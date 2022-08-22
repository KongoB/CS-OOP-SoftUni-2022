namespace BorderControl
{
    public class Citizen : Entities, IIdentifiable, IAge
    {

        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public string Name { get ; set ; }
        public int Age { get ; set; }
    }
}
