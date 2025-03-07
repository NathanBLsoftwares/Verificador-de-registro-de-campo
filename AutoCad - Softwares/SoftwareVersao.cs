using Microsoft.Win32;
namespace Registro_de_Campos;

class SoftwareVersao
{
    public string Software { get; set; }
    public string Versao { get; set; }
    public bool Ativo { get; set; }
    public string Chave { get; set; }

    public override string ToString()
    {
        return base.ToString() ?? string.Empty;
    }



}
