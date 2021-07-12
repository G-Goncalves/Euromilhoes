using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euromilhoes
{
    class Program
    {
        static string validacao(string pergunta) //VALIDAÇÃO DE INPUTS
        {
            bool val = false;
            string resposta;
            do
            {
                Console.WriteLine(pergunta);
                resposta = Console.ReadLine();
                if (resposta == "y" || resposta == "n" || resposta == "Y" || resposta == "N")
                {
                    val = true;
                }
                else
                {
                    val = false;
                    Console.WriteLine("Valor introduzido não é válido.");
                }
            }
            while (val == false);
            return resposta;
        }

        static int lerQuantosNumerosComposta() //LER QUANTOS NUMEROS CHAVE COMPOSTA
        {
            bool repete;
            int qNumeros, temp = 0;
            do
            { //PERGUNTAR QUANTOS NÚMEROS (COM VALIDAÇÃO)
                try
                {
                    Console.WriteLine("Quantos Números?");
                    temp = int.Parse(Console.ReadLine());
                    repete = false;
                    if (temp < 5 || temp > 11)
                    {
                        Console.WriteLine("Por favor introduza um número igual ou superior a 5 e igual ou inferior a 11.");
                    }
                }
                catch (Exception e)
                {
                    repete = true;
                    Console.WriteLine("Por favor digite um número.");
                }
            }
            while (temp < 5 || temp > 11 || repete);
            return qNumeros = temp;
        }
        static int lerQuantasEstrelasComposta() //LER QUANTAS ESTRELAS CHAVE COMPOSTA
        {
            bool repete;
            int qEstrelas, temp = 0;
            do
            { //PERGUNTAR QUANTAS ESTRELAS (COM VALIDAÇÃO)
                try
                {
                    Console.WriteLine("Quantas Estrelas?");
                    temp = int.Parse(Console.ReadLine());
                    repete = false;
                    if (temp < 2 || temp > 12)
                    {
                        Console.WriteLine("Por favor introduza um número igual ou superior a 2 e igual ou inferior a 12.");
                    }
                }
                catch (Exception e)
                {
                    repete = true;
                    Console.WriteLine("Por favor digite um número.");
                }
            }
            while (temp < 2 || temp > 12 || repete);
            return qEstrelas = temp;
        }
        static void lerNumeros(int[] vec, string categoria) //LER NÚMEROS DE ARRAY
        {
            for (int i = 0; i < vec.Length; i++)
            {
                bool repete; int temp = 0;
                do
                {
                    try
                    {
                        Console.WriteLine((i + 1) + "º " + categoria + ":");
                        temp = int.Parse(Console.ReadLine());
                        repete = false;
                    }
                    catch (Exception ex)
                    {
                        repete = true;
                        Console.WriteLine("Por favor digite um número.");
                    }
                } while (repete);

                //VERIFICAÇÃO DE NUMEROS IGUAIS DENTRO DO MESMO ARRAY
                bool existe = false;
                for (int k = 0; k < i; k++)
                {
                    if (temp == vec[k])
                    {
                        existe = true;
                        break;
                    }
                }
                if (categoria == "Número") //VALIDAR NÚMEROS
                {
                    if (temp <= 0 || temp > 50 || existe == true)
                    {
                        Console.WriteLine("Número inserido não não corresponde aos parâmetros.");
                        i--;
                    }
                    else
                    {
                        vec[i] = temp;
                    }
                }
                else if (categoria == "Estrela") //VALIDAR ESTRELAS
                {
                    if (temp <= 0 || temp > 12 || existe == true)
                    {
                        Console.WriteLine("Estrela inserida não corresponde aos parâmetros.");
                        i--;
                    }
                    else
                    {
                        vec[i] = temp;
                    }
                }
            }
            Array.Sort(vec);
        }
        static void escreverNumerosInseridos(int[] vec, string categoria) //ESCREVER NÚMEROS INSERIOS
        {
            string tipo;
            if (categoria == "Estrela")
            {
                tipo = "Estrelas Inseridas: ";
            }
            else
            {
                tipo = "Números Inseridos: ";
            }

            Array.Sort(vec);
            Console.WriteLine(" ");
            Console.Write(tipo);
            for (int i = 0; i < vec.Length; i++)
            {

                Console.Write(vec[i] + "|");
            }
        }
        //LER CHAVES
        static void lerChaves(int[] numeros, int[] estrelas, int[] numeros1, int[] estrelas1, int[] numeros2, int[] estrelas2, int[] numeros3, int[] estrelas3, int[] numeros4, int[] estrelas4, int[] numerosComposta, int[] estrelasComposta, string catEstrelas, string catNumeros, int quantasChaves)
        {
            Console.WriteLine("Por favor digite 5 Números e 2 Estrelas:");
            Console.WriteLine("(Nota: os valores introduzidos não podem ser repetidos e têm que ser de 1 a 50 (no caso dos Números) e de 1 a 12 (no caso das Estrelas)");

            //LER CHAVES NORMAIS
            if (quantasChaves == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Chave");
                Console.WriteLine("-------------------------------------");
                lerNumeros(numeros, catNumeros);
                lerNumeros(estrelas, catEstrelas);
            }
            else if (quantasChaves == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("Chave 1");
                Console.WriteLine("-------------------------------------");
                lerNumeros(numeros, catNumeros);
                lerNumeros(estrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("Chave 2");
                Console.WriteLine("-------------------------------------");
                lerNumeros(numeros1, catNumeros);
                lerNumeros(estrelas1, catEstrelas);
            }
            else if (quantasChaves == 3)
            {
                Console.WriteLine("");
                Console.WriteLine("Chave 1");
                Console.WriteLine("-------------------------------------");
                lerNumeros(numeros, catNumeros);
                lerNumeros(estrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("Chave 2");
                Console.WriteLine("-------------------------------------");
                lerNumeros(numeros1, catNumeros);
                lerNumeros(estrelas1, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("Chave 3");
                Console.WriteLine("-------------------------------------");
                lerNumeros(numeros2, catNumeros);
                lerNumeros(estrelas2, catEstrelas);
            }
            else if (quantasChaves == 4)
            {
                Console.WriteLine("");
                Console.WriteLine("Chave 1");
                Console.WriteLine("-------------------------------------");
                lerNumeros(numeros, catNumeros);
                lerNumeros(estrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("Chave 2");
                Console.WriteLine("-------------------------------------");
                lerNumeros(numeros1, catNumeros);
                lerNumeros(estrelas1, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("Chave 3");
                Console.WriteLine("-------------------------------------");
                lerNumeros(numeros2, catNumeros);
                lerNumeros(estrelas2, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("Chave 4");
                Console.WriteLine("-------------------------------------");
                lerNumeros(numeros3, catNumeros);
                lerNumeros(estrelas3, catEstrelas);
            }
            else if (quantasChaves == 5)
            {
                Console.WriteLine("");
                Console.WriteLine("Chave 1");
                Console.WriteLine("-------------------------------------");
                lerNumeros(numeros, catNumeros);
                lerNumeros(estrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("Chave 2");
                Console.WriteLine("-------------------------------------");
                lerNumeros(numeros1, catNumeros);
                lerNumeros(estrelas1, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("Chave 3");
                Console.WriteLine("-------------------------------------");
                lerNumeros(numeros2, catNumeros);
                lerNumeros(estrelas2, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("Chave 4");
                Console.WriteLine("-------------------------------------");
                lerNumeros(numeros3, catNumeros);
                lerNumeros(estrelas3, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("Chave 5");
                Console.WriteLine("-------------------------------------");
                lerNumeros(numeros4, catNumeros);
                lerNumeros(estrelas4, catEstrelas);
            }
            else
            {
                //OPÇÃO CHAVE COMPOSTA
                lerNumeros(numerosComposta, catNumeros);
                lerNumeros(estrelasComposta, catEstrelas);
            }
        }
        static void numerosAleatorios(int[] vec, string categoria) //GERAR CHAVES ALEATÓRIAS
        {
            System.Threading.Thread.Sleep(5);
            //ESTRELAS ALEATÓRIAS
            if (categoria == "Estrela")
            {
                Random chave = new Random();
                for (int i = 0; i < vec.Length; i++)
                {
                    bool existe = false;
                    int temp = chave.Next(1, 13);
                    for (int k = 0; k < i; k++)
                    {
                        if (temp == vec[k])
                        {
                            existe = true;
                            break;
                        }
                    }

                    if (existe == true)
                    {
                        i--;
                    }
                    else
                    {
                        vec[i] = temp;
                    }
                }
            }
            else  //NÚMEROS ALEATÓRIOS
            {
                Random chave = new Random();
                for (int i = 0; i < vec.Length; i++)
                {
                    bool existe = false;
                    int temp = chave.Next(1, 51);
                    for (int k = 0; k < i; k++)
                    {
                        if (temp == vec[k])
                        {
                            existe = true;
                            break;
                        }
                    }

                    if (existe == true)
                    {
                        i--;
                    }
                    else
                    {
                        vec[i] = temp;
                    }
                }
            }
            //ESCREVER RANDOMS
            Array.Sort(vec);
            for (int i = 0; i < vec.Length; i++)
            {
                Console.Write(vec[i] + "|");
            }
        }
        //LER CHAVES ALEATÓRIAS
        static void lerNumerosAleatorios(int[] numeros, int[] estrelas, int[] numeros1, int[] estrelas1, int[] numeros2, int[] estrelas2, int[] numeros3, int[] estrelas3, int[] numeros4, int[] estrelas4, int[] numerosComposta, int[] estrelasComposta, string catEstrelas, string catNumeros, int quantasChaves)
        {
            Console.WriteLine("Aposta Aleatória");
            Console.WriteLine("-------------------------------------");

            //CHAVES NORMAIS
            if (quantasChaves == 1)
            {
                Console.Write("Números: ");
                numerosAleatorios(numeros, catNumeros);
                Console.WriteLine("");
                Console.Write("Estrelas: ");
                numerosAleatorios(estrelas, catEstrelas);
            }
            else if (quantasChaves == 2)
            {
                Console.Write("Números da Chave 1: ");
                numerosAleatorios(numeros, catNumeros);
                Console.WriteLine("");
                Console.Write("Estrelas da Chave 1: ");
                numerosAleatorios(estrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.Write("Números da Chave 2: ");
                numerosAleatorios(numeros1, catNumeros);
                Console.WriteLine("");
                Console.Write("Estrelas da Chave 2: ");
                numerosAleatorios(estrelas1, catEstrelas);
            }
            else if (quantasChaves == 3)
            {
                Console.Write("Números da Chave 1: ");
                numerosAleatorios(numeros, catNumeros);
                Console.WriteLine("");
                Console.Write("Estrelas da Chave 1: ");
                numerosAleatorios(estrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.Write("Números da Chave 2: ");
                numerosAleatorios(numeros1, catNumeros);
                Console.WriteLine("");
                Console.Write("Estrelas da Chave 2: ");
                numerosAleatorios(estrelas1, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.Write("Números da Chave 3: ");
                numerosAleatorios(numeros2, catNumeros);
                Console.WriteLine("");
                Console.Write("Estrelas da Chave 3: ");
                numerosAleatorios(estrelas2, catEstrelas);
            }
            else if (quantasChaves == 4)
            {
                Console.Write("Números da Chave 1: ");
                numerosAleatorios(numeros, catNumeros);
                Console.WriteLine("");
                Console.Write("Estrelas da Chave 1: ");
                numerosAleatorios(estrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.Write("Números da Chave 2: ");
                numerosAleatorios(numeros1, catNumeros);
                Console.WriteLine("");
                Console.Write("Estrelas da Chave 2: ");
                numerosAleatorios(estrelas1, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.Write("Números da Chave 3: ");
                numerosAleatorios(numeros2, catNumeros);
                Console.WriteLine("");
                Console.Write("Estrelas da Chave 3: ");
                numerosAleatorios(estrelas2, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.Write("Números da Chave 4: ");
                numerosAleatorios(numeros3, catNumeros);
                Console.WriteLine("");
                Console.Write("Estrelas da Chave 4: ");
                numerosAleatorios(estrelas3, catEstrelas);
            }
            else if (quantasChaves == 5)
            {
                Console.Write("Números da Chave 1: ");
                numerosAleatorios(numeros, catNumeros);
                Console.WriteLine("");
                Console.Write("Estrelas da Chave 1: ");
                numerosAleatorios(estrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.Write("Números da Chave 2: ");
                numerosAleatorios(numeros1, catNumeros);
                Console.WriteLine("");
                Console.Write("Estrelas da Chave 2: ");
                numerosAleatorios(estrelas1, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.Write("Números da Chave 3: ");
                numerosAleatorios(numeros2, catNumeros);
                Console.WriteLine("");
                Console.Write("Estrelas da Chave 3: ");
                numerosAleatorios(estrelas2, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.Write("Números da Chave 4: ");
                numerosAleatorios(numeros3, catNumeros);
                Console.WriteLine("");
                Console.Write("Estrelas da Chave 4: ");
                numerosAleatorios(estrelas3, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.Write("Números da Chave 5: ");
                numerosAleatorios(numeros4, catNumeros);
                Console.WriteLine("");
                Console.Write("Estrelas da Chave 5: ");
                numerosAleatorios(estrelas4, catEstrelas);
            }
            else
            {
                //OPÇÃO CHAVE COMPOSTA
                Console.Write("Números: ");
                numerosAleatorios(numerosComposta, catNumeros);
                Console.WriteLine("");
                Console.Write("Estrelas: ");
                numerosAleatorios(estrelasComposta, catEstrelas);
            }
        }
        //ESCREVER CHAVES INTRODUZIDAS MANUALMENTE
        static void escreverChaves(int[] numeros, int[] estrelas, int[] numeros1, int[] estrelas1, int[] numeros2, int[] estrelas2, int[] numeros3, int[] estrelas3, int[] numeros4, int[] estrelas4, int[] numerosComposta, int[] estrelasComposta, string catNumeros, string catEstrelas, int quantasChaves)
        {
            //CHAVES NORMAIS
            if (quantasChaves == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Chave Introduzida");
                escreverNumerosInseridos(numeros, catNumeros);
                escreverNumerosInseridos(estrelas, catEstrelas);
            }
            else if (quantasChaves == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("Chave 1");
                escreverNumerosInseridos(numeros, catNumeros);
                escreverNumerosInseridos(estrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Chave 2");
                escreverNumerosInseridos(numeros1, catNumeros);
                escreverNumerosInseridos(estrelas1, catEstrelas);
            }
            else if (quantasChaves == 3)
            {
                Console.WriteLine("");
                Console.WriteLine("Chave 1");
                escreverNumerosInseridos(numeros, catNumeros);
                escreverNumerosInseridos(estrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Chave 2");
                escreverNumerosInseridos(numeros1, catNumeros);
                escreverNumerosInseridos(estrelas1, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Chave 3");
                escreverNumerosInseridos(numeros2, catNumeros);
                escreverNumerosInseridos(estrelas2, catEstrelas);
            }
            else if (quantasChaves == 4)
            {
                Console.WriteLine("");
                Console.WriteLine("Chave 1");
                escreverNumerosInseridos(numeros, catNumeros);
                escreverNumerosInseridos(estrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Chave 2");
                escreverNumerosInseridos(numeros1, catNumeros);
                escreverNumerosInseridos(estrelas1, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Chave 3");
                escreverNumerosInseridos(numeros2, catNumeros);
                escreverNumerosInseridos(estrelas2, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Chave 4");
                escreverNumerosInseridos(numeros3, catNumeros);
                escreverNumerosInseridos(estrelas3, catEstrelas);
            }
            else if (quantasChaves == 5)
            {
                Console.WriteLine("");
                Console.WriteLine("Chave 1");
                escreverNumerosInseridos(numeros, catNumeros);
                escreverNumerosInseridos(estrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Chave 2");
                escreverNumerosInseridos(numeros1, catNumeros);
                escreverNumerosInseridos(estrelas1, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Chave 3");
                escreverNumerosInseridos(numeros2, catNumeros);
                escreverNumerosInseridos(estrelas2, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Chave 4");
                escreverNumerosInseridos(numeros3, catNumeros);
                escreverNumerosInseridos(estrelas3, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Chave 5");
                escreverNumerosInseridos(numeros4, catNumeros);
                escreverNumerosInseridos(estrelas4, catEstrelas);
            }
            else
            {
                //OPÇÃO CHAVE COMPOSTA
                Console.WriteLine("");
                Console.WriteLine("Chave Introduzida");
                escreverNumerosInseridos(numerosComposta, catNumeros);
                escreverNumerosInseridos(estrelasComposta, catEstrelas);
            }

        }
        static int numerosComuns(int[] vec1, int[] vec2, string categoria) //COMPARAÇÃO
        {
            string tipo;
            if (categoria == "Estrela")
            {
                tipo = "Resultado de Estrelas: ";
            }
            else
            {
                tipo = "Resultado de Números: ";
            }

            //ESCREVER E CONTAR NÚMEROS/ESTRELAS IGUAIS
            int contIguais = 0;
            Console.WriteLine("");
            Console.Write(tipo);
            for (int i = 0; i < vec1.Length; i++)
            {
                for (int j = 0; j < vec2.Length; j++)
                {
                    if (vec1[i] == vec2[j])
                    {
                        Console.Write(vec1[i] + "|");
                        contIguais++;
                    }
                }
            }
            if (categoria == "Estrela") //PRÉMIOS ESTRELAS
            {
                if (contIguais == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Parabéns acertou em 1 Estrela!");
                    contIguais = 5;
                }
                else if (contIguais == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Parabéns acertou em 2 Estrelas!");
                    contIguais = 150;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Lamentamos, a chave inserida não tem prémio.");
                    contIguais = 0;
                }
            }
            else if (categoria == "Número") //PRÉMIOS NÚMEROS

                if (contIguais == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Parabéns acertou em 1 Número!");
                    contIguais = 10;
                }

                else if (contIguais == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Parabéns acertou em 2 Números!");
                    contIguais = 20;
                }

                else if (contIguais == 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Parabéns acertou em 3 Números!");
                    contIguais = 55;
                }
                else if (contIguais == 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Parabéns acertou em 4 Números!");
                    contIguais = 500;
                }
                else if (contIguais == 5)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Parabéns acertou em 5 Números!");
                    contIguais = 10000;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Lamentamos, a chave introduzida não tem prémio.");
                    contIguais = 0;
                }
            return contIguais;
        }
        static void calcPremio(int[] chaveNumeros, int[] chaveEstrelas, int[] numeros, int[] estrelas, int[] numeros1, int[] estrelas1, int[] numeros2, int[] estrelas2, int[] numeros3, int[] estrelas3, int[] numeros4, int[] estrelas4, int[] numerosComposta, int[] estrelasComposta, string catNumeros, string catEstrelas, int quantasChaves)
        {
            int numerosIguais = 0, estrelasIguais = 0,
                numerosIguais1 = 0, estrelasIguais1 = 0,
                numerosIguais2 = 0, estrelasIguais2 = 0,
                numerosIguais3 = 0, estrelasIguais3 = 0,
                numerosIguais4 = 0, estrelasIguais4 = 0,
                numerosIguaisComposta = 0, estrelasIguaisComposta = 0;

            //COMPARAÇÃO DE CHAVES NORMAIS
            if (quantasChaves == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Chave Introduzida");
                Console.WriteLine("-------------------------------------");
                numerosIguais = numerosComuns(numeros, chaveNumeros, catNumeros);
                estrelasIguais = numerosComuns(estrelas, chaveEstrelas, catEstrelas);
            }
            else if (quantasChaves == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Chave 1");
                Console.WriteLine("-------------------------------------");
                numerosIguais = numerosComuns(numeros, chaveNumeros, catNumeros);
                estrelasIguais = numerosComuns(estrelas, chaveEstrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Chave 2");
                Console.WriteLine("-------------------------------------");
                numerosIguais1 = numerosComuns(numeros1, chaveNumeros, catNumeros);
                estrelasIguais1 = numerosComuns(estrelas1, chaveEstrelas, catEstrelas);
            }
            else if (quantasChaves == 3)
            {
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Chave 1");
                Console.WriteLine("-------------------------------------");
                numerosIguais = numerosComuns(numeros, chaveNumeros, catNumeros);
                estrelasIguais = numerosComuns(estrelas, chaveEstrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Chave 2");
                Console.WriteLine("-------------------------------------");
                numerosIguais1 = numerosComuns(numeros1, chaveNumeros, catNumeros);
                estrelasIguais1 = numerosComuns(estrelas1, chaveEstrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Chave 3");
                Console.WriteLine("-------------------------------------");
                numerosIguais2 = numerosComuns(numeros2, chaveNumeros, catNumeros);
                estrelasIguais2 = numerosComuns(estrelas2, chaveEstrelas, catEstrelas);
            }
            else if (quantasChaves == 4)
            {
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Chave 1");
                Console.WriteLine("-------------------------------------");
                numerosIguais = numerosComuns(numeros, chaveNumeros, catNumeros);
                estrelasIguais = numerosComuns(estrelas, chaveEstrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Chave 2");
                Console.WriteLine("-------------------------------------");
                numerosIguais1 = numerosComuns(numeros1, chaveNumeros, catNumeros);
                estrelasIguais1 = numerosComuns(estrelas1, chaveEstrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Chave 3");
                Console.WriteLine("-------------------------------------");
                numerosIguais2 = numerosComuns(numeros2, chaveNumeros, catNumeros);
                estrelasIguais2 = numerosComuns(estrelas2, chaveEstrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Chave 4");
                Console.WriteLine("-------------------------------------");
                numerosIguais3 = numerosComuns(numeros3, chaveNumeros, catNumeros);
                estrelasIguais3 = numerosComuns(estrelas3, chaveEstrelas, catEstrelas);
            }
            else if (quantasChaves == 5)
            {
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Chave 1");
                Console.WriteLine("-------------------------------------");
                numerosIguais = numerosComuns(numeros, chaveNumeros, catNumeros);
                estrelasIguais = numerosComuns(estrelas, chaveEstrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Chave 2");
                Console.WriteLine("-------------------------------------");
                numerosIguais1 = numerosComuns(numeros1, chaveNumeros, catNumeros);
                estrelasIguais1 = numerosComuns(estrelas1, chaveEstrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Chave 3");
                Console.WriteLine("-------------------------------------");
                numerosIguais2 = numerosComuns(numeros2, chaveNumeros, catNumeros);
                estrelasIguais2 = numerosComuns(estrelas2, chaveEstrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Chave 4");
                Console.WriteLine("-------------------------------------");
                numerosIguais3 = numerosComuns(numeros3, chaveNumeros, catNumeros);
                estrelasIguais3 = numerosComuns(estrelas3, chaveEstrelas, catEstrelas);
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Chave 5");
                Console.WriteLine("-------------------------------------");
                numerosIguais4 = numerosComuns(numeros4, chaveNumeros, catNumeros);
                estrelasIguais4 = numerosComuns(estrelas4, chaveEstrelas, catEstrelas);
            }
            else
            {
                //COMPARAÇÃO DE CHAVE COMPOSTA
                Console.WriteLine("");
                numerosIguaisComposta = numerosComuns(numerosComposta, chaveNumeros, catNumeros);
                estrelasIguaisComposta = numerosComuns(estrelasComposta, chaveEstrelas, catEstrelas);
            }

            //PRÉMIO FINAL
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("O prémio final é de " + ((numerosIguais + estrelasIguais + numerosIguais1 + estrelasIguais1 + numerosIguais2 + estrelasIguais2 + numerosIguais3 + estrelasIguais3 + numerosIguais4 + estrelasIguais4 + numerosIguaisComposta + estrelasIguaisComposta) * 3) + "E!");
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" ");
        }

        static void Main(string[] args)
        {
            bool voltarAjogar = true, val = false;
            string catNumeros = "Número", catEstrelas = "Estrela", resposta, pergunta;
            int temp = 0, numChaves = 0, qNumeros = 0, qEstrelas = 0;

            //CRIAÇÃO DE ARRAYS CHAVE PREMIADA
            int[] chaveNumeros = new int[5];
            int[] chaveEstrelas = new int[2];

            //ARRAYS DE CHAVES NORMAIS
            int[] numeros = new int[5];
            int[] numeros1 = new int[5];
            int[] numeros2 = new int[5];
            int[] numeros3 = new int[5];
            int[] numeros4 = new int[5];

            int[] estrelas = new int[2];
            int[] estrelas1 = new int[2];
            int[] estrelas2 = new int[2];
            int[] estrelas3 = new int[2];
            int[] estrelas4 = new int[2];

            while (voltarAjogar == true)
            {
                Console.WriteLine("Bem-vindo ao Euromilhões! Boa sorte!");
                //PERGUNTAR SE APOSTA NORMAL OU COMPOSTA
                do
                {
                    Console.WriteLine("Selecione a opção:");
                    Console.WriteLine("1) Aposta Normal");
                    Console.WriteLine("2) Aposta Composta");
                    resposta = Console.ReadLine();
                    //VALIDAR RESPOSTA
                    if (resposta == "1" || resposta == "2")
                    {
                        val = true;
                    }
                    else
                    {
                        Console.WriteLine("Valor introduzido não é válido.");
                        val = false;
                    }
                } while (val == false);

                //OPÇÃO APOSTA COMPOSTA
                if (resposta == "1")
                {
                    bool repete;
                    do
                    { //PERGUNTAR QUANTAS APOSTAS (COM VALIDAÇÃO)
                        try
                        {
                            Console.WriteLine("Por favor introduza o número de Chaves (1-5):");
                            temp = int.Parse(Console.ReadLine());
                            repete = false;
                            if (temp < 1 || temp > 5)
                            {
                                Console.WriteLine("Por favor introduza um número válido");
                            }
                        }
                        catch (Exception e)
                        {
                            repete = true;
                            Console.WriteLine("Por favor digite um número.");
                        }
                    }
                    while (temp < 1 || temp > 5 || repete);
                    numChaves = temp;
                }
                if (resposta == "2")
                {
                    qNumeros = lerQuantosNumerosComposta();
                    qEstrelas = lerQuantasEstrelasComposta();

                    //LIMITAÇÕES DE APOSTA COMPOSTA
                    if (qEstrelas >= 12)
                    {
                        if (qNumeros > 6)
                        {
                            qNumeros = 6;
                            Console.WriteLine("Devido a limitações de aposta a quantidade de Números foi redefinida para 6.");
                        }
                    }
                    if (qNumeros >= 10)
                    {
                        if (qEstrelas > 3)
                        {
                            qEstrelas = 3;
                            Console.WriteLine("Devido a limitações de aposta a quantidade de Estrelas foi redefinida para 3.");
                        }
                    }
                }
                //ARRAYS CHAVE COMPOSTA
                int[] numerosComposta = new int[qNumeros];
                int[] estrelasComposta = new int[qEstrelas];

                //PERGUNTAR OPÇÃO NÚMEROS ALEATÓRIOS
                pergunta = "Gostaria de jogar com números aleatórios? (Y/N)";
                resposta = validacao(pergunta);

                //OPÇÃO CHAVES ALEATÓRIAS
                if (resposta == "y" || resposta == "Y")
                {
                    val = false;

                    do
                    {
                        lerNumerosAleatorios(numeros, estrelas, numeros1, estrelas1, numeros2, estrelas2, numeros3, estrelas3, numeros4, estrelas4, numerosComposta, estrelasComposta, catEstrelas, catNumeros, numChaves);
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------");
                        pergunta = "Submeter Aposta (Y) | Gerar Nova Chave (N)";
                        resposta = validacao(pergunta);
                        //VALIDAR APOSTA OU GERAR NOVA CHAVE
                        if (resposta == "y" || resposta == "Y")
                        {
                            val = true;
                        }
                        else
                        {
                            val = false;
                        }
                    } while (val == false);

                }
                //OPÇÃO NÚMEROS INSERIDOS
                else
                {
                    do
                    {
                        //LER CHAVES
                        lerChaves(numeros, estrelas, numeros1, estrelas1, numeros2, estrelas2, numeros3, estrelas3, numeros4, estrelas4, numerosComposta, estrelasComposta, catEstrelas, catNumeros, numChaves);
                        //ESCREVER CHAVES 
                        escreverChaves(numeros, estrelas, numeros1, estrelas1, numeros2, estrelas2, numeros3, estrelas3, numeros4, estrelas4, numerosComposta, estrelasComposta, catNumeros, catEstrelas, numChaves);
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------------------");
                        //VALIDAR APOSTA OU INSERIR NOVAMENTE
                        pergunta = "Submeter Aposta (Y) | Introduzir Nova Chave (N)";
                        resposta = validacao(pergunta);

                        if (resposta == "y" || resposta == "Y")
                        {
                            val = true;
                        }
                        else
                        {
                            val = false;
                        }

                    } while (val == false);
                }

                //CHAVE PREMIADA ALEATÓRIA
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Chave Premiada EUROMILHÕES:");
                //NÚMEROS
                Console.Write("Números: ");
                numerosAleatorios(chaveNumeros, catNumeros);
                //ESTRELAS 
                Console.WriteLine("");
                Console.Write("Estrelas: ");
                numerosAleatorios(chaveEstrelas, catEstrelas);
                //PRÉMIO
                calcPremio(chaveNumeros, chaveEstrelas, numeros, estrelas, numeros1, estrelas1, numeros2, estrelas2, numeros3, estrelas3, numeros4, estrelas4, numerosComposta, estrelasComposta, catNumeros, catEstrelas, numChaves);
                //PERGUNTAR SE DESEJA JOGAR NOVAMENTE
                Console.WriteLine("Deseja jogar novamente? (Y/N)");
                resposta = Console.ReadLine();

                numChaves = 0;
                if (resposta == "y" || resposta == "Y")
                {
                    voltarAjogar = true;
                }
                else
                {
                    Console.WriteLine("Obrigado por ter jogado. Adeus!");
                    voltarAjogar = false;
                }
            } while (voltarAjogar == true) ;
            Console.ReadKey();
        }
    }
}




