using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtomsManager : MonoBehaviour
{

    public GameObject[] atomsArray;

    private GameObject lastCreatedAtom;


    public Text inputText;

    public Text feedbackText;

    // Update is called once per frame
    void Update()
    {
        string inputString = inputText.text;

        if(Input.GetKeyDown(KeyCode.Return))
        {
            feedbackText.text = "";
            Destroy(lastCreatedAtom);
            switch(inputString)
            {
                case "hydrogen":
                    lastCreatedAtom = Instantiate(atomsArray[0]);
                    break;
                case "helium":
                    lastCreatedAtom = Instantiate(atomsArray[1]);
                    break;
                case "iron":
                    lastCreatedAtom = Instantiate(atomsArray[2]);
                    break;
                case "lithium":
                    lastCreatedAtom = Instantiate(atomsArray[3]);
                    break;
                case "beryllium":
                    lastCreatedAtom = Instantiate(atomsArray[4]);
                    break;
                case "boron":
                    lastCreatedAtom = Instantiate(atomsArray[5]);
                    break;
                case "carbon":
                    lastCreatedAtom = Instantiate(atomsArray[6]);
                    break;
                default:
                    feedbackText.text = inputString + " is not an element in the array"; 
                    break;
            }
        }
    }
}
