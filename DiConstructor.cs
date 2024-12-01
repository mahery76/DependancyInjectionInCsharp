namespace DependencyInjectionApp.ConstructorDi
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
        private Famaky _famaky;
        private Angady _angady;

        public Mpanamboatra(Famaky famaky, Angady angady)
        {
            _angady = angady;
            _famaky = famaky;
        }

        public void MamboatraTrano()
        {
            _angady.Ampiasaina();
            _famaky.Ampiasaina();

            Console.WriteLine("Vita ilay trano");
        }
    }
}
