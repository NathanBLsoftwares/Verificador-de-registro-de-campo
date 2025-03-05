using Microsoft.Win32;
using Registro_de_Campos;

class Programa
{
    static void Main()
    {
        // Chama o método para detectar as versões e exibi-las.
        List<SoftwareVersao> lista = DetectarVersao();

        // Exibe as versões de cada software
        foreach (var software in lista)
            {
            switch (CadVersion)
                {
                case "R21.0":
                        Console.WriteLine("\t AutoCad -> 2017");
                        break;
                case "R22.0":
                        Console.WriteLine("\t AutoCad -> 2018");
                        break;
                case "R23.0":
                        Console.WriteLine("\t AutoCad -> 2019");
                        break;
                case "R23.1":
                        Console.WriteLine("\t AutoCad -> 2020");
                        break;
                case "R24.0":
                        Console.WriteLine("\t AutoCad -> 2021");
                        break;
                case "R24.1":
                        Console.WriteLine("\t AutoCad -> 2022");
                        break;
                case "R24.2":
                        Console.WriteLine("\t AutoCad -> 2023");
                        break;
                case "R24.3":
                        Console.WriteLine("\t AutoCad -> 2024");
                        break;
                case "R25.0":
                        Console.WriteLine("\t AutoCad -> 2025");
                        break;
                    default:
                        break;
                }
            }
        }

    public static void DetectarVersao(List<SoftwareVersao> lista, string chave, string software)
        {
        RegistryKey chaveRegistro = Registry.LocalMachine.OpenSubKey(chave);
        if (chaveRegistro != null)
            {
            string[] nomesSubChaves = chaveRegistro.GetSubKeyNames();
            foreach (string nome in nomesSubChaves)
            {
                lista.Add(new SoftwareVersao { Software = software, Versao = nome, Chave = $"{chave}\\{nome}" });
                Console.WriteLine($"ZWcad Versão: {nome}");
            }
            chaveRegistro.Close();
        }
        }

    public static List<SoftwareVersao> DetectarVersao()
        {
        List<SoftwareVersao> lista = new List<SoftwareVersao>();
        DetectarVersao(lista, @"SOFTWARE\ZWSOFT\ZWCAD", "Zwcad");
        DetectarVersao(lista, @"SOFTWARE\GSTARSOFT\GSTARCAD", "Gstarcad");
        DetectarVersao(lista, @"SOFTWARE\BRICYSOFT\BRICSCAD", "Bricscad");

        return lista;
        }
        }