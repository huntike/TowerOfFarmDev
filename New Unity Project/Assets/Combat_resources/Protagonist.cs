using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< .merge_file_a17300
/**
 * @author Nummy
 * @version 0.1
 */
abstract class Protagonist : Entity{

	public string Nom { get; set; }
    public List<Spells> Spells { get; set; }
    public string Gender { set; get; }
	public Job Job { set; get; }
	public int Helmet { set; get; }
=======
public class Protagonist {

	public string Nom { get; set; }
	public string Gender { set; get; }
	//public Job Job { set; get; }
	public string Helmet { set; get; }
>>>>>>> .merge_file_a10396
	public int Body { set; get; }
	public int Weapon { set; get; }
	public int Shield { set; get; }

<<<<<<< .merge_file_a17300
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
=======
	public Protagonist()
	{

	}

	public void CastSpell()
>>>>>>> .merge_file_a10396
	{

	}
	
	public void AddSpell()
	{

	}

<<<<<<< .merge_file_a17300
	
=======
	public void RegenMana()
	{

	}

	public void RegenStamina()
	{

	}
>>>>>>> .merge_file_a10396
}
