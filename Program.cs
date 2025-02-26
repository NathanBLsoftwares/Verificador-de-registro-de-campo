using System;
using Microsoft.VisualBasic;
using Microsoft.Win32;

class Programa
{
    static void Main()
    {

        ///Verificação das versões do AutoCad
        RegistryKey? chaveRegistro = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\AUTODESK\AUTOCAD");
        if(chaveRegistro != null)
        {
            string[] nomesSubChaves = chaveRegistro.GetSubKeyNames();
            foreach(string CadVersion in nomesSubChaves)
            {
                switch(CadVersion)
                {
                    case "R21.0" :
                        Console.WriteLine("\t AutoCad -> 2017");
                        break;
                    case "R22.0" :
                        Console.WriteLine("\t AutoCad -> 2018");
                        break;
                    case "R23.0" :
                        Console.WriteLine("\t AutoCad -> 2019");
                        break;
                    case "R23.1" :
                        Console.WriteLine("\t AutoCad -> 2020");
                        break;
                    case "R24.0" :
                        Console.WriteLine("\t AutoCad -> 2021");
                        break;
                    case "R24.1" :
                        Console.WriteLine("\t AutoCad -> 2022");
                        break;
                    case "R24.2" :
                        Console.WriteLine("\t AutoCad -> 2023");
                        break;
                    case "R24.3" :
                        Console.WriteLine("\t AutoCad -> 2024");
                        break;
                    case "R25.0" :
                        Console.WriteLine("\t AutoCad -> 2025");
                        break;
                    default:
                        break;
                }
            
            }
        
        }else
        {
            Console.WriteLine("Nenhuma versão encontrada do AUTOCAD");
        }

        //Verificação das versões do BRICSCAD
        //Abrir chave de rigistro
        chaveRegistro = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\BRICYSOFT\BRICSCAD");
        if(chaveRegistro != null)
        {
            string [] nomesSubChaves = chaveRegistro.GetSubKeyNames();
            Console.WriteLine("****************");
            Console.WriteLine("VERSÕES BRICSCAD");
            Console.WriteLine("****************");
            foreach(string subChaves in nomesSubChaves)
            {
                Console.WriteLine($"\tBRICSAD versão -> {subChaves}" );
            }
            chaveRegistro.Close();
        }
        else
        {
            Console.WriteLine("Nenhuma Versão encontrada do BRICSCAD");
        }




        //Verificação das versões do GSTARCAD
        //Abrir chave de rigistro
        chaveRegistro = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\GSTARSOFT\GSTARCAD");
        if(chaveRegistro != null)
        {
            string [] nomesSubChaves = chaveRegistro.GetSubKeyNames();
            Console.WriteLine("****************");
            Console.WriteLine("VERSÕES GSTARCAD");
            Console.WriteLine("****************");
            foreach(string subChaves in nomesSubChaves)
            {
                Console.WriteLine($"\tGSTARCAD versão -> {subChaves}" );
            }
            chaveRegistro.Close();
        }
        else
        {
            Console.WriteLine("Nenhuma Versão encontrada do GSTARCAD");
        }

        //Verificação das versões do ZWCAD
        //Abrir chave de rigistro
        chaveRegistro = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\ZWSOFT\ZWCAD");
        if(chaveRegistro != null)
        {
            string [] nomesSubChaves = chaveRegistro.GetSubKeyNames();
            Console.WriteLine("*************");
            Console.WriteLine("VERSÕES ZWCAD");
            Console.WriteLine("**************");
            foreach(string subChaves in nomesSubChaves)
            {
                Console.WriteLine($"\tZWCAD versão -> {subChaves}" );
            }
            chaveRegistro.Close();
        }
        else
        {
            Console.WriteLine("Nenhuma Versão encontrada do ZWCAD");
        }


    }
}