using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomCreator : MonoBehaviour
{
    public GameObject proton;
    public GameObject neutron;
    public GameObject electron;
   
    string[] atomNames =
    {
        "gold",
        "silver",
        "nickel",
        "copper",
        "tin",
        "lead",
        "uranium"
    };

    Vector2Int[] elementInformation =
    {
        new Vector2Int(79, 197), // gold
        new Vector2Int(47, 108), // silver
        new Vector2Int(28, 59), // nickel
        new Vector2Int(29, 64), // copper
        new Vector2Int(50, 119), // tin
        new Vector2Int(82, 207), // lead
        new Vector2Int(92, 238), // uranium
    };

    string userInput = "gold";

    Vector2 vector2 = new Vector2(1, 1);


    // Update is called once per frame
    void Update()
    {
        //if the user presses enter, instantiate atoms
        if (Input.GetKeyDown(KeyCode.Return))
        {
            int arrayIndex = -1;
            for(int x = 0; x<atomNames.Length; x++)
            {
                if(userInput==atomNames[x])
                {
                    arrayIndex = x;
                }
            }


            for (int x = 0; x < elementInformation[arrayIndex].x; x++)
            {
                // protons
                GameObject reference = Instantiate(proton);
                reference.transform.position = Random.insideUnitSphere * Mathf.Log(elementInformation[arrayIndex].x) / 2;
            }

            for (int x = 0; x < elementInformation[arrayIndex].y - elementInformation[arrayIndex].x; x++)
            {
                // neutrons
               GameObject reference = Instantiate(neutron);
                reference.transform.position = Random.insideUnitSphere * Mathf.Log(elementInformation[arrayIndex].y - elementInformation[arrayIndex].x) / 2;
            }

            for (int x = 0; x < elementInformation[arrayIndex].x; x++)
            {
                // electrons
                GameObject reference = Instantiate(electron);
                reference.transform.GetChild(0).transform.position = new Vector3(Mathf.Log(elementInformation[arrayIndex].x), 0, 0);
                reference.transform.Rotate(Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f));

            }
        }
    }
}
