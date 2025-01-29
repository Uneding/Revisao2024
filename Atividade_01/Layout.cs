using System.Diagnostics.Contracts;
namespace Layout
{
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
}

