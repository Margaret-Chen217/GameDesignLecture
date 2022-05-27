using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HPcontroller : MonoBehaviour
{
    const int HPMAX = 100;
    public int HP = 100;
    Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        //游戏开始时，初始化血量
        HP = HPMAX;
        slider = this.GetComponent<Slider>();
        slider.value = HP;
        //Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = HP;
        //Debug.Log("Slider.value:" + slider.value);
        
        //当血量小于20，血条颜色改变为红色
        // if(slider.value < 20){
        //     slider.GetComponent<fill_area>().value =
        // }
    }
    public void HPincrease(){//函数类型是public否在外面看不到
        if(HP <= HPMAX){
            HP += 5;
        }
        //Debug.Log("HP: " + HP);
    }

    public void HPdecrease(){
        if(HP > 0){
            HP -= 5;
        }
        //Debug.Log("HP: " + HP);
    }
}
