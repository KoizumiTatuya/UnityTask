using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityAnimation : MonoBehaviour {

    // Animatorコンポーネント
    private Animator animator;

    // 設定したフラグ
    private const string KeyIsRun = "isRun";    // 走り
    private const string KeyIsWait = "isWait";  // 伸び

    // 時間を計る
    float time = 0.0f;

    // Use this for initialization
    void Start () {
        // 設定されているコンポーネントを取得
        this.animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        // 矢印キーを押している時
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            // 時間の初期化
            time = 0;
            // WaitからRunに遷移する
            this.animator.SetBool(KeyIsRun, true);
        }
        else
        {
            // RunからWaitに遷移する
            this.animator.SetBool(KeyIsRun, false);
        }
        
        // 時間を計る
        time = time + Time.deltaTime;

        // 5秒たったら伸び
        if(time >= 5.0f)
        {
            // 時間初期化
            time = 0;
            // waitから伸びに移行
            this.animator.SetBool(KeyIsWait, true);
        }
        else
        {
            // 伸びからWaitに移行
            this.animator.SetBool(KeyIsWait, false);
        }
    }
}
