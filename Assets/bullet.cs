using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fuerza;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        { 
            shoot();
        }
        
    }

    void shoot()
    {
        GameObject bala = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        bala.GetComponent<Rigidbody>().AddForce(transform.forward * fuerza);
    }
}
