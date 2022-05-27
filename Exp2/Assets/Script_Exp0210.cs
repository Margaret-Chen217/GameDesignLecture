using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static bool judge;
public class Script_Exp0210 : MonoBehaviour
{
    void OnDrawGizmosSelected(){
        //选中Object是绘制Gizmo
    
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, new Vector3(2,0,0)+transform.position);
        //画线
        Gizmos.DrawCube(new Vector3(2,0,0)+transform.position, new Vector3(0.3f,0.3f,0.3f));
        //立方体
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, new Vector3(0,2,0)+transform.position);
        //画线
        Gizmos.DrawCube(new Vector3(0,2,0)+transform.position, new Vector3(0.3f,0.3f,0.3f));
        //立方体
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, new Vector3(0,0,2)+transform.position);
        //画线
        Gizmos.DrawCube(new Vector3(0,0,2)+transform.position, new Vector3(0.3f,0.3f,0.3f));
        //立方体

    }

    void OnDrawGizmos(){
        //始终绘制Gizmo
        Gizmos.DrawSphere(transform.position, 1);
    }
}
