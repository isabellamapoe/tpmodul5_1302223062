using System;

<<<<<<< HEAD
class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah : " + data);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Masukkan data:");
        string Data = Console.ReadLine();

        DataGeneric<string> dataString = new DataGeneric<string>(Data);
        dataString.PrintData();

        
=======
class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine("Hello User " + nama + " ~");
    }

    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();

        Console.WriteLine("Masukkan nama anda:");
        string nama = Console.ReadLine();

        halo.SapaUser(nama);
>>>>>>> 008ef129674e32d6c1158169979bcc5612f7db2f
    }
}
