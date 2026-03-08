namespace ComercianteDeArcadia
{
    public class ArmaMagica : ItemMagico
    {
        public int Dano;

        public ArmaMagica()
        {
            Dano = 0;
        }
        public ArmaMagica(int Dano, string Nome, double Preco, RaridadeEnum Raridade) : base(Nome, Preco, Raridade)
        {
            SetDano(Dano);
            SetNome(Nome);
            SetPreco(Preco);
            SetRaridade(Raridade);
        }

        public void SetDano(int dano)
        {
            if (dano < 0) Console.WriteLine("ERRO... Dano negativo não é permitido!!!");
            else Dano = dano;
        }
        public int GetDano()
        {
            return Dano;
        }
    }
}
