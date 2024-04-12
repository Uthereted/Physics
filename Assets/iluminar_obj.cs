using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iluminar_obj : MonoBehaviour
{
    public GameObject[] objetosParaIluminar; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            foreach (GameObject objeto in objetosParaIluminar)
            {
                objeto.SetActive(!objeto.activeSelf);
            }
        }
    }
}
