namespace Gerador_Senhas
{
    public class Funcaos
    {
        static string Aleatorio(int tamanho, char deci)
        {
            string Cara_Senha;
            if (desci.ToLower() == "s")
            {
                Cara_Senha = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_-+=<>?";
            }
            else
            {
                Cara_Senha = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            }
            Random rand = new Random();
            string senha = System.Text.StringBuilder(tamanho);
            for (int i = 0; i < tamanho; i++)
            {
                char Cara_AL = Cara_Senha[rand.Next(Cara_Senha.Length)];
                senha.Append(Cara_AL);
            }

            return senha.ToString();
        }
    }
}