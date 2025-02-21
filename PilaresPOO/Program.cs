﻿using PilaresPOO;

public class Program
{
    private static void Main(string[] args)
    {
        Pet pet1 = new Pet();
        pet1.nome = "Rex";
        pet1.idade = 3;
        pet1.tipo = "Doguinho Caramelo";
        pet1.alimentar();

        Pet pet2 = new Pet();
        pet2.nome = "Unhada";
        pet2.idade = 4;
        pet2.tipo = "Gato nervoso";
        pet2.alimentar();

        Console.WriteLine("O pet 1 é " + pet1.nome);
        Console.WriteLine("O pet 2 é " + pet2.nome);

        Console.WriteLine("\n---------------------------------\n");

        Animal a1 = new Animal();
        a1.nome = "Soul Wine";
        a1.idade = 5;
        a1.tipoAlimentacao = "Lavagem Premium";
        a1.emitirSom();

        Cachorro caramelo = new Cachorro();
        caramelo.nome = "Rex";
        caramelo.idade = 6;
        caramelo.tipoAlimentacao = "O que colocar na frente";
        caramelo.emitirSom();
        caramelo.atacar();

        Gato gato = new Gato();
        gato.nome = "Floquinho";
        gato.idade = 3;
        gato.tipoAlimentacao = "Atum";
        gato.emitirSom();
    }
}