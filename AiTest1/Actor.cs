using System;

public class Actor
{
    Dictionary<string, int> DominatTraits = new Dictionary<string, int>();
    public List<Traits> TraitsList { get; set; }
    public int Resource { get; set; }
    public int DesiredResource { get; set; }

    public Actor()
    {
        //slumpar utt resurser
        Random generator = new Random();
        Resource = generator.Next(0, 5);

        //bestämer hur mycket dom vill ha 
        DesiredResource = generator.Next(1, 5);

        //traits slumpas in 

        //laddar in alla traits 
        //slumpar vilka som har mest vikt 
        //gör en lista på vilken som är mest (diksonary)
        // this.GetType().Name 
        //tar namnet av den sak 


    }
}
