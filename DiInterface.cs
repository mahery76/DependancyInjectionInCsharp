namespace DependencyInjectionApp.InterfaceDi

{
    public interface IToolUser 
    {
        void SetFamaky(Famaky famaky);
        void SetAngady(Angady angady);
    }

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
    public class Mpanamboatra: IToolUser
    {
        private  Famaky _famaky;
        private  Angady _angady;

        public void MamboatraTrano()
        {
            _famaky.Ampiasaina();
            _angady.Ampiasaina();

            Console.WriteLine("Vita ilay trano");
        }
        public void SetAngady(Angady angady)
        {
            _angady = angady;
        }
        public void SetFamaky(Famaky famaky)
        {
            _famaky = famaky;
        }
    }
}
