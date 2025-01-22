using System.Text;

namespace Gerador_Senhas
{
    public class Funcaos
    {
        public static string Aleatorio(int tamanho, int deci)
        {

            Random rand = new Random();
            StringBuilder senha = new System.Text.StringBuilder(tamanho);
            int[] posi = new int[3];
            int[] teste = { 1, 2, 3 };
            int Num_Al = 0;
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    posi[i] = rand.Next(1, tamanho + 1);
                }
                else
                {
                    do
                    {
                        posi[i] = rand.Next(1, tamanho + 1);

                    } while (posi[0] == posi[1] || posi[1] == posi[2] || posi[0] == posi[2]);
                }
            }

            Array.Sort(posi);
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{posi[i]} ");
            }
            int x = 0;

            if (deci == 1)
            {
                for (int i = 0; i < tamanho; i++)
                {
                    Num_Al = rand.Next(48, 58);
                    senha.Append((char)Num_Al);
                }
            }
            else if (deci == 2)
            {
                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine($"-{i}");
                    retornodic2:
                    if (x < 2 && i == posi[x])
                    {
                        
                        int y = rand.Next(1, 3);
                        Console.WriteLine(y);
                        if (y == 1)
                        {
                            if (teste[0] == 1)
                            {
                                Num_Al = rand.Next(48, 58);
                                senha.Append((char)Num_Al);
                                teste[0] = 0;
                                Console.Write($"sim{(char)Num_Al}");
                                Console.WriteLine(x);
                                x++;
                            }
                            if (teste[1] != 0)
                            {
                                goto retornodic2;
                            }
                        }
                        else if (y == 2)
                        {
                            if (teste[1] == 2)
                            {
                            retornodic3:
                                Num_Al = rand.Next(65, 123);
                                if (Num_Al >= 91 && Num_Al <= 96)
                                {
                                    goto retornodic3;
                                }
                                else
                                {
                                    senha.Append((char)Num_Al);
                                    teste[1] = 0;
                                    Console.Write($"sim{(char)Num_Al}");
                                    Console.WriteLine(x);
                                    x++;
                                }

                                if (teste[0] != 0)
                                {
                                    goto retornodic2;
                                }
                            }

                        }
                        
                    
                    }
                    else
                    {
                        retorno:
                    Num_Al = rand.Next(48, 91);
                    if (Num_Al >= 58 && Num_Al <= 64)
                    {
                        goto retorno;
                    }
                        senha.Append((char)Num_Al);
                    }
                }
            }
            else
            {
                for (int i5 = 0; i5 < tamanho; i5++)
                {
                    retornodic4:
                    if (x < 3 && i5 == posi[x])
                    {
                        int y = rand.Next(1, 4);
                        Console.WriteLine(y);
                        if (y == 1)
                        {
                            if (teste[0] == 1)
                            {

                                 Num_Al = rand.Next(48, 58);
                                senha.Append((char)Num_Al);
                                Console.Write($"sim{(char)Num_Al}");
                                teste[0] = 0;
                                Console.WriteLine(x);
                                x++;
                            }
                            if (teste[1] != 0 || teste[2] != 0)
                            {
                                goto retornodic4;
                            }
                        }
                        else if (y == 2)
                        {
                            if (teste[1] == 2)
                            {

                            retornodic5:
                                 Num_Al = rand.Next(65, 123);
                                if (Num_Al >= 91 && Num_Al <= 96)
                                {
                                    goto retornodic5;
                                }
                                else
                                {
                                    senha.Append((char)Num_Al);
                                    teste[1] = 0;
                                    Console.Write($"sim{(char)Num_Al}");
                                    Console.WriteLine(x);
                                    x++;
                                }
                                if (teste[0] != 0 || teste[2] != 0)
                                {
                                    goto retornodic4;
                                }
                            }
                        }
                        else if (y == 3)
                        {
                            if (teste[2] == 3)
                            {

                            retornodic6:
                                Num_Al = rand.Next(33, 96);
                                if ((Num_Al >= 46 && Num_Al <= 58) || Num_Al == 44 || Num_Al == 92 || Num_Al == 93 || Num_Al == 94 || Num_Al == 91 || Num_Al == 39 || Num_Al == 34)
                                {
                                    goto retornodic6;
                                }
                                else
                                {
                                    senha.Append((char)Num_Al);
                                    Console.Write($"sim{(char)Num_Al}");
                                    Console.WriteLine(x);
                                    teste[2] = 0;
                                    x++;
                                }
                                if (teste[0] != 0 || teste[1] != 0)
                                {
                                    goto retornodic4;
                                }
                            }
                        }
                        
                    }
                    else
                    {
                        retorno1:
                    Num_Al = rand.Next(33, 123);
                    if (Num_Al == 46 || Num_Al == 44 || Num_Al == 59 || Num_Al == 58 || Num_Al == 92 || Num_Al == 93 || Num_Al == 94 || Num_Al == 91 || Num_Al == 47 || Num_Al == 39 || Num_Al == 34 || Num_Al == 96)
                    {
                        goto retorno1;
                    }
                        senha.Append((char)Num_Al);
                    }

                }
            }
            return senha.ToString();
        }
    }
}