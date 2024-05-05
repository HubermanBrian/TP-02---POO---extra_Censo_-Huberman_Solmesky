class Superheroe
{
    public double Peso {get;set;}
    public string Nombre {get;set;}
    public string Ciudad {get;set;}
    public double Fuerza {get;set;}
    public double Velocidad {get;set;}
    public double Inteligencia {get;set;}

    public Superheroe(double peso, string nombre, string ciudad, double fuerza, double velocidad, double inteligencia) 
    {
        Peso = peso;
        Nombre = nombre;
        Ciudad = ciudad;
        Fuerza = fuerza;
        Velocidad = velocidad;
        Inteligencia = inteligencia;
    }

    public double ObtenerSkill()
    {
        double Skill;
        Random rnd = new Random();
        Skill = Velocidad*0.6 + Fuerza * 0.8 + rnd.Next(1,11) + Inteligencia * 0.25;
        return Skill;
    }

}