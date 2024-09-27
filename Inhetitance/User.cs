namespace Inhetitance
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Biography { get; set; }
        public static string CompanyName { get; private set; }

        public User(string name, string biography)
        {
            Name = name;
            Biography = biography;
            CompanyName = "LangoTop";
        }

        public string GetFullBio()
        {
            return $"I'm {this.Name} and {this.Biography} and I work in {CompanyName}";
        }
        public virtual string GetName()
        {
            return $"I'm {this.Name} and {this.Biography} and I work in {CompanyName}";
        }
    }
}