string svar;
Player player = new Player();
Boss Boss = new Boss();


while (player.HP > 0 && Boss.Life > 0)
{
    Console.WriteLine("punch or take hit");
    svar = Console.ReadLine();
    

    if(svar == "punch")
    {
       Boss.Life = Boss.Life - player.DMG; 

       Console.WriteLine($"The boss has {Boss.Life} HP");
    }

    if (svar == "take hit")
    {
      player.HP = player.HP - Boss.DMGB;  

      Console.WriteLine($"u have {player.HP} HP");
    }
    
}


if(player.HP < 0){
    System.Console.WriteLine("Game over");
}

if(Boss.Life < 0){
    Console.WriteLine("U win");
}





