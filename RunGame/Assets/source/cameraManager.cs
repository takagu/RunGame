using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraManager : MonoBehaviour
{
    public GameObject target;   //カメラの追従先
    Vector3 pos;               //カメラの初期位置

    // Start is called before the first frame update
    void Start()
    {
        pos = Camera.main.gameObject.transform.position;    //カメラの初期位置を取得
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = target.transform.position;  //カメラの現在位置取得

        if(target.transform.position.x<0)
        {
            cameraPos.x = 0;
        }

        if (target.transform.position.y<0)
        {
            cameraPos.y = 0;
        }
        else if(target.transform.position.y>0)
        {
            cameraPos.y = target.transform.position.y;
        }

        cameraPos.z = -10;
        Camera.main.gameObject.transform.position = cameraPos;   //カメラを移動
    }
}
