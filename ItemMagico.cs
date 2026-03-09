namespace ComercianteDeArcadia
{

    public class ItemMagico
    {
        public string Nome;
        public double Preco;
        public RaridadeEnum Raridade;

        public ItemMagico()
        {
            Nome = "Desconhecido";
            Preco = 0.0;
            Raridade = RaridadeEnum.Comum;
        }

        public ItemMagico(string nome, double preco, RaridadeEnum Raridade)
        {
            SetNome(nome);
            SetPreco(preco);
            SetRaridade(Raridade);
        }
        public void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("Erro... O nome do item mágico não pode ser vazio!!!");
            }
            else Nome = nome;
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetPreco(double preco)
        {
            if (preco <= 0)
            {
                Console.WriteLine("Erro!!.... O preço deve ser maior que zero.");
            }
            else
            {
                Preco = preco;
            }
        }
        public double GetPreco()
        {
            return Preco;
        }
        public void SetRaridade(RaridadeEnum raridade)
        {
            Raridade = raridade;
        }
        public RaridadeEnum GetRaridade()
        {
            return Raridade;
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine("\t\tItem Magíco");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: {Preco:C2}");
            Console.WriteLine($"Raridade: {Raridade}");
        }
    }
}