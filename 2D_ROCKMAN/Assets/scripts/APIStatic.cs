﻿using UnityEngine;

public class APIStatic : MonoBehaviour
{
    // 認識靜態 API
    // 包含關鍵字 static 就是靜態

    public Vector3 a = new Vector3(1, 1, 1);
    public Vector3 b = new Vector3(22, 22, 22);

    private void Start()
    {
        #region 認識靜態屬性與方法




















        #endregion


        #region 練習
        print("攝影機數量:" + Camera.allCamerasCount);
        print("重力:" + Physics2D.gravity);

        Physics2D.gravity = new Vector2(0, -20);
        print("重力:" + Physics2D.gravity);

        Application.OpenURL("https://unity.com/");
        float f = Mathf.Floor(9.999f);
        print("去掉小數點的結果:" + f);
        #endregion
    }

    
    private void Update()
    {
        #region 練習
        // print("玩家是否按下任意鍵:" + Input.anyKeyDown);
        // print("遊戲時間:" + Time.time);

        bool b = Input.GetKeyDown("space");
        print("是否按下空白鍵:" + b);
        #endregion
    }
}
