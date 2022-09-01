namespace Task2;


class Article
{
    public string ProductName { get; set; } 
    public Guid ProductCode { get; set; } 
    public double Price { get; set; }

    public Article(string productName, Guid productCode, double price)
    {
        ProductName = productName;
        ProductCode = productCode;
        Price = price;
    }

    public static double operator+(Article a1, Article a2)
    {
        return a1.Price + a2.Price;
    }

    public static double operator -(Article a1, Article a2)
    {
        return a1.Price - a2.Price;
    }
    public static double operator *(Article a1, Article a2)
    {
        return a1.Price * a2.Price;
    }

    public static double operator /(Article a1, Article a2)
    {
        if(a2.Price!=0)
            return a1.Price / a2.Price;
        throw new DivideByZeroException();
    }

    public static bool operator ==(Article a1, Article a2)
    {
        return a1.Price == a2.Price;
    }

    public static bool operator !=(Article a1, Article a2)
    {
        return a1.Price != a2.Price;
    }
    public static bool operator >(Article a1, Article a2)
    {
        return a1.Price > a2.Price;
    }
    public static bool operator <(Article a1, Article a2)
    {
        return a1.Price < a2.Price;
    }

    public static Article operator ++(Article a)
    {
       a.Price++;
        return a;
    }
    public static Article operator --(Article a)
    {
        a.Price--;
        return a;
    }

    public override string ToString()
    {
        return ($"Product name: {ProductName}," +
            $"Product code: {ProductCode}," +
            $"Price: {Price}");
    }
}

class Program
{
    static void Main()
    {
        Article p1 = new Article("Product1",Guid.NewGuid(),20.5);
        Article p2 = new Article("Product2",Guid.NewGuid(),30.6);

        Console.WriteLine(p1+p2);
    }
}
