namespace Task1;


class MyDictionary
{
    public string[][] Dictionary { get; set; }
    public MyDictionary()
    {
        Dictionary = new string[11][];
    }
    public string[] this[int index]
    {
        get => Dictionary[index];
        set => Dictionary[index] = value;
    }
    
}

class Program
{
    static void Main()
    {
        MyDictionary dic1= new MyDictionary();
        dic1[0] = new string[3] {"air", "[eə]", " hava" };
        dic1[1] = new string[3] { "allow ", "[əla u]", " icazə vermək" };
        dic1[2] = new string[3] { "ancient", "[eɪ nʃsə n", "qədim, köhnə" };
        dic1[3] = new string[3] { "hungry", "[eə]", "ac" };
        dic1[4] = new string[3] { "air", "[eə]", "hava" };
        dic1[5] = new string[3] { "air", "[eə]", "hava" };
        dic1[6] = new string[3] { "air", "[eə]", "hava" };
        dic1[7] = new string[3] { "air", "[eə]", "hava" };
        dic1[8] = new string[3] { "air", "[eə]", "hava" };
        dic1[9] = new string[3] { "air", "[eə]", "hava" };
        dic1[10] = new string[3] { "air", "[eə]", "hava" };

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(dic1[i][j]);
            }
            Console.WriteLine();
        }

    }
}
