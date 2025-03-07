namespace Registro_de_Campos;

class NomeDoSoftware
{
    public void NomeSoftware(string nome)
    {
        int quantidade = nome.Length;
        string asterisco = string.Empty.PadLeft(quantidade, '*');
        Console.WriteLine(asterisco);
        Console.WriteLine(nome);
        Console.WriteLine(asterisco);
    }
}
