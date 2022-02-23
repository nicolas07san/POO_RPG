namespace POO_RPG.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string name, int level)
        {
            this.name = name;
            this.level =  level;

            baseHealthPoints = 50;
            baseManaPoints = 150;

            manaIncreasePerLevel = 20;
            healthIncreasePerLevel = 5; 

            maxHealthPoints = baseHealthPoints + (healthIncreasePerLevel * level);
            healthPoints =  maxHealthPoints;

            maxManaPoints = baseManaPoints + (manaIncreasePerLevel * level);
            manaPoints = maxManaPoints;
        }
    }
}