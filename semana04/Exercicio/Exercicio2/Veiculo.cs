using System.Security.Cryptography.X509Certificates;

namespace Namespace;
public class Veiculo
{
   public string Modelo { get; set; }
    public string Cor { get; set; }
    public int Ano { get; set; } = 0;

    public int IdadeAtual{get}{
      return   var idade = DateTime.Now.Year - Ano;
    }

}
