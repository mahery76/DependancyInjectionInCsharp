// using DependencyInjectionApp.ConstructorDi;
// using DependencyInjectionApp.SetterDi;
using DependencyInjectionApp.InterfaceDi;

namespace DependencyInjectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Famaky famaky = new Famaky();
            Angady angady = new Angady();

            using the constructor DI
            Mpanamboatra mpanamboatra = new Mpanamboatra(famaky, angady);

            //using the setter DI
            // Mpanamboatra mpanamboatra = new Mpanamboatra();
            // mpanamboatra.Famaky = famaky;
            // mpanamboatra.Angady = angady;
            
            // using the interface DI
            // Mpanamboatra mpanamboatra = new Mpanamboatra();
            // mpanamboatra.SetFamaky(famaky);
            // mpanamboatra.SetAngady(angady);

            // it will call the method to build the house
            mpanamboatra.MamboatraTrano();

            Console.ReadLine();
        }
    }
}   
