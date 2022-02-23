using System.ComponentModel;

namespace POO_RPG.src.Entities
{
    public abstract class Hero
    {
        public string name;
        public int level;

        public int baseHealthPoints;
        public int healthIncreasePerLevel;
        public int maxHealthPoints;
        public int healthPoints;

        public int baseManaPoints;
        public int maxManaPoints;
        public int manaIncreasePerLevel;
        public int manaPoints;


        public Hero()
        {

        }
        
        public override string ToString()
        {
            return $"Name: {this.name}\n" +   
            $"  Lv. {this.level} {this.GetType().Name}\n" + 
            $"  HP   {this.healthPoints}/{this.maxHealthPoints}\n" +
            $"  MP   {this.manaPoints}/{this.maxManaPoints}\n";
        }

        public virtual string Attack()
        {
            return this.name + " atacou";
        }
    }
}