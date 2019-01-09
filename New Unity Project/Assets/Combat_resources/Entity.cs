using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
     * @author Nummy  
     * @version 0.1
     */
abstract class Entity
{

	//public string type { get; set; }
	public GlobalStats Primary { set; get; }
	public int Level { set; get; }
    public int Exp;

    /**
     * @author Nummy  
     * @version 0.1
     */
    public Entity(GlobalStats primary, int level, int exp)
	{
        this.Exp = exp;
        this.Primary = primary;
        this.Level = level;
	}

    /**
     * @author Nummy  
     * @version 0.1
     */
    public void Attaque() {

    }

    
        



}
