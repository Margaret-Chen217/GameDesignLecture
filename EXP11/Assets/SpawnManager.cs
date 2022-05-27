using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pf;
    public int force;
    static public bool HasPrefab = false;
    // Start is called before the first frame update
    Rigidbody rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //按下空格键生成预制体
        if(!HasPrefab && Input.GetKeyDown(KeyCode.Space)){
            Instantiate(pf);
            HasPrefab = true;
            rb = pf.GetComponent<Rigidbody>();
        }
        // //按下b发射预制体
        // if(HasPrefab && Input.GetKeyDown(KeyCode.B)){
        //     Debug.Log("getkeydown B");
        //     //rb.transform.Translate(Vector3.left * force);
        //     //rb.velocity = new Vector3 (-1, 0, 0) * force;
        //     rb.AddForce(new Vector3(-1,0,0)*force);
        //}
    }
}
