﻿namespace TP_02___POO___extra_Censo__Huberman_Solmesky;

class Program
{
    static void Main(string[] args)
    {
        string opcion;
        Superheroe superheroe1, superheroe2;
        opcion = IngresarOpcion("Ingresa la opcion que desees");
        switch (opcion){
            case "i": 
                superheroe1 = ObtenerSuperheroe();
                opcion = IngresarOpcion("Ingresa la opcion que desees");
                break;
            case "ii": 
                superheroe2 = ObtenerSuperheroe();
                opcion = IngresarOpcion("Ingresa la opcion que desees");
                break;
            case "iii": 


                break;
            
        }
    }

    static Superheroe ObtenerSuperheroe()
    {

    }
    static double IngresarFuerzaYVelocidad (string m)
    {
        double r;
        do{
            Console.WriteLine(m);
            r = double.Parse(Console.ReadLine());
        }while(r< 1 || r>100)
        return r;
    }
    static double IngresarPeso (string m)
    {
        double r;
        do{
            Console.WriteLine(m);
            r = double.Parse(Console.ReadLine());
        }while(r< 1)
        return r;
    }
    static string IngresarString (string m)
    {
        string r;
        do{
            Console.WriteLine(m);
            r = Console.ReadLine();
        }while(r!= string.Empty)
        return r;
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
