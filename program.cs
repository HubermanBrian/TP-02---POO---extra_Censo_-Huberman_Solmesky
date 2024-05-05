namespace TP_02___POO___extra_Censo__Huberman_Solmesky;

class Program
{
    static void Main(string[] args)
    {
        string opcion;
        opcion = IngresarOpcion("Ingresa la opcion que desees");
    }
    static string IngresarOpcion(string m)
    {
        string r;
        do
        {
            Console.WriteLine(m);
            r = Console.ReadLine();
        }while (r!= "i" && r!= "ii" && r!= "iii" && r!= "iv");
        return r;
    }
}
