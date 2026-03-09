
namespace ComercianteDeArcadia
{
    public class ArtefatoMagico : ItemMagico
    {
        public string PoderEspecial;


        public ArtefatoMagico()
        {
            PoderEspecial = "Desconhecido";


        }
        public ArtefatoMagico(string Nome, double Preco, RaridadeEnum Raridade, string PoderEspecial) : base(Nome, Preco, Raridade)
        {
            SetNome(Nome);
            SetPreco(Preco);
            SetPoderEspecial(PoderEspecial);
            SetRaridade(Raridade);

        }

        public void SetPoderEspecial(string poderEspecial)
        {
            if (string.IsNullOrWhiteSpace(poderEspecial))
            {
                Console.WriteLine("Erro!!.... O nome do poder especial não pode ser vazio.");
            }
            else
            {
                PoderEspecial = poderEspecial;
            }
        }
        public string GetPoderEspecial()
        {
            return PoderEspecial;
        }
    }
}