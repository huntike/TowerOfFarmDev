using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Job {

    public string Name { get; set; }
    public List<Spell> MyProperty { get; set; }
    protected CaracteristicBase Bonus { get; set; }

    public Job()
    {

    }
}
