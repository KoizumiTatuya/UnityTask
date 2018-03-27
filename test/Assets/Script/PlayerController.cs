using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // 移動スピード
    private float Speed = 4.0f;

    // Update is called once per frame
    void Update()
    {
        // 矢印キーを押下している時
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            // 正面を向く（正面 * フレーム * 移動スピード）
            transform.Translate(Vector3.forward * Time.deltaTime * Speed); 
        }

        // 矢印キーを押下している時に向きを変える
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            // 向きを指定(向きたい方向-今の位置)
            transform.rotation = Quaternion.LookRotation(
            transform.position +
            (Vector3.right * Input.GetAxisRaw("Horizontal")) +
            (Vector3.forward * Input.GetAxisRaw("Vertical"))
            - transform.position);
        }
    }
}
