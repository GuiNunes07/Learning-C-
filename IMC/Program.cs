
String genero;
Double peso, altura;

// Calcular o IMC //

Double calcIMC(Double peso, Double altura)
{
    Double imc = peso / (altura * altura);

    return imc;
}

// Identificar e informar o IMC //

String classificaIMC(Double imc, string genero)
{
    String status;

// Diferença para Masculino/Feminino //

    if (genero.ToUpper() == "M")

    {

        if (imc > 39.9) { status = "Obesidade Mórdida"; }
        else if (imc >= 30 && imc <= 40) { status = "Obesidade Moderada"; }
        else if (imc >= 25 && imc <= 30) { status = "Obesidade Leve"; }
        else if (imc >= 20 && imc <= 25) { status = "Normal"; }
        else { status = "Abaixo do Normal"; }
    }
    else
    {
        if (imc > 38.9) { status = "Obesidade Mórdida"; }
        else if (imc >= 29) { status = "Obesidade Moderada"; }
        else if (imc >= 24) { status = "Obesidade Leve"; }
        else if (imc >= 19) { status = "Normal"; }
        else { status = "Abaixo do Normal"; }
    }

    return status;
}

// Chamando os comandos //

Console.Write("Entre com o Genero (M/F): ");
genero = Console.ReadLine();

Console.Write("Entre com o peso (Kg): ");
peso = Double.Parse(Console.ReadLine());

Console.Write("Entre com a Altura (Metros): ");
altura = Double.Parse(Console.ReadLine());

Console.WriteLine("Genero:" + genero);
Console.WriteLine("Peso:" + peso);
Console.WriteLine("Altura:" + altura);

Double seuIMC = calcIMC(peso, altura);
Console.WriteLine("Seu IMC: " + seuIMC);

String statusIMC = classificaIMC(seuIMC, genero);
Console.WriteLine("Status de seu IMC: " + statusIMC);