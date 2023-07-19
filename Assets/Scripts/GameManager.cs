using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    [SerializeField] private Crewmate crewmate;
    [SerializeField] private Ship ship;
    [SerializeField] private TextMeshProUGUI crewMateText;

    // Start is called before the first frame update
    void Start()
    {
        //This Generates a new Crewmate
        GenerateCrewmate();

        UpdateText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateCrewmate()
    {
        crewmate.GenerateInfo();
        
    }
    public void Accept()
    {
        //This takes care of functions that occur when the Accept button is clicked
        Debug.Log("Crewmate has been accepted.");
        //recentCrewmate.GenerateInfo();
        Crewmate newCrewmate = new Crewmate();
        newCrewmate.crewMateName = crewmate.crewMateName;
        newCrewmate.crewMateHobby = crewmate.crewMateHobby;
        newCrewmate.alien = crewmate.alien;
        ship.AddCrewmate(newCrewmate);
        GenerateCrewmate();
        UpdateText();
        if (ship.listOfCurrentCrew.Count >= 10)
        {
            crewMateText.text = "Game over !" + "\n";
            //end stuff
            //loop through list of crewmates
            //for each crewmate show list of names and hobbies in textbox
            foreach(Crewmate currentCrewmate in ship.listOfCurrentCrew.ToArray())
            {
                crewMateText.text += currentCrewmate.crewMateName + " " + currentCrewmate.crewMateHobby + "\n";
            }
        }
    }

    public void Eject()
    {
        //This takes care of functions that occur when the Eject button is pressed
        Debug.Log("Crewmate has been ejected.");
        //recentCrewmate.GenerateInfo();
        GenerateCrewmate();
        UpdateText();
    }

    private void UpdateText()
    {
        //This makes text appear on screen
        crewMateText.text = crewmate.crewMateName + " \n" + crewmate.crewMateHobby;
    }

   
}
