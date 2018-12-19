using System.Collections;
using System.Collections.Generic;
using UnityEngine;


	abstract class Entity
	{

		//public string type { get; set; }
		public PrimaryStats primary { set; get; }
		public int Level { set; get; }
		public SecondaryStats secondary { set; get; }
		public int position { set; get; }

		public Entity()
		{
            this.primary = new PrimaryStats();
		}

        



	}
