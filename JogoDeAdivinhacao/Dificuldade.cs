namespace JogoDeAdivinhacao
{
    public class Dificuldade
    {
        public override string ToString()
        {
            return "1- " + TipoDificuldade.Fácil + " (4 tentativas)\n" +
                   "2- " + TipoDificuldade.Médio + " (3 tentativas)\n" +
                   "3- " + TipoDificuldade.Difícil + " (2 tentativas)\n";
        }
    }

    public enum TipoDificuldade : int
    {
        Fácil = 1,
        Médio = 2,
        Difícil = 3
    }
}
