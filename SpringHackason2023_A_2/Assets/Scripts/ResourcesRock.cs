using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesRock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //プレハブをGameobject型で取得
        GameObject objRock = (GameObject)Resources.Load("Rock");
        //プレハブを元にインスタンスを生成
        Instantiate(objRock, new Vector3(80.0f, 2.0f, -4.0f), Quaternion.identity);
        Instantiate(objRock, new Vector3(180.0f, 2.0f, -4.0f), Quaternion.identity);
        Instantiate(objRock, new Vector3(220.0f, 2.0f, -4.0f), Quaternion.identity);
        Instantiate(objRock, new Vector3(380.0f, 2.0f, -4.0f), Quaternion.identity);
        Instantiate(objRock, new Vector3(410.0f, 2.0f, -4.0f), Quaternion.identity);
        Instantiate(objRock, new Vector3(600.0f, 2.0f, -4.0f), Quaternion.identity);
        Instantiate(objRock, new Vector3(820.0f, 2.0f, -4.0f), Quaternion.identity);
        Instantiate(objRock, new Vector3(1000.0f, 2.0f, -4.0f), Quaternion.identity);
        Instantiate(objRock, new Vector3(1200.0f, 2.0f, -4.0f), Quaternion.identity);
        Instantiate(objRock, new Vector3(1270.0f, 2.0f, -4.0f), Quaternion.identity);
        Instantiate(objRock, new Vector3(1500.0f, 2.0f, -4.0f), Quaternion.identity);
        Instantiate(objRock, new Vector3(1690.0f, 2.0f, -4.0f), Quaternion.identity);
        Instantiate(objRock, new Vector3(1890.0f, 2.0f, -4.0f), Quaternion.identity);
        Instantiate(objRock, new Vector3(2300.0f, 2.0f, -4.0f), Quaternion.identity);
        Instantiate(objRock, new Vector3(2490.0f, 2.0f, -4.0f), Quaternion.identity);
        Instantiate(objRock, new Vector3(2710.0f, 2.0f, -4.0f), Quaternion.identity);
        Instantiate(objRock, new Vector3(2900.0f, 2.0f, -4.0f), Quaternion.identity);
        Instantiate(objRock, new Vector3(2990.0f, 2.0f, -4.0f), Quaternion.identity);
        Instantiate(objRock, new Vector3(3110.0f, 2.0f, -4.0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
