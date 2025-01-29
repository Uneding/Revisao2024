using System.Diagnostics.Contracts;
using System.Net.Http.Headers;
namespace Layout
{
    public static class Variaveis_Globais
    {
        public static int Referencia_Tamanho = 0;
        public static int [] Tela = new int [Referencia_Tamanho];
    }
    
    public class Teclas
{
    public static string CapsLock(string texto)
    { 
        if(Console.CapsLock)
        {
            return texto;
        }else
        {
            return null;
        } 
    }

}
    public class Tela
    {
        public static int Tela_de_Fundo(int x, int y)
        {
             
        }
    }
}

