using System.Collections;
using System.Formats.Asn1;
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
            bool ver, cont;
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    posi[i] = (rand.Next(1, tamanho + 1)) - 1;
                }
                else
                {
                    do
                    {
                        posi[i] = (rand.Next(1, tamanho + 1)) - 1;

                    } while (posi[0] == posi[1] || posi[1] == posi[2] || posi[0] == posi[2]);
                }
            }
            Array.Sort(posi);
            int x = 0;
            switch (deci)
            {
                case 1:
                    for (int i = 0; i < tamanho; i++)
                    {
                        Num_Al = rand.Next(48, 58);
                        senha.Append((char)Num_Al);
                    }
                    break;
                case 2:
                    for (int i = 0; i < tamanho; i++)
                    {
                        if (x < 2 && i == posi[x])
                        {
                            ver = true;
                            while (ver == true)
                            {
                                int y = rand.Next(1, 3);
                                switch (y)
                                {
                                    case 1:
                                        if (teste[0] == 1)
                                        {
                                            Num_Al = rand.Next(48, 58);
                                            senha.Append((char)Num_Al);
                                            ver = false;
                                            teste[0] = 0;
                                            x++;
                                        }
                                        else if (teste[1] == 0)
                                        {
                                            ver = false;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                        break;
                                    default:
                                        if (teste[1] == 2)
                                        {
                                            cont = true;
                                            while (cont == true)
                                            {
                                                Num_Al = rand.Next(65, 123);
                                                if (Num_Al >= 91 && Num_Al <= 96)
                                                {
                                                    continue;
                                                }
                                                else if (teste[1] == 2)
                                                {
                                                    senha.Append((char)Num_Al);
                                                    teste[1] = 0;
                                                    cont = false;
                                                    ver = false;
                                                    x++;
                                                }
                                                else if (teste[0] == 0)
                                                {
                                                    ver = false;
                                                    cont = false;
                                                }
                                                else
                                                {
                                                    cont = false;
                                                }
                                            }
                                        }
                                        break;
                                }
                            }
                        }
                        else
                        {
                            int k = rand.Next(0, 4);
                            switch (k)
                            {
                                case 0:
                                    Num_Al = rand.Next(48, 58);
                                    senha.Append((char)Num_Al);
                                    break;
                                case 1:
                                    ver = true;
                                    while (ver == true)
                                    {
                                        Num_Al = rand.Next(33, 96);
                                        if ((Num_Al >= 46 && Num_Al <= 58) || Num_Al == 44 || Num_Al == 92 || Num_Al == 93 || Num_Al == 94 || Num_Al == 91 || Num_Al == 39 || Num_Al == 34)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            senha.Append((char)Num_Al);
                                            ver = false;
                                        }
                                    }
                                    break;
                                case 2:
                                    Num_Al = rand.Next(65, 91);
                                    senha.Append((char)Num_Al);
                                    break;
                                default:
                                    Num_Al = rand.Next(97, 123);
                                    senha.Append((char)Num_Al);
                                    break;
                            }
                        }
                    }
                    break;
                default:
                    for (int i5 = 0; i5 < tamanho; i5++)
                    {
                        Console.WriteLine($"-{i5}");
                        if (x < 3 && i5 == posi[x])
                        {
                            ver = true;
                            while (ver == true)
                            {
                                int y = rand.Next(1, 4);
                                switch (y)
                                {
                                    case 1:
                                        if (teste[0] == 1)
                                        {
                                            Num_Al = rand.Next(48, 58);
                                            senha.Append((char)Num_Al);
                                            ver = false;
                                            teste[0] = 0;
                                            x++;
                                        }
                                        else if (teste[1] == 0 && teste[2] == 0)
                                        {
                                            ver = false;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                        break;
                                    case 2:
                                        if (teste[1] == 2)
                                        {
                                            cont = true;
                                            while (cont == true)
                                            {
                                                Num_Al = rand.Next(65, 123);
                                                if (Num_Al >= 91 && Num_Al <= 96)
                                                {
                                                    continue;
                                                }
                                                else if (teste[1] == 2)
                                                {
                                                    senha.Append((char)Num_Al);
                                                    teste[1] = 0;
                                                    cont = false;
                                                    ver = false;
                                                    x++;
                                                }
                                                else if (teste[0] == 0 && teste[2] == 0)
                                                {
                                                    ver = false;
                                                    cont = false;
                                                }
                                                else
                                                {
                                                    cont = false;
                                                }
                                            }
                                        }
                                        break;
                                    case 3:
                                        cont = true;
                                        while (cont == true)
                                        {
                                            Num_Al = rand.Next(33, 96);
                                            if ((Num_Al >= 46 && Num_Al <= 58) || Num_Al == 44 || Num_Al == 92 || Num_Al == 93 || Num_Al == 94 || Num_Al == 91 || Num_Al == 39 || Num_Al == 34)
                                            {
                                                continue;
                                            }
                                            else if (teste[2] == 3)
                                            {
                                                senha.Append((char)Num_Al);
                                                teste[2] = 0;
                                                cont = false;
                                                ver = false;
                                                x++;
                                            }
                                            else if (teste[0] == 0 && teste[1] == 0)
                                            {
                                                ver = false;
                                                cont = false;
                                            }
                                            else
                                            {
                                                cont = false;
                                            }
                                        }
                                    break;
                                }
                            }
                        }
                        else
                        {
                            int f = rand.Next(0, 4);
                            switch (f)
                            {
                                case 0:
                                    Num_Al = rand.Next(48, 58);
                                    senha.Append((char)Num_Al);
                                    break;
                                case 1:
                                    ver = true;
                                    while (ver == true)
                                    {
                                        Num_Al = rand.Next(33, 96);
                                        if ((Num_Al >= 46 && Num_Al <= 58) || Num_Al == 44 || Num_Al == 92 || Num_Al == 93 || Num_Al == 94 || Num_Al == 91 || Num_Al == 39 || Num_Al == 34)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            senha.Append((char)Num_Al);
                                            ver = false;
                                        }
                                    }
                                    break;
                                case 2:
                                    Num_Al = rand.Next(65, 91);
                                    senha.Append((char)Num_Al);
                                    break;
                                default:
                                    Num_Al = rand.Next(97, 123);
                                    senha.Append((char)Num_Al);
                                    break;
                            }
                        }
                    }

                    break;
            }
            return senha.ToString();
        }
    }
}