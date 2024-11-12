namespace Dispositivos_Eletrônicos.Models
{
    public class Smartphone : DispositivoEletronicos
    {
        public bool Tem5G { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {AnoDeFabricacao}, 5G: {(Tem5G ? "Sim" : "Não")}";

        }
    }
}
