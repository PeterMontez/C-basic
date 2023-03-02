using System;

DateTime dt = new DateTime();

Aluno Peter = new Aluno("Peterson Montez de Oliveira", "1234567890", "06/05/2002");
Console.WriteLine(Peter.nome);
Peter.Faltou();
Console.WriteLine(Peter.GetFaltas().ToString());
Peter.SetNota(1, 7.5f);
Peter.SetNota(2, 6.6f);
Console.WriteLine(Peter.FoiAprovado() ? "Aprovado" : "Reprovado");

Carro Sandrinho = new Carro("Renault", "Sandero", 2012, 0);

fibo(fim: 7);

int fibo(int fim, int a = 0, int b = 1, int round = 0)
{
    b = b + a;
    a = b - a;
    if(round == fim-3)
    {
        Console.WriteLine(b);
    }
    round++;
    if(round != fim)
    {
        fibo(fim, a, b, round);
    }
    return b;
}

public class Aluno
{
    public string nome { get; set; }
    public string cpf { get; set; }
    public DateTime data { get; set; }
    public int faltas { get; set; }
    public float nota1 { get; set; }
    public float nota2 { get; set; }
    public float nota3 { get; set; }

    public Aluno(string nome, string cpf, string nascimento)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.data = Convert.ToDateTime(nascimento);
    }

    public void Faltou()
    {
        this.faltas++;
    }

    public int GetFaltas()
    {
        return this.faltas;
    }

    public void SetNota(int prova, float nota)
    {
        switch (prova)
        {
            case 3:
                this.nota3 = nota;
                break;
            case 1:
                this.nota1 = nota;
                break;
            case 2:
                this.nota2 = nota;
                break;
            default:
                break;
        }
    }

    public bool FoiAprovado()
    {
        if(nota3 >= 7 || (nota1 + nota2)/2 >= 7)
        {
            return true;
        }
        return false;
    }

}

public class Carro
{
    public string marca { get; set; }
    public string modelo { get; set; }
    public int ano { get; set; }
    public int velocidade { get; set; }

    public Carro(string marca, string modelo, int ano, int velocidade)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.ano = ano;
        this.velocidade = velocidade;
    }

    public void Acelerar(int accel)
    {
        this.velocidade += accel;
    }

    public void Frear(int accel)
    {
        this.velocidade -= accel;
        if (velocidade < 0)
            this.velocidade = 0;
    }

    public (string marca, string modelo, int ano, int velocidade) ExibirDados()
    {
        return (this.marca, this.modelo, this.ano, this.velocidade);
    }

}