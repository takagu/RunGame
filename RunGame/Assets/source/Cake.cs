using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake : MonoBehaviour
{
    public Player player;

    // コライダー接触時
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //接触対象がプレイヤーだった場合スピード加速
        if(collision.gameObject.tag=="Player")
        {
            player.Accelerate();
            gameObject.SetActive(false);
        }
    }
}
