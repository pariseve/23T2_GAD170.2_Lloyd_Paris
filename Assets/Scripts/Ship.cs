using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public List<Crewmate> listOfCurrentCrew = new List<Crewmate>();
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCrewmate(Crewmate crewmate)
    {
        if (crewmate.alien)
        {
            //Kill off select crewmates on ship
            //Pick a random hobby from current Crewmates
            //Kill all crewmates with said hobby and disappears
            //listOfCurrentCrew.Remove(crewmate);
            //If list has more than 0, remove from list
            if(listOfCurrentCrew.Count > 0)
            {
                listOfCurrentCrew.RemoveAt(Random.Range(0, listOfCurrentCrew.Count));
            }
        }
        else
        {
            listOfCurrentCrew.Add(crewmate);
        }
    }
}
