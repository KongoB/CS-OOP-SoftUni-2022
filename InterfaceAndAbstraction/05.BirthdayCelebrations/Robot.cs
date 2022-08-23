namespace BirthdayCelebrations
{
    public class Robot : Entities, IIdentifiable
    {

        public Robot(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Id { get ; set ; }
    }
}
