using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        PetShop petShop = new PetShop();

        Cachorro c1 = new Cachorro("Rex", 3, "Labrador");
        Gato g1 =new Gato("Stray",2 ,"Bege");

        petShop.Adicionar(c1);
        petShop.Adicionar(g1);

        petShop.Listadeanimais();
        animal.ExibirInfo();
    }

}

class Animal
{
    public string Nome {get; set;}
    public int Idade {get; set;}


    public Animal(string n, int i)
    {
        Nome = n;
        Idade = i;
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Som genérico");
    }

    public virtual void ExibirInfo()
    {
        Console.WriteLine(Nome, Idade);
    }
}

class Cachorro: Animal
{
    public string Raca {get; set;}

    public Cachorro(string Nome, int Idade, string Raca): base(Nome, Idade)
    {
        Raca = raca;
    }

    public override void ExibirInfo()
    {
        base.ExibirInfo();
        Console.WriteLine($"Raça: {raca}");
    }

    public override void EmitirSom()
    {
        Console.WriteLine("Au Au");
    }
}

class Gato: Animal
{
    public string Cor {get; set;}

    public Gato(string Nome, int Idade, string Cor): base(Nome, Idade)
    {
        Cor = cor;
    }

    public override void ExibirInfo()
    {
        base.ExibirInfo();
        Console.WriteLine($"Cor: {cor}");
    }

    public override void EmitirSom()
    {
        Console.WriteLine("Miau");
    }
}

class PetShop
{
    public  List <Animal> Animais;

    public PetShop()
    {
        Animais = new List<Animal>();
    }
    
    public void Adicionar(Animal a)
    {
        Animais.Add(a);
        Console.WriteLine($"{a.Nome} foi adicionado com sucesso");
    }

    public void Listadeanimais()
    {
        Console.WriteLine("\n=== Lista de animais ===");
        foreach (Animal a in Animais)
        {
            a.ExibirInfo();
            a.EmitirSom();
            Console.WriteLine("-----------------------");
        }
    }
}