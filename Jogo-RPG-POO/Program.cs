using static System.Console;
using Jogo_RPG_POO.src.Entities;

// Pilares de OOP :: H.E.P.A
// Herança Encapsulamento Polimorfismo Abstração

class Program{

  static void Main(string[] args){

  Player hero = new Player("Jeff", 25, "Knight", 200, 20);

  WriteLine($"{hero.Name} {hero.Attack()} contra {hero.Name}");
  WriteLine($"{hero.Name} {hero.Attack(2)} contra {hero.Name}");

  }

}
