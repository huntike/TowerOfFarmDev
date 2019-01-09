using System.Collections;
using System.Collections.Generic;


public sealed class TeamSingleton
{
    private static TeamSingleton instance = null;
    private static readonly object padlock = new object();

    public Protagonist[] team = new Protagonist[4];


    private TeamSingleton()
    {
        // désérialiser quand on sauvegardera

        // stockage de la team
        team[0] = new Hero();
        team[1] = new Compagnon();
        team[2] = new Compagnon();
        team[3] = new Compagnon();

    }

    public static TeamSingleton Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new TeamSingleton();
                }
                return instance;
            }
        }
    }

}
