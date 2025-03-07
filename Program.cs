using Microsoft.Win32;
using Registro_de_Campos;
using System.Text.RegularExpressions;

class Programa
{
    
    static void Main()
    {
        // Chama o método para detectar as versões e exibi-las.
        List<SoftwareVersao> lista = DetectarVersao();

        // Exibe as versões de cada software
        foreach (var software in lista)
        {
            Console.WriteLine($"{software.Software} -> {software.Versao}");
        }
        Console.ReadKey();


    }

    public static void DetectarVersaoAutoCad(List<SoftwareVersao> listaDasVersoesDoAutoCad, string caminhoParaORegistry, string nomeDoSoftware)
    {
        RegistryKey chaveRegistro = Registry.LocalMachine.OpenSubKey(caminhoParaORegistry);
        if (chaveRegistro != null)
        {
            string[] nomeVersaoAutoCad = chaveRegistro.GetSubKeyNames();
            foreach (string versao in nomeVersaoAutoCad)
            {
                switch (versao)
                {
                    case "R21.0":
                        listaDasVersoesDoAutoCad.Add(new SoftwareVersao { Software = "AutoCad", Versao = "2017", Chave = $"{caminhoParaORegistry}\\{versao}" });
                        break;
                    case "R22.0":
                        listaDasVersoesDoAutoCad.Add(new SoftwareVersao { Software = "AutoCad", Versao = "2018", Chave = $"{caminhoParaORegistry}\\{versao}" });
                        break;
                    case "R23.0":
                        listaDasVersoesDoAutoCad.Add(new SoftwareVersao { Software = "AutoCad", Versao = "2019", Chave = $"{caminhoParaORegistry}\\{versao}" });
                        break;
                    case "R23.1":
                        listaDasVersoesDoAutoCad.Add(new SoftwareVersao { Software = "AutoCad", Versao = "2020", Chave = $"{caminhoParaORegistry}\\{versao}" });
                        break;
                    case "R24.0":
                        listaDasVersoesDoAutoCad.Add(new SoftwareVersao { Software = "AutoCad", Versao = "2021", Chave = $"{caminhoParaORegistry}\\{versao}" });
                        break;
                    case "R24.1":
                        listaDasVersoesDoAutoCad.Add(new SoftwareVersao { Software = "AutoCad", Versao = "2022", Chave = $"{caminhoParaORegistry}\\{versao}" });
                        break;
                    case "R24.2":
                        listaDasVersoesDoAutoCad.Add(new SoftwareVersao { Software = "AutoCad", Versao = "2023", Chave = $"{caminhoParaORegistry}\\{versao}" });
                        break;
                    case "R24.3":
                        listaDasVersoesDoAutoCad.Add(new SoftwareVersao { Software = "AutoCad", Versao = "2024", Chave = $"{caminhoParaORegistry}\\{versao}" });
                        break;
                    case "R25.0":
                        listaDasVersoesDoAutoCad.Add(new SoftwareVersao { Software = "AutoCad", Versao = "2025", Chave = $"{caminhoParaORegistry}\\{versao}" });
                        break;
                    default:
                        break;
                }
            }
        }
    }

    // Método para verificar se a subchave é uma versão válida (somente números e pontos).
    public static bool ValidacaoDaVersao(string nomeDaVersao)
    {
        // Regex que verifica se a string começa com número com "V" e "R" e contém somente números, pontos e "X".
        return Regex.IsMatch(nomeDaVersao, @"^V?R?\d+(\.\d+)*X?$");
    }

    public static void DetectarVersao(List<SoftwareVersao> listasDasVersoes, string caminhoParaORegistry, string nomeDoSoftwares)
    {
        RegistryKey chaveRegistro = Registry.LocalMachine.OpenSubKey(caminhoParaORegistry);
        if (chaveRegistro != null)
        {
            string[] nomesSubChaves = chaveRegistro.GetSubKeyNames();
            foreach (string nomeDaVersao in nomesSubChaves)
            {
                // Verifica se a subchave contém um número (pode ser versão).
                if (ValidacaoDaVersao(nomeDaVersao))
                {
                    listasDasVersoes.Add(new SoftwareVersao { Software = nomeDoSoftwares, Versao = nomeDaVersao, Chave = $"{caminhoParaORegistry}\\{nomeDaVersao}" });
                }
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
        DetectarVersaoAutoCad(lista, @"SOFTWARE\AUTODESK\AUTOCAD", "AutoCad");

        return lista;

       
    }
}
