using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    Rigidbody rb;
    AudioSource audiosource;
    public AudioClip shootclip;
    public AudioClip destructiveclip;
    public int force = 100; 
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        audiosource = GetComponent<AudioSource>();
        //rb.AddForce(new Vector3(-1,0,0)*force);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SpawnManager.HasPrefab && Input.GetKeyDown(KeyCode.B)){
            rb.AddForce(new Vector3(-1,0,0)*force);
            audiosource.PlayOneShot(shootclip);
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("target")){
            audiosource.PlayOneShot(destructiveclip);
        }
    }
}
