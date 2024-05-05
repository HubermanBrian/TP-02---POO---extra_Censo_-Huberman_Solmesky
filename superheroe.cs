class Superheroe
{
    public double Peso {get;set;}
    public string Nombre {get;set;}
    public string Ciudad {get;set;}
    public double Fuerza {get;set;}
    public double Velocidad {get;set;}

    public Superhereoe(double peso, string nombre, string ciudad, double fuerza, double velocidad) 
    {
        Peso = dni;
        Nombre = apellido;
        Ciudad = nombre;
        Fuerza = fechaDeNacimiento;
        Velocidad = email;
    }

    public double ObtenerSkill()
    {
        double Skill;
        Random rnd = new Random();
        Skill = Velocidad*0.6 + Fuerza * 0.8 + rnd.Next(1,11);
        return Skill;
    }

}