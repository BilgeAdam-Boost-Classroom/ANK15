namespace cafeUygulamasi
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            Cafe cafe = new Cafe();

            Menuu menu1 = new Menuu(new MenuItem("Espresso", 50, TimeSpan.FromSeconds(2)),
                new MenuItem("latte", 70, TimeSpan.FromSeconds(3)),
                new MenuItem("Turkish caffee", 30, TimeSpan.FromSeconds(3))

                );

            var c1 = new Customer("Sibel");
            cafe.GetInLine(c1);

            // var selectedItem = menu.menuItems.First(item => item.Name == "Espresso");

            var OrderItem = new OrderItem[]
            {
                new OrderItem(menu1["Espresso"],CoffeeSize.Small,new Milk(),new Syrup()),
            };
            while (!cafe.IsNext(c1))
            {
                await Task.Delay(2000);
            }
            while (!cafe.CanREgisterTakeOrder())
            {
                await Task.Delay(2000);
            }

        }
    }
}