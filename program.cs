namespace TP_02___POO___extra_Censo__Huberman_Solmesky;

class Program
{
    static void Main(string[] args)
    {
        string opcion;
        Superheroe superheroe1 = null, superheroe2 = null;
        opcion = IngresarOpcion("Ingresa la opcion que desees");
        while(opcion != "iv")
        {
            switch (opcion)
            {
                case "i": 
                    superheroe1 = ObtenerSuperheroe();
                    opcion = IngresarOpcion("Ingresa la opcion que desees");
                    break;
                case "ii": 
                    superheroe2 = ObtenerSuperheroe();
                    opcion = IngresarOpcion("Ingresa la opcion que desees");
                    break;
                case "iii": 
                if (superheroe1 != null && superheroe2 != null)
                {
                    Superheroe superheroeGanador = null;
                    double puntosDeDiferencia = 0;
                    if (superheroe1.ObtenerSkill()> superheroe2.ObtenerSkill())
                    {
                        superheroeGanador = superheroe1;
                        puntosDeDiferencia = superheroe1.ObtenerSkill()- superheroe2.ObtenerSkill();
                    }
                    else if (superheroe1.ObtenerSkill()< superheroe2.ObtenerSkill())
                    {
                        superheroeGanador = superheroe2;
                        puntosDeDiferencia = superheroe2.ObtenerSkill()- superheroe1.ObtenerSkill();
                    }
                    else 
                    {
                        Console.WriteLine("Empataron");
                    }   

                    if(puntosDeDiferencia > 30)
                    {
                        Console.WriteLine($"Ganó {superheroeGanador.Nombre} por amplia diferencia");
                    }
                    else if(puntosDeDiferencia > 10)
                    {
                        Console.WriteLine($"Ganó {superheroeGanador.Nombre}. ¡Fue muy parejo!");
                    }
                    else if (puntosDeDiferencia > 0)
                    {
                        Console.WriteLine($"Ganó {superheroeGanador.Nombre}. ¡No le sobró nada!");
                    }
                }

                    
                    opcion = IngresarOpcion("Ingresa la opcion que desees");
                    break;
            
            }
        }
        
    }

    static Superheroe ObtenerSuperheroe()
    {
        Superheroe r;
        double peso, fuerza, velocidad;
        string nombre, ciudad;
        nombre = IngresarString("ingrese su nombre");
        ciudad = IngresarString("ingrese la ciudad donde vive");
        peso = IngresarPeso("ingrese su peso");
        fuerza = IngresarFuerzaYVelocidad("ingrese su fuerza");
        velocidad = IngresarFuerzaYVelocidad("ingrese su velocidad");

        r = new Superheroe(peso, nombre, ciudad, fuerza, velocidad);
        return r;
    }
    static double IngresarFuerzaYVelocidad (string m)
    {
        double r;
        do{
            Console.WriteLine(m);
            r = double.Parse(Console.ReadLine());
        }while(r< 1 || r>100);
        return r;
    }
    static double IngresarPeso (string m)
    {
        double r;
        do{
            Console.WriteLine(m);
            r = double.Parse(Console.ReadLine());
        }while(r< 1);
        return r;
    }
    static string IngresarString (string m)
    {
        string r;
        do{
            Console.WriteLine(m);
            r = Console.ReadLine();
        }while(r!= string.Empty);
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
