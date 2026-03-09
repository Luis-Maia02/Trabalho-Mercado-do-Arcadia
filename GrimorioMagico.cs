
namespace ComercianteDeArcadia
{
    public class GrimorioMagico : ItemMagico
    {
        public string Feitico;

        public GrimorioMagico()
        {
            Feitico = "Desconhecido";
        }
        public GrimorioMagico(string Nome, double Preco, RaridadeEnum Raridade, string Feitico) : base(Nome, Preco, Raridade)
        {
            SetNome(Nome);
            SetPreco(Preco);
            SetFeitico(Feitico);
            SetRaridade(Raridade);
        }
        public void SetFeitico(string feitico)
        {
            if (string.IsNullOrWhiteSpace(feitico))
            {
                Console.WriteLine("Erro!!.... O nome do feitiço não pode ser vazio.");
            }
            else
            {
                Feitico = feitico;
            }
        }
        public string GetFeitico()
        {
            return Feitico;
        }
    }
}