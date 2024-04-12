using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iluminar_todo : MonoBehaviour
{
    public Light l;

    private bool manteniendoI = false;

    void Update()
    {
        pulsarR();
    }

    private void pulsarR()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            manteniendoI = true;
            EncenderApagarLuz();
        }
        else if (Input.GetKey(KeyCode.R))
        {
            manteniendoI = true;
        }
        else if (Input.GetKeyUp(KeyCode.R))
        {
            manteniendoI = false;
            EncenderApagarLuz();
        }
    }

    void EncenderApagarLuz()
    {
        l.enabled = manteniendoI;
    }
}
