int heroesHealth = 10;
int monsterHealth = 10;
Random random = new Random();
int damage = 0;
do
{
    damage = random.Next(1, 11);

     monsterHealth = monsterHealth - damage;
     


    Console.WriteLine(monsterHealth);
    Console.WriteLine(heroesHealth);

} while (monsterHealth >= 0);
