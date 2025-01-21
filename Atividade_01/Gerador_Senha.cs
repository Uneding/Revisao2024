using System.Text;

namespace Gerador_Senhas
{
    public class Funcaos
    {
        public static string Aleatorio(int tamanho, int deci)
        {
            string Cara_Senha;
            if (deci == 1)
            {
               Cara_Senha = "0123456789";
            }
            else if (deci == 2)
            {
                Cara_Senha = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            }else
            {
                Cara_Senha = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_-+=<>?";
            }
            Random rand = new Random();
            StringBuilder senha = new System.Text.StringBuilder(tamanho);
            for (int i = 0; i < tamanho; i++)
            {
                char Cara_AL = Cara_Senha[rand.Next(Cara_Senha.Length)];
                senha.Append(Cara_AL);
            }

            return senha.ToString();
        }
    }
}