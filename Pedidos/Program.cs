using Pedidos.Entities.Enum;
using Pedidos.Entities;
using Sytey.Globalization;
internal class Program

{
	private static void Main(string[] args)
	{
		// Fazer um mini programa console utilizando algumas classses e enums, para cadastrar produtos e mostrar a situação //
		
		// D A D O S	C L I E N T E //

		Console.WriteLine("Enter Client Data: ");
		Console.WriteLine();

		Console.Write(">> Name: "); // Nome do Cliente
		string name = Console.ReadLine();

		Console.Write(">> Email: "); // Email
		string email = Console.ReadLine();

		Console.Write(">> Birth Date: (dd/mm/yyyy): "); // Data de nascimento
		DateTime birthdate = DateTime.Parse(Console.ReadLine());

		Clients dados_clientes = new(name, email, birthdate);

		Console.WriteLine();

		Console.WriteLine("Enter Order Data: ");

		Console.WriteLine();

		Console.Write(">> Status: "); // Status do Pedido
		OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

		Order dados_gerais = new(DateTime.Now, status, dados_clientes);

		Console.WriteLine();

		Console.Write(">> How many items to to this order? "); // Quantidade
		int order_quantity = int.Parse(Console.ReadLine());


		// P R O D U T O S //


		for (int inicio = 1; inicio <= order_quantity; inicio++)
		{
			Console.WriteLine();

			Console.Write("Product Name: ");
			string product_name = Console.ReadLine();

			Console.Write("Product Price: ");
			double product_price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Product product = new Product(product_name, inicio);

			Console.Write("Quantity: ");
			int product_quantity = int.Parse(Console.ReadLine());

			OrderItem orderItem = new OrderItem(product_quantity, product_price, product);

			dados_gerais.AddItem(orderItem);

			Console.WriteLine();


		}

		Console.WriteLine("O R D E R	S U M A R Y");
		Console.WriteLine();
		Console.WriteLine(dados_gerais);








































	}
}
