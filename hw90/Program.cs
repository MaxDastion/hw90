using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Xml;

public class MyClass2
{
    public int Num { get; set; }
    public string str { get; set; }
    public List<double> DNum { get; set; }
}

public class MyClass1
{
    public List<int> Nums { get; set; }
    public List<MyClass2> Class2List { get; set; }

    public MyClass1()
    {
        Nums = new List<int> { 1, 2, 3 };
        Class2List = new List<MyClass2>
        {
            new MyClass2 { Num = 10, str = "Sample", DNum = new List<double> { 1.1, 2.2, 3.3 } },
            new MyClass2 { Num = 20, str = "Example", DNum = new List<double> { 4.4, 5.5, 6.6 } }
        };
    }
}

class MyMain
{
    static void Main(string[] args)
    {
        MyClass1 obj = new MyClass1();

        string json = JsonConvert.SerializeObject(obj);

        File.WriteAllText("data.json", json);

        Console.WriteLine("JSON есть");
    }
}
