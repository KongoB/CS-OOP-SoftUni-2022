namespace BirthdayCelebrations
{
    public class Citizen : Entities, IIdentifiable, IAge
    {

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public int Age { get ; set; }
        public string Id { get ; set ; }
    }
}
