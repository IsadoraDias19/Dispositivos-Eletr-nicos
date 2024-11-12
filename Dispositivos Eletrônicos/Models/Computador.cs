namespace Dispositivos_Eletrônicos.Models
{
    //Essa linha é responsavel por herdar o DispositivosEletronicos 
   public class Computador : DispositivoEletronicos 
    {
        public bool EhLaptop { get; set; }

        public int MemoriaRam { get; set; }

        public string SistemaOperacional { get; set;}

    public override string ExibirDetalhes()
    {
        return $"Marca:{Marca}, Modelo: {Modelo}, Ano: {AnoDeFabricacao},S0:{SistemaOperacional} ";
       
    }
 
    }
}
