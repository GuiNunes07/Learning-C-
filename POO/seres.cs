using System;

class seres
{
    public string nome;
    public string cor;
    public int idade;
    
    // get e set //
    
    public string GetNome()
    {
        return nome;
    }
    public void SetNome(string novoNome)
    {
        nome = novoNome;
    }
    
    public string GetCor()
    {
        return cor;
    }
    public void SetCor(string novaCor)
    {
        cor = novaCor;
    }
    
    public int GetIdade()
    {
        return idade;
    }
    public void SetIdade(int novaIdade)
    {
        idade = novaIdade;
        
        if(novaIdade >= 18)
        {
            Console.WriteLine("Você é Adulto.");
        }else{
            Console.WriteLine("Você é criança.");
        }
    }
    
    public static void Lembrando()
    {
        Console.WriteLine("Sempre há nome e idade.");
    }
    
    public virtual void EmitirSom()
    {
        Console.WriteLine("O ser fez um barulho indescritível.");
    }
    
    // construtores //
    public seres()
    {
        nome = "Guilherme";
        cor = "Pardo";
        idade = 11;
    }
}