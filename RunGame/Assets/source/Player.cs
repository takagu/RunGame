using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;    //移動速度
    public float jumpP = 300f;  //ジャンプ力

    Rigidbody2D rbody;

    void Start()
    {
        //リジッドボディ取得
        rbody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //スペースキー押下時、かつ上下移動無し時
        if( Input.GetKeyDown(KeyCode.Space) && rbody.velocity.y == 0 )
        {
            //リジッドボディをjumpP分ジャンプさせる
            rbody.AddForce(transform.up*jumpP);
        }
    }

    private void FixedUpdate()
    {
        //リジッドボディにspeed分の右方向の速度を入れる
        rbody.velocity = new Vector2(speed,rbody.velocity.y);
    }
}
