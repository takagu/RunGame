using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraManager : MonoBehaviour
{
    public GameObject Target;   //カメラの追従先
    Vector3 PosCameraStart;     //カメラの初期位置
    Vector3 PosTargetStart;     //カメラの追従先の初期位置

    // Start is called before the first frame update
    void Start()
    {
        //初期位置を保存
        PosCameraStart = Camera.main.gameObject.transform.position;
        PosTargetStart = Target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posCameraUpdate = PosCameraStart;

        //X座標のみターゲットに合わせて更新
        posCameraUpdate.x += Target.transform.position.x - PosTargetStart.x;

        //カメラ位置を更新
        Camera.main.gameObject.transform.position = posCameraUpdate;
    }
}
