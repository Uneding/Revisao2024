using System.Collections;
using System.Formats.Asn1;
using System.Reflection.Metadata;
using System.Text;

namespace Gerador_Senhas
{
    public class Funcaos
    {
        public static Random De_Fun = new Random();
        private static int N_aleatorio()
        {
            return De_Fun.Next(48, 58);
        }
        private static int C_aleatorio()
        {
            while (true)
            {
                int Ver_Caracter = 0;
                Ver_Caracter = De_Fun.Next(33, 96);
                if ((Ver_Caracter >= 46 && Ver_Caracter <= 58) || Ver_Caracter == 44 || Ver_Caracter == 92 || Ver_Caracter == 93 || Ver_Caracter == 94 || Ver_Caracter == 91 || Ver_Caracter == 39 || Ver_Caracter == 34)
                {
                    continue;
                }
                return Ver_Caracter;
            }
        }
        private static int Lm_aleatorio()
        {
            return De_Fun.Next(97, 123);
        }
        private static int LM_aleatorio()
        {
            return De_Fun.Next(65, 91);
        }
        public static string Aleatorio(int tamanho, int deci)
        {

            Random rand = new Random();
            StringBuilder senha = new System.Text.StringBuilder(tamanho);
            int[] posi = new int[3];
            int[] Verificar_ValorUsado = { 1, 2, 3 };
            int Num_Al = 0;
            bool ver;
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
                        Num_Al = N_aleatorio();
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
                                        if (Verificar_ValorUsado[0] == 1)
                                        {
                                            Num_Al = N_aleatorio();
                                            senha.Append((char)Num_Al);
                                            ver = false;
                                            Verificar_ValorUsado[0] = 0;
                                            x++;
                                        }
                                        else if (Verificar_ValorUsado[1] == 0)
                                        {
                                            ver = false;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                        break;
                                    default:
                                        if (Verificar_ValorUsado[1] == 2)
                                        {
                                            int t = rand.Next(1, 3);
                                            if (t == 1)
                                            {
                                                Num_Al = Lm_aleatorio();
                                                senha.Append((char)Num_Al);
                                                Verificar_ValorUsado[1] = 0;
                                                ver = false;
                                                x++;
                                            }
                                            else
                                            {
                                                Num_Al = LM_aleatorio();
                                                senha.Append((char)Num_Al);
                                                Verificar_ValorUsado[1] = 0;
                                                ver = false;
                                                x++;
                                            }
                                        }
                                        else if (Verificar_ValorUsado[0] == 0)
                                        {
                                            ver = false;
                                        }
                                        else
                                        {
                                            continue;
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
                                    Num_Al = N_aleatorio();
                                    senha.Append((char)Num_Al);
                                    break;
                                case 1:
                                    Num_Al = C_aleatorio();
                                    senha.Append((char)Num_Al);
                                    break;
                                case 2:
                                    Num_Al = LM_aleatorio();
                                    senha.Append((char)Num_Al);
                                    break;
                                default:
                                    Num_Al = Lm_aleatorio();
                                    senha.Append((char)Num_Al);
                                    break;
                            }
                        }
                    }
                    break;
                default:
                    for (int i5 = 0; i5 < tamanho; i5++)
                    {

                        if (x < 3 && i5 == posi[x])
                        {
                            ver = true;
                            while (ver == true)
                            {
                                int y1 = rand.Next(1, 4);
                                switch (y1)
                                {
                                    case 1:
                                        if (Verificar_ValorUsado[0] == 1)
                                        {
                                            Num_Al = N_aleatorio();
                                            senha.Append((char)Num_Al);
                                            ver = false;
                                            Verificar_ValorUsado[0] = 0;
                                            x++;
                                        }
                                        else if (Verificar_ValorUsado[1] == 0 && Verificar_ValorUsado[2] == 0)
                                        {
                                            ver = false;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                        break;
                                    case 2:
                                        if (Verificar_ValorUsado[1] == 2)
                                        {
                                            int t1 = rand.Next(1, 3);
                                            if (t1 == 1)
                                            {
                                                Num_Al = Lm_aleatorio();
                                                senha.Append((char)Num_Al);
                                                Verificar_ValorUsado[1] = 0;
                                                ver = false;
                                                x++;
                                            }
                                            else
                                            {
                                                Num_Al = LM_aleatorio();
                                                senha.Append((char)Num_Al);
                                                Verificar_ValorUsado[1] = 0;
                                                ver = false;
                                                x++;
                                            }
                                        }
                                        else if (Verificar_ValorUsado[0] == 0 && Verificar_ValorUsado[2] == 0)
                                        {
                                            ver = false;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                        break;
                                    case 3:
                                        if (Verificar_ValorUsado[2] == 3)
                                        {
                                            Num_Al = C_aleatorio();
                                            senha.Append((char)Num_Al);
                                            Verificar_ValorUsado[2] = 0;
                                            ver = false;
                                            x++;
                                        }
                                        else if (Verificar_ValorUsado[0] == 0 && Verificar_ValorUsado[1] == 0)
                                        {
                                            ver = false;
                                        }
                                        else
                                        {
                                            continue;
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
                                    Num_Al = N_aleatorio();
                                    senha.Append((char)Num_Al);
                                    break;
                                case 1:
                                    Num_Al = C_aleatorio();
                                    senha.Append((char)Num_Al);
                                    break;
                                case 2:
                                    Num_Al = LM_aleatorio();
                                    senha.Append((char)Num_Al);
                                    break;
                                default:
                                    Num_Al = Lm_aleatorio();
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