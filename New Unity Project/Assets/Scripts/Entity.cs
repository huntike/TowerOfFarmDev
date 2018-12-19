using System.Collections;
using System.Collections.Generic;
using UnityEngine;


	abstract class Entity
	{

		public string Type { get; set; }
		public CaracteristicBase Carac { set; get; }
		public int Level { set; get; }
		public SecondaryCarac SecondaryCarac { set; get; }
		public int Position { set; get; }

		public Entity()
		{

		}

	}
