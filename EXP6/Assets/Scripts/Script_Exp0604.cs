using UnityEngine;
using UnityEngine.UI;

public class Script_Exp0604 : MonoBehaviour
{
    public InputField inputField_ID;
    public InputField inputField_keyword;
    public string ID;
    public string keyword;
    void Start()
    {
        //监听输入后事件
        inputField_ID.onValueChanged.AddListener(delegate (string content)
        {
            ID = content;
            //Debug.Log(content);
        });
        //监听输入后事件
        inputField_keyword.onValueChanged.AddListener(delegate (string content)
        {
            keyword = content;
            //Debug.Log(content);
        });

    }

    public void output(){
        Debug.Log("ID:" + ID);
        Debug.Log("keyword:" + keyword);
    }
}
