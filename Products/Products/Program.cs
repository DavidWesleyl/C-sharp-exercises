using System.Globalization;
using Products.Entities;
internal class Program

{
	private static void Main(string[] args)
	{
        /*	Fazer um programa para ler os dados de N produtos (N fornecido pelo usuário). Ao final, mostrar a etiqueta de preço de cada produto na
		mesma ordem em que foram digitados.
  
		Todo produto possui nome e preço. Produtos importados possuem uma taxa de alfândega, e produtos usados possuem data de fabricação.
		Estes dados específicos devem ser acrescentados na etiqueta de preço
		Para produtos importados, a taxa e alfândega deve ser acrescentada ao preço final do produto */



        Console.Write("Enter the number of Products: ");
	int quantity = int.Parse(Console.ReadLine());

	List<Product> client_products = new List<Product>();


	for(int inicio = 1; inicio <= quantity; inicio++)
	{
	    Console.WriteLine();

            Console.WriteLine($"Product #{inicio} data: ");
            Console.WriteLine();
            Console.Write("Common / used / import ( c | u | i ): ");
	    char type_product = char.Parse(Console.ReadLine());

            if ( type_product == 'c')
			{
                Console.WriteLine();

                Console.Write("Name: ");
				string name = Console.ReadLine();

                Console.Write("Price: ");
				double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

				client_products.Add(new Product(name, price));

                Console.WriteLine();
            }

			else if ( type_product == 'u')
			{
                Console.WriteLine();

                Console.Write("Name: ");
				string name = Console.ReadLine();

				Console.Write("Price: ");
				double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

				Console.Write("Manufacture Data: ");
				DateTime manufacture = DateTime.Parse(Console.ReadLine());

				client_products.Add(new UsedProduct(name, price, manufacture));

                Console.WriteLine();

            }

			else if( type_product == 'i')
			{
                Console.WriteLine();

                Console.Write("Name: ");
				string name = Console.ReadLine();

				Console.Write("Price: ");
				double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Customs fee R$:");
				double customs_fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

				client_products.Add(new ImportedProduct(name, price, customs_fee));

                Console.WriteLine();
            }




        }

        Console.WriteLine();

        foreach (Product client_product in client_products)
		{
			Console.WriteLine(client_product.PriceTag());
		}





































































    }
}
