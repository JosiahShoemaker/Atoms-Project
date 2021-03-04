using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronRotation : MonoBehaviour
{
    public GameObject[] electronPivotArray;

    // Update is called once per frame
    void Update()
    {
        switch(electronPivotArray.Length)
        {
            case 1:
                electronPivotArray[0].transform.Rotate(new Vector3(0, 1, 0));
                break;
            case 2:
                electronPivotArray[0].transform.Rotate(new Vector3(0, 1, 0));
                electronPivotArray[1].transform.Rotate(new Vector3(0, 1, 0));
                break;
            case 3:
                electronPivotArray[0].transform.Rotate(new Vector3(0, 1, 0));
                electronPivotArray[1].transform.Rotate(new Vector3(0, 1, 0));
                electronPivotArray[2].transform.Rotate(new Vector3(0, 1, 0));
                break;
            case 4:
                electronPivotArray[0].transform.Rotate(new Vector3(0, 1, 0));
                electronPivotArray[1].transform.Rotate(new Vector3(0, 1, 0));
                electronPivotArray[2].transform.Rotate(new Vector3(0, 1, 0));
                electronPivotArray[3].transform.Rotate(new Vector3(0, 1, 0));
                break;
            case 5:
                electronPivotArray[0].transform.Rotate(new Vector3(0, 1, 0));
                electronPivotArray[1].transform.Rotate(new Vector3(0, 1, 0));
                electronPivotArray[2].transform.Rotate(new Vector3(0, 1, 0));
                electronPivotArray[3].transform.Rotate(new Vector3(0, 1, 0));
                electronPivotArray[4].transform.Rotate(new Vector3(0, 1, 0));
                break;
             case 6:
                electronPivotArray[0].transform.Rotate(new Vector3(0, 1, 0));
                electronPivotArray[1].transform.Rotate(new Vector3(0, 1, 0));
                electronPivotArray[2].transform.Rotate(new Vector3(0, 1, 0));
                electronPivotArray[3].transform.Rotate(new Vector3(0, 1, 0));
                electronPivotArray[4].transform.Rotate(new Vector3(0, 1, 0));
                electronPivotArray[5].transform.Rotate(new Vector3(0, 1, 0));
                break;
            case 7:
                electronPivotArray[0].transform.Rotate(new Vector3(0, 1, 0));
                electronPivotArray[1].transform.Rotate(new Vector3(0, 1, 0));
                electronPivotArray[2].transform.Rotate(new Vector3(0, 1, 0));
                electronPivotArray[3].transform.Rotate(new Vector3(0, 1, 0));
                electronPivotArray[4].transform.Rotate(new Vector3(0, 1, 0));
                electronPivotArray[5].transform.Rotate(new Vector3(0, 1, 0));
                electronPivotArray[6].transform.Rotate(new Vector3(0, 1, 0));
                break;
        }
    }
}
