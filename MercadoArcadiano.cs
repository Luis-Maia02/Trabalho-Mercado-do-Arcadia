namespace ComercianteDeArcadia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ItemMagico item1 = new ItemMagico("Espada Flamejante", 150.0, RaridadeEnum.Raro);
            ItemMagico item2 = new ItemMagico("Armadura de Gelo", 200.0, RaridadeEnum.Raro);


            item1.ExibirInformacoes();

            item2.ExibirInformacoes();
            Console.WriteLine($"\nAtualizando o preço do item {item1.GetNome()}...");
            item1.SetPreco(180.0);
            Console.WriteLine($"Novo preço do item {item1.GetNome()}: {item1.GetPreco():C2}");
            
            


        }
    }
}
