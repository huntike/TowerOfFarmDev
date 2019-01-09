using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< .merge_file_a16500
/**
     * @author Nummy  
     * @version 0.1
     */
=======
>>>>>>> .merge_file_a14512
abstract class Entity
{

	//public string type { get; set; }
	public GlobalStats Primary { set; get; }
	public int Level { set; get; }
    public int Exp;

<<<<<<< .merge_file_a16500
    /**
     * @author Nummy  
     * @version 0.1
     */
    public Entity(GlobalStats primary, int level, int exp)
	{
        this.Exp = exp;
=======

	public Entity(GlobalStats primary, int level, int exp)
	{
>>>>>>> .merge_file_a14512
        this.Primary = primary;
        this.Level = level;
	}

<<<<<<< .merge_file_a16500
    /**
     * @author Nummy  
     * @version 0.1
     */
    public void Attaque() {

    }

    
=======
    public 

>>>>>>> .merge_file_a14512
        



}
