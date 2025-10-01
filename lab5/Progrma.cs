using System;

class Prices
{
  public int Drink;
  public int First;
  public int Second;

  public Prices(int drink, int first, int second)
  {
    Drink = drink;
    First = first;
    Second = second;
  }
}

class Choices
{
  public int DrinkQty;
  public int FirstQty;
  public int SecondQty;

  public Choices(int drink, int first, int second)
  {
    DrinkQty = drink;
    FirstQty = first;
    SecondQty = second;
  }
}

class Program
{
  static int CustomerTotal(Prices prices, Choices choices)
  {
    return choices.DrinkQty * prices.Drink +
           choices.FirstQty * prices.First +
           choices.SecondQty * prices.Second;
  }

  static void Main()
  {
    // Цены товаров
    Prices prices = new Prices(10, 20, 30);

    // Клиент 1: заказал 100г напитка, нет первого, 250г второго
    {
      Choices client1 = new Choices(100, 0, 250);
      int total1 = CustomerTotal(prices, client1);
      Console.WriteLine($"Стоимость заказа клиента 1: {total1}");
    }

    // Клиент 2: заказал нет напитка, 300г первого, нет второго
    {
      Choices client2 = new Choices(0, 300, 0);
      int total2 = CustomerTotal(prices, client2);
      Console.WriteLine($"Стоимость заказа клиента 2: {total2}");
    }
  }
}
