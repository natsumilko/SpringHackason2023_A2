using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceWaraDoll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //プレハブをGameobject型で取得
        GameObject objWaraDoll = (GameObject)Resources.Load("WaraDoll");
        //プレハブを元にインスタンスを生成
        Instantiate(objWaraDoll, new Vector3(50.0f, 2.0f, 6.0f), Quaternion.identity);
        Instantiate(objWaraDoll, new Vector3(100.0f, 2.0f, 6.0f), Quaternion.identity);
        Instantiate(objWaraDoll, new Vector3(220.0f, 2.0f, 6.0f), Quaternion.identity);
        Instantiate(objWaraDoll, new Vector3(320.0f, 2.0f, 6.0f), Quaternion.identity);
        Instantiate(objWaraDoll, new Vector3(390.0f, 2.0f, 6.0f), Quaternion.identity);
        Instantiate(objWaraDoll, new Vector3(600.0f, 2.0f, 6.0f), Quaternion.identity);
        Instantiate(objWaraDoll, new Vector3(850.0f, 2.0f, 6.0f), Quaternion.identity);
        Instantiate(objWaraDoll, new Vector3(1120.0f, 2.0f, 6.0f), Quaternion.identity);
        Instantiate(objWaraDoll, new Vector3(1200.0f, 2.0f, 6.0f), Quaternion.identity);
        Instantiate(objWaraDoll, new Vector3(1330.0f, 2.0f, 6.0f), Quaternion.identity);
        Instantiate(objWaraDoll, new Vector3(1600.0f, 2.0f, 6.0f), Quaternion.identity);
        Instantiate(objWaraDoll, new Vector3(1700.0f, 2.0f, 6.0f), Quaternion.identity);
        Instantiate(objWaraDoll, new Vector3(1920.0f, 2.0f, 6.0f), Quaternion.identity);
        Instantiate(objWaraDoll, new Vector3(2330.0f, 2.0f, 6.0f), Quaternion.identity);
        Instantiate(objWaraDoll, new Vector3(2560.0f, 2.0f, 6.0f), Quaternion.identity);
        Instantiate(objWaraDoll, new Vector3(2780.0f, 2.0f, 6.0f), Quaternion.identity);
        Instantiate(objWaraDoll, new Vector3(2900.0f, 2.0f, 6.0f), Quaternion.identity);
        Instantiate(objWaraDoll, new Vector3(29500.0f, 2.0f, 6.0f), Quaternion.identity);
        Instantiate(objWaraDoll, new Vector3(3000.0f, 2.0f, 6.0f), Quaternion.identity);
        Instantiate(objWaraDoll, new Vector3(3200.0f, 2.0f, 6.0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
