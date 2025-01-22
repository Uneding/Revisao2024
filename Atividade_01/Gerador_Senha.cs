using System.Text;

namespace Gerador_Senhas
{
    public class Funcaos
    {
        public static string Aleatorio(int tamanho, int deci)
        {

            Random rand = new Random();
            StringBuilder senha = new System.Text.StringBuilder(tamanho);
            for (int i = 0; i < tamanho; i++)
            {
            retorno:
                int Num_Al = rand.Next(33, 126);
                   if (Num_Al == 46 || Num_Al == 44 || Num_Al == 59 || Num_Al == 58 || Num_Al == 126 || Num_Al == 125 || Num_Al == 92 || Num_Al == 93 || Num_Al == 94 || Num_Al == 124 || Num_Al == 123 || Num_Al == 91 || Num_Al == 47 || Num_Al == 39 || Num_Al == 34 || Num_Al == 96 )
                {
                    goto retorno;
                }
                else
                {
                    senha.Append((char)Num_Al);
                }

            }

            return senha.ToString();
        }
    }
}