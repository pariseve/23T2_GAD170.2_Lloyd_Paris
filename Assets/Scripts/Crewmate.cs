using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crewmate : MonoBehaviour
{
    public string crewMateName;
    public string crewMateHobby;
    public bool alien;

    private System.Random rnd = new System.Random();

    private string[] listOfNames = { "Steven Hills", "Raymond Borger", "Mack Lloyd", "Hello Kitty", "PomPom Purin","Doppo", "Jakurai", "Kenma","Carole","Tuesday" };
    private string[] listOfHobbies = { "I really enjoy baking !", "I love taking care of animals.", "My favourite activity is sleeping.", "I'm a big fan of film !", "I enjoy painting and being creative.", "I like travelling to new places !", "Nothing quite like sitting down with a good book." };
    private string[] listOfAlienNames = { "Gladys Glorb", "Gertrude Hobbs", "Human Being", "Guy Person", "Blorbo", "Me :)", "Dave Homosapien", "Jeremy Skrunklsworth" };
    private string[] listOfAlienHobbies = { "Avid harvester of vital organs.", "I really like consuming soil", "My favourite activity is interacting with my fellow human lifeforms !", "I am a big fan of observing.", "I enjoy staring directly into the sun !", "I like to play Genshin Impact.", "I love partaking in human activities.", "Nothing quite like sitting." };
    // Start is called before the first frame update
    void Start()
    {

        GenerateInfo();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateInfo()
    {
        int randomNumber = rnd.Next(0, 2);
        if(randomNumber == 1)
        {
            alien = true;
        }
        else
        {
            alien = false;
        }
        if (alien)
        {
            crewMateName = listOfAlienNames[rnd.Next(0, listOfAlienNames.Length)];
            crewMateHobby = listOfAlienHobbies[rnd.Next(0, listOfAlienHobbies.Length)];
        }
        else
        {
            crewMateName = listOfNames[rnd.Next(0, listOfNames.Length)];
            crewMateHobby = listOfHobbies[rnd.Next(0, listOfHobbies.Length)];
        }
    }
}
