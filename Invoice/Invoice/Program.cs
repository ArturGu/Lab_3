using System;

namespace Invoice
{
    class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;
        public Invoice(int Account, string Customer, string Provider)
        {
            this.account = Account;
            this.customer = Customer;
            this.provider = Provider;
        }

        public string Article { get; set; }
        public int Quantity { get; set; }


        public double Price()
        {
            double price = 250;
            double sum = 0;

            if (Quantity > (account / price))
            {
                Console.WriteLine("У вас недостатньо грошей на рахунку!");
            }
            else if (Article == "Y")
            {
                double tax = 0.2;
                sum = (price * Quantity) + (price * Quantity) * tax;
                Console.WriteLine($"Ціна з ПДВ = {sum}.");
            }
            else if (Article == "N")
            {
                sum = (price * Quantity);
                Console.WriteLine($"Ціна без ПДВ = {sum}.");
            }

            return sum;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Виберiть спосiб розрахунку цiни з (ПДВ) чи без!");
            Console.Write("Введiть Так(Y) чи Ні(N): ");

            Invoice invoice = new Invoice(50000, "Гутник Артур", "Rozetka");
            string article = Console.ReadLine();
            invoice.Article = article;

            Console.Write("Введiть кiлькiсть товару: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            invoice.Quantity = quantity;

            invoice.Price();
            Console.ReadKey();
        }
    }
}
