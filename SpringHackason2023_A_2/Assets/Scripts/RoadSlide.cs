using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSlide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //トランスフォームの取得
        Transform myTransform = this.transform;
 
        //座標の取得
        Vector3 pos = myTransform.position;
 
        //z方向の速度
        pos.x -= 0.5f;
 
        //座標の設定
        myTransform.position = pos;

        if (myTransform.position.x < -62)
        {
            myTransform.position = new Vector3(222.8f, 6.24f, 8.2748f);
        }
    }
}
