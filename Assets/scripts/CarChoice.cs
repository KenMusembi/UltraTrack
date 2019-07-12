using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public GameObject RedBody;
    public GameObject BlueBody;
    public int CarImport;

    void Start()
    {
        CarImport = GloablCar.CarType;
        if (CarImport == 1)
        {
            RedBody.SetActive(true);
        }
        if (CarImport == 2)
        {
            BlueBody.SetActive(true);
        }
    }

}
