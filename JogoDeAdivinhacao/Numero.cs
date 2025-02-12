namespace JogoDeAdivinhacao
{
    public class Numero
    {
        public int NumeroAleatorio { get; private set; }
        public int NumeroChutado { get; set; }

        public Numero()
        {
            GerarNumeroAleatorio();
        }

        public void GerarNumeroAleatorio()
        {
            Random random = new Random();
            NumeroAleatorio = random.Next(1, 20); 
        }
    }
}
