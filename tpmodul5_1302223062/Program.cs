using System;

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
    }
}
