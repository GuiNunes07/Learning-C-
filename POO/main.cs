using System;

class Rodar
{
    static void Main()
    {
        
        seres sr = new seres();
        Humanos h1 = new Humanos();
        Animais a1 = new Animais();
        // -------------------- //
        
        seres.Lembrando(); // --> Puxando a função estática da class seres. //
        Animais.RegrasAnimal(); // --> Puxando a função estática da class animais. //
        
        a1.Falar(); // --> Utilizamos o apelido para chamar a função simples. //
        
        a1.EmitirSom(); // a1 = É a classe filha que designamos o override/polimorfismo. //
        
        Console.WriteLine("------------------------------------------");
        
        sr.SetIdade(11);
        Console.WriteLine(sr.GetIdade());
        
        Console.WriteLine(h1.GetCpf());
        h1.SetCpf(1);
        Console.WriteLine(h1.GetCpf());
        
        Console.WriteLine("------------------------------------------");
        
        h1.Apresentar();
        Console.WriteLine("Meu " + a1.GetRaca() + " tem um total de " + a1.GetIdade() + " Anos.");
        
    }
}
