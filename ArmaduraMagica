namespace ComercianteDeArcadia
{
    public class ArmaduraMagica : ItemMagico
    {
        public string Defesa;

        public ArmaduraMagica()
        {
            Defesa = "Desconecido";
        }
        public ArmaduraMagica(string Defesa, string Nome, double Preco, RaridadeEnum Raridade) : base(Nome, Preco, Raridade)
        {
            SetDefesa(Defesa);
            SetNome(Nome);
            SetPreco(Preco);
            SetRaridade(Raridade);
        }
        public void SetDefesa(string defesa)
        {
            if (string.IsNullOrWhiteSpace(defesa))
            {
                Console.WriteLine("Erro... A defesa da armadura não pode ser vazia!!!");
            }
            else Defesa = defesa;
        }
        public string GetDefesa()
        {
            return Defesa;
        }
    }
}
