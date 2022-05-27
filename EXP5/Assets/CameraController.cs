using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    public float value;
    Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeCameraPosition(Slider s){
        position.z = s.value;
        transform.position = position;
        Debug.Log("s.value: " + s.value);
    }
}
