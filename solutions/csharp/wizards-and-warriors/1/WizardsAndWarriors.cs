abstract class Character
{
    private readonly string characterType;
    
    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {characterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable()) {
            return 10;
        } else {
            return 6;
        }
    }
}

class Wizard : Character
{
    private bool spellPrepared = false; 
    
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        int damagePoints = 0;
        
        if (spellPrepared) {
            return 12;
        } else {
            return 3;
        }
    }

    public void PrepareSpell()
    {
        spellPrepared = true;
    }

    public override bool Vulnerable() {
        return !spellPrepared;
    }
}
