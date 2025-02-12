namespace JogoDeAdivinhacao
{
    public class Program 
    {
        public static void Main()
        {
            Dificuldade dificuldade = new Dificuldade();
            Numero numero = new Numero();
            SistemaPontuacao sistemaPontuacao = new SistemaPontuacao();

            Console.WriteLine("Olá! Este é o jogo da adivinhação e você deve adivinhar o número secreto de 1 a 20...");
            Console.WriteLine("\nEm qual dificuldade você deseja jogar?\n");
            Console.WriteLine(dificuldade);
            Console.Write("Digite o número da dificuldade: ");
            int dif = int.Parse(Console.ReadLine());
            TipoDificuldade tipoDificuldade = (TipoDificuldade)dif;
            Console.Clear();

            Console.WriteLine("Você está iniciando com " + sistemaPontuacao.Pontuacao + " pontos!");

            if ((int)tipoDificuldade == 1)
            {
                
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("\nChute um número: ");
                    numero.NumeroChutado = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (numero.NumeroChutado == numero.NumeroAleatorio)
                    {
                        Console.WriteLine("Parabéns! Com " + sistemaPontuacao.Pontuacao + " pontos, você acertou o número aleatório :)");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Que pena! você errou o número aleatório :(");

                        if ((3 - i) == 1)
                        {
                            Console.WriteLine("\nVocê perdeu " + sistemaPontuacao.CalcularPontosPerdidos(numero) +
                                " pontos e está agora com " + sistemaPontuacao.PontuacaoAtualizada(numero));
                            Console.WriteLine("\nResta " + (3 - i) + " tentativa!");                            
                        }
                        else if (i < 3)
                        {
                            Console.WriteLine("\nVocê perdeu " + sistemaPontuacao.CalcularPontosPerdidos(numero) +
                                " pontos e está agora com " + sistemaPontuacao.PontuacaoAtualizada(numero) + " pontos!");
                            Console.WriteLine("\nRestam " + (3 - i) + " tentativas!");
                        }
                        else if (i == 3)
                        {
                            Console.WriteLine("\nAcabaram suas tentativas! Você perdeu mais " + sistemaPontuacao.CalcularPontosPerdidos(numero) 
                                + " pontos e terminou o jogo com " + sistemaPontuacao.PontuacaoAtualizada(numero) + " pontos.\n");
                            Console.WriteLine("O número secreto era " + numero.NumeroAleatorio);
                        }
                    }
                }
            }

            if ((int)tipoDificuldade == 2)
            {
                int numeroChutado = 0;

                for (int i = 0; i < 3; i++)
                {
                    Console.Write("\nChute um número: ");
                    numeroChutado = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (numero.NumeroChutado == numero.NumeroAleatorio)
                    {
                        Console.WriteLine("Parabéns! Com " + sistemaPontuacao.Pontuacao + " pontos, você acertou o número aleatório :)");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Que pena! você errou o número aleatório :(");
                        if ((2 - i) == 1)
                        {
                            Console.WriteLine("\nVocê perdeu " + sistemaPontuacao.CalcularPontosPerdidos(numero) +
                                " pontos e está agora com " + sistemaPontuacao.PontuacaoAtualizada(numero) + " pontos!");
                            Console.WriteLine("\nResta " + (2 - i) + " tentativa!");                            
                        }
                        else if (i < 2)
                        {
                            Console.WriteLine("\nVocê perdeu " + sistemaPontuacao.CalcularPontosPerdidos(numero) +
                                " pontos e está agora com " + sistemaPontuacao.PontuacaoAtualizada(numero) + " pontos!");
                            Console.WriteLine("\nRestam " + (2 - i) + " tentativas!");                            
                        }
                        else if (i == 2)
                        {
                            Console.WriteLine("\nAcabaram suas tentativas! Você perdeu mais " + sistemaPontuacao.CalcularPontosPerdidos(numero)
                                + " pontos e terminou o jogo com " + sistemaPontuacao.PontuacaoAtualizada(numero) + " pontos.\n");
                            Console.WriteLine("O número secreto era " + numero.NumeroAleatorio);
                        }
                    }
                }
            }

            if ((int)tipoDificuldade == 3)
            {
                int numeroChutado = 0;

                for (int i = 0; i < 2; i++)
                {
                    Console.Write("\nChute um número: ");
                    numeroChutado = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (numero.NumeroChutado == numero.NumeroAleatorio)
                    {
                        Console.WriteLine("Parabéns! Com " + sistemaPontuacao.Pontuacao + " pontos, você acertou o número aleatório :)");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Que pena! você errou o número aleatório :(");

                        if ((1 - i) == 1)
                        {
                            Console.WriteLine("\nVocê perdeu " + sistemaPontuacao.CalcularPontosPerdidos(numero) +
                                " pontos e está agora com " + sistemaPontuacao.PontuacaoAtualizada(numero) + " pontos!");
                            Console.WriteLine("\nResta " + (1 - i) + " tentativa!");                            
                        } else if (i < 1)              
                        {
                            Console.WriteLine("\nVocê perdeu " + sistemaPontuacao.CalcularPontosPerdidos(numero) +
                                " pontos e está agora com " + sistemaPontuacao.PontuacaoAtualizada(numero) + " pontos!");
                            Console.WriteLine("\nRestam " + (1 - i) + " tentativas!");                            
                        }
                        else if (i == 1)
                        {
                            Console.WriteLine("\nAcabaram suas tentativas! Você perdeu mais " + sistemaPontuacao.CalcularPontosPerdidos(numero)
                                + " pontos e terminou o jogo com " + sistemaPontuacao.PontuacaoAtualizada(numero) + " pontos.\n");
                            Console.WriteLine("O número secreto era " + numero.NumeroAleatorio);
                        }
                    }
                }
            }
        }
    }
}