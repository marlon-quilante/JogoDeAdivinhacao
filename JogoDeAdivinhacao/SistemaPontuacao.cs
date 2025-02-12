namespace JogoDeAdivinhacao
{
    public class SistemaPontuacao
    {
        public float Pontuacao { get; set; } = 100;
        public float PontosPerdidos { get; set; }

        public SistemaPontuacao()
        {
        }

        public SistemaPontuacao(float pontuacao, float pontosPerdidos)
        {
            Pontuacao = pontuacao;
            PontosPerdidos = pontosPerdidos;
        }

        public float CalcularPontosPerdidos(Numero numero)
        {
            PontosPerdidos = (numero.NumeroChutado - numero.NumeroAleatorio) / 2;
            if (PontosPerdidos < 0)
            {
                PontosPerdidos = PontosPerdidos * (-1);
            }
            return PontosPerdidos;
        }

        public float PontuacaoAtualizada(Numero numero)
        {
            Pontuacao -= PontosPerdidos;
            return Pontuacao;
        }
    }
}
