using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Rigidbody2D rbody;          //プレイヤーのリジッドボディ
    float speed_x = 5f;         //左右の移動スピード
    float speed_y = 0f;         //上下の移動スピード
    public GameObject endOg3;   //キャラクター　ゲームオーバー時
    public GameObject result;   //テキスト　GameOver/GameClear
    public GameObject score;    //テキスト　得点
    int scoreAmount = 0;        //得点量

    // ゲーム開始時の処理
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.velocity = new Vector2(speed_x, speed_y);
    }

    // フレームごとの更新
    void Update()
    {
        //ゲームオーバー確定時
        if(rbody.freezeRotation == false)
        {
            GameOver();
            return;
        }

        //キーボード操作
        if( Input.GetKey(KeyCode.UpArrow) )        //↑キー押下時　上移動
        {
            speed_y = 5f;
        }
        else if( Input.GetKey(KeyCode.DownArrow) )  //↓キー押下時　下移動
        {
            speed_y = -5f;
        }
        else
        {
            speed_y = 0f;
        }
        rbody.velocity = new Vector2(speed_x, speed_y);

        //スコア更新
        Text scoreText =score.GetComponent<Text>();
        scoreText.text = "SCORE "+scoreAmount.ToString("d5");
    }

    // ケーキ取得時プレイヤーを加速させる
    public void Accelerate()
    {
        speed_x += 5f;
        scoreAmount += 10;
    }

    // ゲームオーバー処理
    public void GameOver()
    {
        rbody.velocity = new Vector2(0f, 0f);
        rbody.freezeRotation = false;
        rbody.angularVelocity = 20f;

        // 角度が75°以上になったら終了
        if(gameObject.transform.localEulerAngles.z > 75)
        {
            // 走っているおじさんを非表示
            gameObject.SetActive(false);

            // 漏らしたおじさんを表示
            endOg3.transform.position = gameObject.transform.position;
            endOg3.SetActive(true);

            Text resultText =result.GetComponent<Text>();
            resultText.text = "Game\nOver";
        }

    }

    // ゲームクリア処理
    public void GameClear()
    {
        Text resultText =result.GetComponent<Text>();
        resultText.text = "Game\nClear!";
    }
}


