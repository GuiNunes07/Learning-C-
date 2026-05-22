using System;

class Humanos: seres
{
    public int cpf;
    
    // get e set //
    
    public int GetCpf()
    {
        return cpf;
    }
    public void SetCpf (int novoCpf)
    {
        cpf = novoCpf;
        
        if(novoCpf <= 0)
        {
            Console.WriteLine("Você não existe.");
        }else{
            Console.WriteLine("Você é pessoa.");
        }
    }
    
    public void Dormir()
    {
        Console.WriteLine("Pessoa têm sono...");
    }
    
    public void Apresentar()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Cor: " + cor);
        Console.WriteLine("Idade: " + idade + " anos");
    }
    
    // construtor //
    
    public Humanos()
    {
        cpf = 1;
    }
}