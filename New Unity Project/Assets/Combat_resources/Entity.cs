using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Entity
{

	//public string type { get; set; }
	public GlobalStats Primary { set; get; }
	public int Level { set; get; }
    public int Exp;


	public Entity(GlobalStats primary, int level, int exp)
	{
        this.Primary = primary;
        this.Level = level;
	}

    public 

        



}
