namespace Jogo_RPG_POO.src.Entities
{
    public class Player
    {

        public string Name;
        public int Level;
        public string PlayerType;
        public int Life;
        public int Damage;

        public Player(string name, int level, string playerType, int life, int damage)
        { // metodo construtor
            this.Name = name;
            this.Level = level;
            this.PlayerType = playerType;
            this.Life = life;
            this.Damage = damage;
        }

        public override string ToString()
        { // override > sobrescrita de um método já existente/default
            return this.Name + " " + this.Level + " " + this.PlayerType; // aqui estou criando um novo comportamento para o metodo ToString
        }

        // virtual permite que seja feito override na classe pai pelas classes que estão herdando a mesma
        public virtual string Attack()
        { // metodo de ataque default 
            return "utilizou sua habilidade";
        }

        public virtual string Attack(int bonus)
        { // metodo de ataque com parametro de bonus de ataque
            var LifePlayer = this.Life - (0.2 * this.Damage);
            return "utilizou sua habilidade com um bonus de +" + bonus + "% de dano e ficou com "+ LifePlayer + " de vida";
        }

    }
}