namespace interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  interface == Define um "contrato" que todas as classe herdando dela precisa seguir
            //  A interace declara "O que a classe deve ter"
            //  As classe herdando dela definem "Como elas devem fazer"
            //  beneficios: Segurança + heranças multiplas + "Conecte e use"

            Coelho coelho = new Coelho();
            Aguia aguia = new Aguia();
            Peixe peixe = new Peixe();

            coelho.Fugir();
            
            aguia.Cacar();
                        
            peixe.Cacar();
            peixe.Fugir();
                
            Console.ReadKey();
            Console.Beep();
        }
    }
    interface IPresa
    {
        void Fugir();
    }
    interface IPredador
    {
        void Cacar();
    }
    class Coelho : IPresa
    {
        public void Fugir()
        {
            Console.WriteLine("O Coelho fugiu! :)");
        }
    }
    class Aguia : IPredador
    {
        public void Cacar()
        {
            Console.WriteLine("A aguia procura a sua presa! >:(");
        }
    }
    class Peixe : IPresa, IPredador
    {
        public void Cacar()
        {
            Console.WriteLine("O peixe comeu outro peixe menor! :(");
        }
        public void Fugir()
        {
            Console.WriteLine("O peixe fugiu! :)");
        }
    }
}
