Console.WriteLine("Lista de compras!\n");

string[] produtos = new string[10] { "Macarrão", "Arroz", "Cebola", "Tomate", "Suco", "Refrigerante", "Maionese", 
 "Feijão", "Queijo", "Presunto" };
string[] carrinhoCompras = new string[10];

int contador = 0;

Console.WriteLine("Digite S para os produtos que você quer e N para os que você não quer!\n");

for (int i = 0; i < produtos.Length; i++)
{
    Console.WriteLine(produtos[i]);
    carrinhoCompras[i] = Console.ReadLine();

    if (carrinhoCompras[i] == "S")
    {
        contador = contador + 1;
    }
}

if (contador > 0)
{
    Console.WriteLine("\nLista de compras:\n");

    for (int i = 0; i < produtos.Length; i++)
    {
        if (carrinhoCompras[i] == "S")
        {
            Console.WriteLine(produtos[i]);
        }
    }
}
else
{
    Console.WriteLine("Você não escolheu nenhum produto!");
}