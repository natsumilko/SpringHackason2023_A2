using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundSlide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        //トランスフォームの取得
        Transform myTransform = this.transform;
 
        //座標の取得
        Vector3 pos = myTransform.position;
 
        //z方向の速度
        pos.x -= 0.5f;
 
        //座標の設定
        myTransform.position = pos;

        if (myTransform.position.x < -200)
        {
            myTransform.position = new Vector3(440, 0, -20);
        }
    }
}
