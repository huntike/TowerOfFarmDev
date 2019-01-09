using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class Antagonist
{
    public string Nom { set; get; }
    public string Race { get; set; }

    Antagonist(string name, string race)
	{
        this.Nom = name;
        this.Race = race;
	}
}

