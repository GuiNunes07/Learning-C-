using System;

class Animais: seres
{
    public string raca;
    public string tipo;
    
    // get e set //
    
    public string GetRaca()
    {
        return raca;
    }
    public void SetRaca(string novaRaca)
    {
        raca = novaRaca;
    }
    
    public string GetTipo()
    {
        return tipo;
    }
    public void SetTipo(string novoTipo)
    {
        tipo = novoTipo;
    }
    
    public static void RegrasAnimal()
    {
        Console.WriteLine("Animais não são seres humandos");
    }
    
    public void Falar()
    {
        Console.WriteLine("Animais não falam, exceto papagai.");
    }
    
    public override void EmitirSom()
    {
        Console.WriteLine(raca + " fez: Au Au.");
    }
    
    // construtores //
    
    public Animais()
    {
        raca = "Cachorro";
        tipo = "Vertebrado";
    }
}