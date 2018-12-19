using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    /**
     * All Charactere's Primary stats.
     * 
     * @author Nummy 
     * @version 0.1
     **/
	class PrimaryStats
	{
        //health of the character
		public int HealthPoint { get; set; }

        //Mana for using spell
		public int Mana { set; get; }

        // Stamina for using his ability
		public int Stamina { set; get; }
        
		public int ResistanceDamageM { set; get; }
		public int ResistanceDamageP { set; get; }
		public int ResistanceMental { set; get; } 

        public PrimaryStats(int hp, int mana, int stamina, int rdm, int rdp, int rm)
	    {
            this.HealthPoint = hp;
            this.Mana = mana;
            this.Stamina = stamina;
            this.ResistanceDamageM = rdm;
            this.ResistanceDamageP = rdp;
            this.ResistanceMental = rm;

		}
	}

