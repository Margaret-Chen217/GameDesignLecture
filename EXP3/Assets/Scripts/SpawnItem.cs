using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnItem : MonoBehaviour
{
    string ItemName;
    float ItemPosX, ItemPosY, ItemPosZ;
    float ItemWidth, ItemLength, ItemHeight;
    public Transform[] SpawnPoints;
    public float SpawnTime = 2f;
    public GameObject[] Items;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            SpawnItems();
        }
        //InvokeRepeating("SpawnItems", SpawnTime, SpawnTime);
        StartCoroutine(Create());
    }
    IEnumerator Create()
    {
        for (int i = 0; i < 5; i++)
        {
            SpawnItems();
            yield return new WaitForSeconds(2f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnItems()
    {
        int spawnIndex = Random.Range(0, SpawnPoints.Length);
        int ItemIndex = Random.Range(0, Items.Length);
        Instantiate(Items[ItemIndex], SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);
        ItemName = Items[ItemIndex].name;
        // ItemSize.x.y.z = transform.GetComponent<MeshFilter>().mesh.bounds.size;
        ItemWidth = Items[ItemIndex].GetComponent<Renderer>().bounds.size.x;
        ItemLength = Items[ItemIndex].GetComponent<Renderer>().bounds.size.z;
        ItemHeight = Items[ItemIndex].GetComponent<Renderer>().bounds.size.y;
        ItemPosX = Items[ItemIndex].transform.position.x;
        ItemPosY = Items[ItemIndex].transform.position.y;
        ItemPosZ = Items[ItemIndex].transform.position.z;
    }
    void OnGUI()
    {
        GUIStyle style = new GUIStyle
        {
            border = new RectOffset(10, 10, 10, 10),
            fontSize = 15,
            fontStyle = FontStyle.BoldAndItalic,
        };
        style.normal.textColor = new Color(200 / 255f, 180 / 255f, 150 / 255f);
        GUI.Label(new Rect(360, 20, 100, 200), "Name:" + ItemName, style);
        GUI.Label(new Rect(360, 35, 100, 200), "Size: Width-"+ ItemWidth, style);
        GUI.Label(new Rect(360, 50, 100, 200), "          Length-"+ ItemLength, style);
        GUI.Label(new Rect(360, 65, 100, 200), "          Height-"+ ItemHeight, style);
        GUI.Label(new Rect(360, 80, 100, 200), "Pos : X-"+ ItemPosX, style);
        GUI.Label(new Rect(360, 95, 100, 200), "         Y-"+ ItemPosY, style);
        GUI.Label(new Rect(360, 110, 100, 200), "         Z-"+ ItemPosZ, style);

    }
}
