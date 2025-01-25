
using Gerador_Senhas;

junt2:
Console.WriteLine("Entre com o tamanho da senha: ");
if (int.TryParse(Console.ReadLine(), out int tamanho))
{

junto:
    Console.WriteLine("Selecione uma das opções abaixo:\n 1 - Senha com apenas números.\n 2 - Senha com o alfabeto. \n 3 - Senha com caracteres especiais.");
    if (int.TryParse(Console.ReadLine(), out int deci) && ((deci == 1) || (deci == 2)|| (deci == 3)))
    {
        string senha_gerada = Funcaos.Aleatorio(tamanho, deci);
        Console.WriteLine($"Senha criada: \n {senha_gerada}");
    }
    else
    {
        Console.WriteLine("Valor Invalido");
        Thread.Sleep(1500);
        Console.Clear();
        goto junto;
    }
}
else
{
    Console.WriteLine("Valor Invalido");
    Thread.Sleep(1500);
    Console.Clear();
    goto junt2;
}

