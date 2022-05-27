using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    Rigidbody rb;
    public int force = 100; 
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        //rb.AddForce(new Vector3(-1,0,0)*force);
    }

    // Update is called once per frame
    void Update()
    {
        if(SpawnManager.HasPrefab && Input.GetKeyDown(KeyCode.B)){
            rb.AddForce(new Vector3(-1,0,0)*force);
        }
    }
}
