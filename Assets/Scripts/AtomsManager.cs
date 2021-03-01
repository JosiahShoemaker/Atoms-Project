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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string inputString = inputText.text;

        if(Input.GetKeyDown(KeyCode.Return))
        {
            switch(inputString)
            {
                case "hydrogen":
                    lastCreatedAtom = Instantiate(atomsArray[0]);
                    break;
                case "helium":
                    lastCreatedAtom = Instantiate(atomsArray[1]);
                    break;
                default:
                    feedbackText.text = inputString + " is not an element in the array"; 
                    break;
            }
        }
    }
}
