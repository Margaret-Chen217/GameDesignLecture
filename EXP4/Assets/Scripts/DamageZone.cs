using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D collision) {
        //Debug.Log("进入伤害区域");
        RubyController rubyController = collision.GetComponent<RubyController>();
        if(rubyController != null){
            rubyController.ChangeHealth(-1);
            //Destroy(gameObject);
        }
    }
}
