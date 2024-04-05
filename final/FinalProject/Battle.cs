using System.Diagnostics;

public class Battle {
    Player plr;
    Enemy enm;
    List<int> turnOrder;
    int plrSPD;
    int enmSPD;
    int enmDodgeChance;
    int plrDodgeChance;
    string enmName;
    string plrName;
    bool escape;
    Random rng = new Random();
    

    public Battle(Player p, Enemy e) {
        plr = p;
        enm = e;
        enmName = e.GetName();
        plrName = p.GetName();
        escape = false;
        enmDodgeChance = (plr.GetSpeed() / enm.GetSpeed()) * 5;
        plrDodgeChance = (enm.GetSpeed() / plr.GetSpeed()) * 5;

        turnOrder = new List<int>();

        if (plr.GetSpeed() > enm.GetSpeed()) {
            turnOrder.Add(0);
            turnOrder.Add(1);
        }
        else {
            turnOrder.Add(1);
            turnOrder.Add(0);
        }

        BattleManager();
    }

    public void BattleManager() {
        Console.WriteLine($"{enmName} appeared!");

        do {
            if (turnOrder[0] == 1) {
                EnemyAI();
            }
            //Console.Clear();
            Console.WriteLine($"{enmName}: {enm.GetHealth()}/{enm.GetMaxHealth()}");
            Console.WriteLine($"{plrName}: {plr.GetHealth()}/{plr.GetMaxHealth()}\n\n\n");

            Console.WriteLine("Options:\n1) Attack\n2)Defend\n3)Items\n4)Run");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice) 
            {
                case 1:
                    PlayerAttack();
                    break;
                case 2:
                    plr.Defend();
                    break;
                case 3:
                    Console.WriteLine("Not Implemented yet :)");
                    break;
                case 4:
                    escape = PlayerRun();
                    break;
                default:
                    break;
            }


            if (turnOrder[1] == 1 && !enm.HasDied()) {
                EnemyAI();
            }
        } while ((!enm.HasDied() && !plr.HasDied()) && !escape);

    }

    private void EnemyAI() {
        switch(enm.GetTrait()) 
        {
            case "cowardly":
            //Goofy choice declaration that's being weird
                int choice;
                if (enm.GetHealth() <= enm.GetHealth() * 0.2) {
                    escape = EnemyRun();
                }
                else if (enm.GetHealth() <= enm.GetHealth() * 0.4) {
                    choice = rng.Next(0, 100);

                    if (choice <= 55) {
                        EnemyAttack();
                    }
                    else {
                        EnemyDefense();
                    }
                }
                else {
                    choice = rng.Next(0, 100);

                    if (choice <= 77) {
                        EnemyAttack();
                    }
                    else {
                        EnemyDefense();
                    }
                }
                break;
            case "aggressive":
                if (enm.GetHealth() <= enm.GetHealth() * 0.2) {
                    EnemyAttack();
                }
                else if (enm.GetHealth() <= enm.GetHealth() * 0.4) {
                    choice = rng.Next(0, 100);

                    if (choice <= 90) {
                        EnemyAttack();
                    }
                    else {
                        EnemyDefense();
                    }
                }
                else {
                    choice = rng.Next(0, 100);

                    if (choice <= 77) {
                        EnemyAttack();
                    }
                    else {
                        EnemyDefense();
                    }
                }
                break;
            default:
                choice = rng.Next(0, 100);

                    if (choice <= 77) {
                        EnemyAttack();
                    }
                    else {
                        EnemyDefense();
                    }
                break;
        }
    }


    private void PlayerAttack() {
        enmDodgeChance = (plr.GetSpeed() / enm.GetSpeed()) * 5;

        if (enmDodgeChance > 80) {
            enmDodgeChance = 80;
        }

        int hitChance = rng.Next(0, 100);

        if (hitChance > enmDodgeChance) {
            Console.WriteLine("Player is attacking!");
            enm.TakeDamage((plr.GetAttack() * 1.5) - (enm.GetDefense() + enm.GetTempDefense()));
            Console.ReadKey();
        }
        else {
            Console.WriteLine("Missed!");
            Console.ReadKey();
        }
    }

    private void EnemyAttack() {
        plrDodgeChance = (enmSPD / plrSPD) * 5;

        Console.WriteLine("Enemy is Attacking!");

        if (plrDodgeChance > 80) {
            plrDodgeChance = 80;
        }

        int hitChance = rng.Next(0, 100);

        if (hitChance > plrDodgeChance) {
            double damage = (enm.GetAttack() * 1.5) - (plr.GetDefense() + plr.GetTempDefense());
            if (damage < 0) {
                damage = 0;
            }

            plr.TakeDamage(damage);
            Console.WriteLine($"{plrName} was hit for {damage} damage!");
            Console.ReadKey();
        }
        else {
            Console.WriteLine("Missed!");
        }
         
    }

    private bool EnemyRun() {
        int enmRunChance = (enmSPD * 100) / (plrSPD * 40);

        int enmRun = rng.Next(0, 100);

        if (enmRun >= enmRunChance) {
            Console.WriteLine("Failed to Escape!");
            return false;
        } 
        else {
            Console.WriteLine($"{enm.GetName} Escaped!");
            Console.ReadKey();
            return true;
        }
    }

    private bool PlayerRun() {
        int plrRunChance = (plrSPD * 100) / (enmSPD * 20);

        int plrRun = rng.Next(0, 100);

        if (plrRun >= plrRunChance) {
            Console.WriteLine("Failed to Escape!");
            return false;
        } 
        else {
            Console.WriteLine("Escaped!");
            Console.ReadKey();
            return true;
        }
    }

    private void EnemyDefense() {
        enm.Defend();
        Console.WriteLine("Enemy is Defending!");
        Console.ReadKey();
    }


}