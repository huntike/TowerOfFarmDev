using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Job {

    public string Name { get; set; }
    public List<Spells> Spells { get; set; }
    public List<int> Bonus { get; set; }
    //ajouts des models homme et femme

    public Job(string name, List<int> bonus , List<Spells> spells)
    {
        this.Name = name;
        this.Bonus = bonus;
        this.Spells = spells;
    }
}
