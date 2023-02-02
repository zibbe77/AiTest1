using System;

public abstract class Traits
{
    public float weight { get; set; }
    protected float weightDesired;
    protected float weightTrait;

    //ska bestämma vilken handling som är best enligt engenskaper och värden 
    public void DoWeight(int desired, int resource, float chance)
    {
        //weight = max(0,(d − r))d · wd · wt · p
        //Chance är en repsation av världen
        weight = (Math.Max(0, (desired - resource)) / desired) * weightDesired * weightTrait * chance;
    }
}
