class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        string id = input[0];
        string title = input[1];
        int price = int.Parse(input[2]);
        int stock = int.Parse(input[3]);

        Book book = new Book(id, title, price, stock);
        BookUtility utility = new BookUtility(book);

        while (true)
        {
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    utility.GetBookDetails();
                    break;

                case 2:
                    int newPrice = int.Parse(Console.ReadLine());
                    utility.UpdateBookPrice(newPrice);
                    break;

                case 3:
                    int newStock = int.Parse(Console.ReadLine());
                    utility.UpdateBookStock(newStock);
                    break;

                case 4:
                    Console.WriteLine("Thank You");
                    return;
            }
        }
    }
}
