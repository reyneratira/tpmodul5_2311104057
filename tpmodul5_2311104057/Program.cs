class HaloGeneric
{
    // Method generic untuk menyapa user
    public static void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }

    public static void Main(string[] args)
    {
        // Memanggil method dengan input nama panggilan user
        Console.Write("Masukkan nama Anda: ");
        string nama = Console.ReadLine();
        SapaUser(nama);
    }
}