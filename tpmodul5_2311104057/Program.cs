public class DataGeneric<T>
{
    private T data;
    // Konstruktor dengan parameter
    public DataGeneric(T data)
    {
        this.data = data;
    }
    // Method untuk menampilkan data
    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah :" + data);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Membuat objek dari kelas DataGeneric dengan tipe NIM sebagai data
        DataGeneric<string> dataNIM = new DataGeneric<string>("2311104057");
        // Memanggil method PrintData
        dataNIM.PrintData();
    }
}