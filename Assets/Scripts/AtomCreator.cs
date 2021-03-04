using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtomCreator : MonoBehaviour
{
    public GameObject proton;
    public GameObject neutron;
    public GameObject electron;

    public Text inputText;
    public Text userAlertsText;

    private GameObject atomicParent;

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

    Vector2 vector2 = new Vector2(1, 1);
    public object neutronCount;

    // Update is called once per frame
    void Update()
    {
        //if the user presses enter, instantiate atoms
        if (Input.GetKeyDown(KeyCode.Return))
        {
            int arrayIndex = -1;
            // Return a number in thr arrayIndex if it has found the atom in the array
            for(int x = 0; x < atomNames.Length; x++)
            {
                if(inputText.text == atomNames[x])
                {
                    arrayIndex = x;
                }
            }

            // tell the user that the element is not in our array
            if (arrayIndex < 0)
            {
                userAlertsText.text = inputText.text + " element you searched was not in our list. Please Try something else.";
                return;
            }

            Destroy(atomicParent);
            atomicParent = new GameObject("Atomic Parent");

            for (int x = 0; x < elementInformation[arrayIndex].x; x++)
            {
                // protons
                GameObject reference = Instantiate(proton);
                reference.transform.position = Random.insideUnitSphere * Mathf.Log(elementInformation[arrayIndex].x) / 2;
                reference.transform.SetParent(atomicParent.transform);
            }

            int neutronCount = elementInformation[arrayIndex].y - elementInformation[arrayIndex].x;
               // neutron
            for (int x = 0; x < neutronCount; x++)
            {
                
               GameObject reference = Instantiate(neutron);
               reference.transform.position = Random.insideUnitSphere * Mathf.Log(elementInformation[arrayIndex].y - elementInformation[arrayIndex].x) / 2;
               reference.transform.SetParent(atomicParent.transform);
            }

            for (int x = 0; x < elementInformation[arrayIndex].x; x++)
            {
                // electrons
                GameObject reference = Instantiate(electron);
                reference.transform.GetChild(0).transform.position = new Vector3(Mathf.Log(elementInformation[arrayIndex].x), 0, 0);
                reference.transform.Rotate(Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f));
                reference.transform.SetParent(atomicParent.transform);
            }

            Debug.Log("array index: " + arrayIndex);
            Debug.Log(atomNames[arrayIndex]);
            Debug.Log(elementInformation[arrayIndex].x);
            Debug.Log(neutronCount);
        }
    }
}
