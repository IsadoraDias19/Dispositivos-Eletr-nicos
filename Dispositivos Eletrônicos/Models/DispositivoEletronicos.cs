namespace Dispositivos_Eletrônicos.Models
{
    public abstract class DispositivoEletronicos
    {
        public string Marca {  get; set; }

        public string Modelo { get; set;}

        public int AnoDeFabricacao { get; set;}
        //é um método 

        public abstract string ExibirDetalhes();
    }
}
