using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Player player;

    // コライダー接触時
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //接触対象がプレイヤーだった場合ゲームクリア
        if(collision.gameObject.tag=="Player")
        {
            player.GameClear();
            //Debug.Log("game clear");
        }
    }
}
