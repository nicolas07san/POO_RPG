namespace POO_RPG.src.Entities
{
    public class WhiteWizard : Hero
    {
        public int strongAttackManaCost = 5;

        public WhiteWizard(string name, int level)
        {
            this.name = name;
            this.level = level;

            baseHealthPoints = 60;
            baseManaPoints = 100;

            manaIncreasePerLevel = 15;
            healthIncreasePerLevel = 10; 

            maxHealthPoints = baseHealthPoints + (healthIncreasePerLevel * level);
            healthPoints =  maxHealthPoints;

            maxManaPoints = baseManaPoints + (manaIncreasePerLevel * level);
            manaPoints = maxManaPoints;
        }

        public override string Attack()
        {
            return this.name + " lançou um ataque mágico";
        }

        public string Attack(int manaCost)
        {
            if(manaCost >= strongAttackManaCost)
            {
                return this.name + $" lançou um ataque mágico forte gastando {manaCost} de mana.";
            }
            else
            {
                return this.name + $" lançou um ataque mágico fraco gastando {manaCost} de mana.";
            }
                
        }
    }
}