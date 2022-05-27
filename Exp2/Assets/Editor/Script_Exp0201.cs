using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Script_Exp0201  
{
    [MenuItem("Root/Test1",false,1)]
    static void Test1(){

    }

    [MenuItem("Root/Test0",false,0)]
    static void Test0(){

    }

    [MenuItem("Root/T/Test2")]
    static void Test2(){

    }

    [MenuItem("Root/T/Test2",true,20)]
    static bool Test2Validation(){
        return false;
    }
}
