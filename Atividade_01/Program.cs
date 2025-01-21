
using System.ComponentModel.Design.Serialization;
using Gerador_Senhas;

int deci;
deci = 0;

Console.WriteLine("Entre com o tamanho da senha: ");
if (int.TryParse(Console.ReadLine(), out int tamanho))
{
    Console.WriteLine("Senha apenas com números?");
    if (string.IsNullOrWhiteSpace(Console.ReadLine()))
    {
        Console.WriteLine("Valor Invalido");
        Thread.Sleep(1500);
        Console.Clear();
    }
    else
    {
        deci = 1;
        Console.WriteLine("Caracteres especiais ?");
        string? C_e = Console.ReadLine();
        if (C_e == null)
        {
            Console.WriteLine("Valor Invalido");
            Thread.Sleep(1500);
            Console.Clear();
        }
        else
        {
            if(C_e.ToLower() == "sim")
            {
            deci = 2;
            string senha_gerada = Funcaos.Aleatorio(tamanho,deci);
            Console.WriteLine(senha_gerada);
            }else
            {
            deci = 3;
            string senha_gerada = Funcaos.Aleatorio(tamanho,deci);
            Console.WriteLine(senha_gerada);
            }
        }
    }
}    
else
{
    Console.WriteLine("Valor Invalido");
    Thread.Sleep(1500);
    Console.Clear();
}

