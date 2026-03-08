namespace ComercianteDeArcadia
{
    public class PocaoMagica : ItemMagico
    {
        public string Efeito;

        public PocaoMagica()
        {
            Efeito = "Descohecido";
        }
        public PocaoMagica(string Efeito, string Nome, double Preco, RaridadeEnum Raridade) : base(Nome, Preco, Raridade)
        {
            SetEfeito(Efeito);
            SetNome(Nome);
            SetPreco(Preco);
            SetRaridade(Raridade);
        }

        public void SetEfeito(string efeito)
        {
            if (string.IsNullOrWhiteSpace(efeito))
            {
                Console.WriteLine("Erro... O efeito da poção não pode ser vazio!!!");
            }
            else Efeito = efeito;
        }
        public string GetEfeito()
        {
            return Efeito;
        }
    }
}
