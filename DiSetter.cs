namespace DependencyInjectionApp.SetterDi

{
    public class Famaky
    {
        public void Ampiasaina()
        {
            Console.WriteLine("Ampiasaina ny famaky");
        }
    }

    public class Angady
    {
        public void Ampiasaina()
        {
            Console.WriteLine("Ampiasaina ny angady");
        }
    }

    // constructor dependency injection
    public class Mpanamboatra
    {
        public Famaky Famaky {get; set;}
        public Angady Angady {get; set;}

        public void MamboatraTrano()
        {
            Famaky.Ampiasaina();
            Angady.Ampiasaina();

            Console.WriteLine("Vita ilay trano");
        }
    }
}
