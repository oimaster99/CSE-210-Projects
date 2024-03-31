public abstract class Object {

    protected string name;
    protected string type;
    protected int attack;
    protected int defense;
    protected bool canEquip;
    protected bool isArmor;
    protected int value;

    public Object() {
        name = "NULL";
        type = "NULL";
        attack = 0;
        defense = 0;
        canEquip = false;
        isArmor = false;
        value = 0;
    }

    public Object(string n, string t, bool canEq, bool isArm, int val) {
        name = n;
        type = t;
        attack = 0;
        defense = 0;
        canEquip = canEq;
        isArmor = isArm;
        value = val;
    }

    public Object(string n, string t, int atk, int def, bool canEq, bool isArm, int val) {
        name = n;
        type = t;
        attack = atk;
        defense = def;
        canEquip = canEq;
        isArmor = isArm;
        value = val;
    }

    public string GetName() {
        return name;
    }

    public string GetObjType() {
        return type;
    }

    public int GetAtk() {
        return attack;
    }

    public int GetDef() {
        return defense;
    }

    public bool isEquip() {
        return canEquip;
    }

    public bool checkArmor() {
        return isArmor;
    }

}