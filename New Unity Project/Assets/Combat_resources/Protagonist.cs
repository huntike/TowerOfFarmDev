using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * @author Nummy
 * @version 0.1
 */
abstract class Protagonist : Entity{

	public string Nom { get; set; }
	public string Gender { set; get; }
	public Job Job { set; get; }
	public int Helmet { set; get; }
	public int Body { set; get; }
	public int Weapon { set; get; }
	public int Shield { set; get; }

    /**
    * @author Nummy
    * @version 0.1
    */
    public Protagonist(string nom, string gender, Job job, GlobalStats primary, int level, int exp) : base(  primary,  level,   exp)
	{
        this.Nom = nom;
        this.Gender = gender;
        this.Job = job;
        this.Primary = primary;
        this.Level = level;
        this.Exp = exp;
        this.Helmet = 2;
        this.Body = 2;
        this.Weapon = 2;
        this.Shield = 2;

	}
    /**
     * @author Nummy
     * @version 0.1
     */
    public void CastSpell()
	{

	}
	
	public void AddSpell()
	{

	}

	
}
