namespace estudo;
class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Informe um número para criar a tabuada:");
       int num = int.Parse(Console.ReadLine());

       int[] tabuada = new int[11];

       for (int pas = 0; pas < tabuada.Length; pas++)
       {
            tabuada[pas] = num * pas;
       }

       Console.WriteLine($"A tabuada do {num} é:");
       for (int pas = 0; pas < tabuada.Length; pas++)
       {
            Console.WriteLine($"{num} x {pas} = {tabuada[pas]}");
       }
    }


}
