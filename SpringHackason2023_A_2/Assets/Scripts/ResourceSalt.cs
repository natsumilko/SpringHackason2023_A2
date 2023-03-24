using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceSalt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //プレハブをGameobject型で取得
        GameObject objSalt = (GameObject)Resources.Load("Salt");
        //プレハブを元にインスタンスを生成
        Instantiate(objSalt, new Vector3(80.0f, 2.0f, 1.0f), Quaternion.identity);
        Instantiate(objSalt, new Vector3(180.0f, 2.0f, 1.0f), Quaternion.identity);
        Instantiate(objSalt, new Vector3(330.0f, 2.0f, 1.0f), Quaternion.identity);
        Instantiate(objSalt, new Vector3(390.0f, 2.0f, 1.0f), Quaternion.identity);
        Instantiate(objSalt, new Vector3(500.0f, 2.0f, 1.0f), Quaternion.identity);
        Instantiate(objSalt, new Vector3(720.0f, 2.0f, 1.0f), Quaternion.identity);
        Instantiate(objSalt, new Vector3(890.0f, 2.0f, 1.0f), Quaternion.identity);
        Instantiate(objSalt, new Vector3(1000.0f, 2.0f, 1.0f), Quaternion.identity);
        Instantiate(objSalt, new Vector3(1200.0f, 2.0f, 1.0f), Quaternion.identity);
        Instantiate(objSalt, new Vector3(1430.0f, 2.0f, 1.0f), Quaternion.identity);
        Instantiate(objSalt, new Vector3(1650.0f, 2.0f, 1.0f), Quaternion.identity);
        Instantiate(objSalt, new Vector3(1690.0f, 2.0f, 1.0f), Quaternion.identity);
        Instantiate(objSalt, new Vector3(1910.0f, 2.0f, 1.0f), Quaternion.identity);
        Instantiate(objSalt, new Vector3(2200.0f, 2.0f, 1.0f), Quaternion.identity);
        Instantiate(objSalt, new Vector3(2430.0f, 2.0f, 1.0f), Quaternion.identity);
        Instantiate(objSalt, new Vector3(2540.0f, 2.0f, 1.0f), Quaternion.identity);
        Instantiate(objSalt, new Vector3(2700.0f, 2.0f, 1.0f), Quaternion.identity);
        Instantiate(objSalt, new Vector3(2800.0f, 2.0f, 1.0f), Quaternion.identity);
        Instantiate(objSalt, new Vector3(3100.0f, 2.0f, 1.0f), Quaternion.identity);
        Instantiate(objSalt, new Vector3(3300.0f, 2.0f, 1.0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
