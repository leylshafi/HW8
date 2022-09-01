namespace Task3;


struct Client
{
    public Guid ClientCode { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public int NumberOfOrder { get; set; }
    public int TotalAmount { get; set; }

    public Client(Guid clientCode, string fullName, string address, string phone, int numberOfOrder, int totalAmount)
    {
        ClientCode = clientCode;
        FullName = fullName;
        Address = address;
        Phone = phone;
        NumberOfOrder = numberOfOrder;
        TotalAmount = totalAmount;
    }


    public static double operator +(Client q1, Client q2)
    {
        return q1.NumberOfOrder+q2.NumberOfOrder;
    }

    public static double operator -(Client q1, Client q2)
    {
        return q1.NumberOfOrder - q2.NumberOfOrder;
    }
    public static double operator *(Client q1, Client q2)
    {
        return q1.NumberOfOrder * q2.NumberOfOrder;
    }

    public static double operator /(Client q1, Client q2)
    {
        if (q2.NumberOfOrder != 0)
            return q1.NumberOfOrder / q2.NumberOfOrder;
        throw new DivideByZeroException();
    }

    public static bool operator ==(Client q1, Client q2)
    {
        return q1.NumberOfOrder == q2.NumberOfOrder;
    }

    public static bool operator !=(Client q1, Client q2)
    {
        return q1.NumberOfOrder != q2.NumberOfOrder;
    }
    public static bool operator >(Client q1, Client q2)
    {
        return q1.NumberOfOrder > q2.NumberOfOrder;
    }
    public static bool operator <(Client q1, Client q2)
    {
        return q1.NumberOfOrder < q2.NumberOfOrder;
    }

    public static Client operator ++(Client a)
    {
        a.NumberOfOrder++;
        return a;
    }
    public static Client operator --(Client a)
    {
        a.NumberOfOrder--;
        return a;
    }

    public override string ToString()
    {
        return ($"Client Code {ClientCode}," +
            $"Full name: {FullName}," +
            $"Address: {Address}," +
            $"Phone: {Phone}," +
            $"Number of Order: {NumberOfOrder}," +
            $"Total amount: {TotalAmount}");
    }
}

class Program
{
    static void Main()
    {

    }
}
