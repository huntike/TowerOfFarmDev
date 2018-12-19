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
    public int HealthPoint { get; set; }
    public int Mana { set; get; }
    public int Stamina { set; get; }
    public int ResistanceDamageM { set; get; }
    public int ResistanceDamageP { set; get; }
    public int ResistanceMental { set; get; }
    /**
    * @author Nummy
    * @
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


}
