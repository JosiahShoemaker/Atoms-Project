using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronRotation : MonoBehaviour
{

    public GameObject[] electronPivotArray;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        electronPivotArray[0].transform.Rotate(new Vector3(0, 1, 0));
        electronPivotArray[1].transform.Rotate(new Vector3(0, 1, 0));

    }
}
