using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {

    // プレイヤー
    public Transform player;
    // 相対座標
    // private Vector3 offset;
    // カメラの速さ
    private float speed = 3.0f;
    // 回転角度
    private float angle = 0.0f;
    // 半径
    private float radius = 2f;

    // Use this for initialization
    void Start () {
        // カメラとプレイヤーの相対距離を求める
        // 相対座標 = カメラ位置 - プレイヤーの位置
        // offset = GetComponent<Transform>().position - player.position;
	}

    // Update is called once per frame
    void Update () {

        // 高さ(Vector3.upはVector3(0,1,0)と同じ意味)
        Vector3 height = Vector3.up;
      
        // Zキーで回転
        if (Input.GetKey(KeyCode.Z))
        {
            // 回転させる
            angle += speed;
        }
        // Xキーで回転
        else if (Input.GetKey(KeyCode.X))
        {
            // 回転させる
            angle -= speed;
        }

        // 回転方向を決める(Vector3.backはVector3(0,0,-1)と同じ意味)
        Vector3 rotDir = Quaternion.Euler(0.0f, angle, 0.0f) * Vector3.back;

        // カメラの位置 (プレイヤーの位置 + 高さ + 回転方向 * 半径)
        transform.position = player.position + height + rotDir * radius;
      
        // カメラの注視点(プレイヤーの位置に高さを足して調整)
        transform.LookAt(player.position + height);

        // カメラの座標に、プレイヤーの座標と相対座標を足した値を設定
        // カメラ位置 = プレイヤーの位置 + 相対座標
        //GetComponent<Transform>().position = player.position + offset;
        
    }
}
