using System;
using System.Linq.Expressions;

// Tekli Kalıtım
class Hayvanlar
{
    public void Yemek()
    {
        Console.WriteLine("Hayvanlar Yemek Yer");
    }
}

class Kopekler : Hayvanlar { 
    public void Havlamak()
    {
        Console.WriteLine("Köpekler havlar");
    }
}

// Çok Düzeyli Kalıtım

class Memeliler : Hayvanlar
{
    public void Kosmak()
    {
        Console.WriteLine("Memeliler koşar");

    }
}

class Koyunlar : Memeliler
{
    public void Melemek ()
    {
        Console.WriteLine("Koyunler meler");

    }
}
// Hiyerarşik Kalıtım
class Kuslar : Hayvanlar
{
    public void Ucmak()
    {
        Console.WriteLine("Kuşlar Uçar");
    }
}

class Serce : Kuslar
{
    public void Kucuk()
    {
        Console.WriteLine("Serçeler Küçüktür");
    }
}

class Penguen : Kuslar
{
    public void Yuzmek()
    {
        Console.WriteLine("Penguenler Yüzer");
    }
}

// Çoklu Kalıtım

interface I1
{
    void Method1();
}

interface I2
{
    void Method2();
}

class XYZ : I1, I2 
{
    public void Method1()
    {
        Console.WriteLine("Anne Özelliği");
    }

    public void Method2()
    {
        Console.WriteLine("Baba Özelliği");
    }
}

// main program

class Program
{
    static void Main(string[] args)
    {
        // tekli kalıtım
        Kopekler kopekler1 = new Kopekler();

        kopekler1.Yemek();
        kopekler1.Havlamak();

        // Çok düzeyli kalıtım

        Koyunlar koyunlar1 = new Koyunlar();
        koyunlar1.Melemek();
        koyunlar1.Kosmak();
        koyunlar1.Yemek();

        // Hiyerarşik Kalıtım

        Serce serce1 = new Serce();
        Penguen penguen1 = new Penguen();
        serce1.Ucmak();
        serce1.Kucuk();
        penguen1.Yuzmek();
        penguen1.Ucmak();

        XYZ cocuk = new XYZ();
        cocuk.Method1();
        cocuk.Method2();






    }
}


