using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

public abstract class Character {

    protected string name;
    protected double health;
    protected double maxHealth;
    protected int attack;
    protected int defense;
    protected int speed;
    protected int level;
    protected string trait;
    protected bool isDead;
    protected int tempDefense = 0;


    public Character() {
        name = "NULL";
        health = 1.0;
        maxHealth = 1.0;
        attack = 0;
        defense = 0;
        speed = 0;
        level = 1;
        isDead = false;
        trait = "NULL";
    }

    public Character(string n, double hp, double mhp, int atk, int def, int spd, int lvl) {
        name = n;
        health = hp;
        maxHealth = mhp;
        attack = atk;
        defense = def;
        speed = spd;
        level = lvl;
        isDead = false;
        trait = "NULL";
    }

    public Character(string n, double hp, double mhp, int atk, int def, int spd, int lvl, string trt) {
        name = n;
        health = hp;
        maxHealth = mhp;
        attack = atk;
        defense = def;
        speed = spd;
        level = lvl;
        isDead = false;
        trait = trt;
    }

    public string GetName() {
        return name;
    }

    public string GetTrait() {
        return trait;
    }

    public double GetHealth() {
        return health;
    }

    public double GetMaxHealth() {
        return maxHealth;
    }

    public int GetAttack() {
        return attack;
    }

    public int GetDefense() {
        return defense;
    }

    public int GetTempDefense() {
        return tempDefense;
    }

    public int GetSpeed() {
        return speed;
    }

    public int GetLevel() {
        return level;
    }

    public bool HasDied() {
        return isDead;
    }

    public virtual void InitiateBattle() {
        Console.WriteLine(":)");
    }

    public void equipItem(Object obj) {
        int oAtk = obj.GetAtk();
        int oDef = obj.GetDef();
        attack += oAtk;
        defense += oDef;
    }

    public void TakeDamage(double dmg) {
        Console.WriteLine("Taking Damage!");
        health -= dmg;
        if (health <= 0) {
            health = 0;
            isDead = true;
        }
        Console.WriteLine($"health is {health}");
        tempDefense = 0;
    }

    public void HealDamage(double hp) {
        health += hp;
        if (health > maxHealth) {
            health = maxHealth;
        }
    }

    public void Defend() {
        tempDefense = defense;
    }

}