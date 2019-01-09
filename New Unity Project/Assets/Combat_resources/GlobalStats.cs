using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
    * @author Nummy
    * @version 0.1
    **/
class GlobalStats
{
    //Primary Stats
	public int Force { get; set; }
	public int Dexterite { set; get; }
	public int Inteligence { set; get; }
	public int Sagesse { set; get; }
	public int Charisme { set; get; }
	public int Constitution { set; get; }

    //Secondary stats
    public int HealthPoint { set; }
    public int Mana { get; }
    public int Stamina { get; }
    public int ResistanceDamageM { set; get; }
    public int ResistanceDamageP { set; get; }
    public int ResistanceMental { set; get; }


    /**
    * @author Nummy
    * @version 0.1
    **/
    public GlobalStats(int f , int d, int i, int s, int c, int ch)
	{
        this.Force = f;
        this.Dexterite = d;
        this.Inteligence = i;
        this.Sagesse = s;
        this.Charisme = ch;
        this.Constitution = c;
    }

    /**
     * @author Nummy
     * @version 0.1
     */
    public GlobalStats() {

        this.Force = 10;
        this.Dexterite = 10;
        this.Inteligence = 10;
        this.Sagesse = 10;
        this.Charisme = 10;
        this.Constitution = 10;
        
    }


}
