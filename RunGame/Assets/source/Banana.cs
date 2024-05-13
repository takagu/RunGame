using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : MonoBehaviour
{
    public Player player;

    // コライダー接触時
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //接触対象がプレイヤーだった場合ゲームオーバー
        if(collision.gameObject.tag=="Player")
        {
            GetComponent<BoxCollider2D>().enabled = false;
            player.GameOver();
        }
    }
}
