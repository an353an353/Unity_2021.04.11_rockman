using UnityEngine;

public class API : MonoBehaviour
{
    // 靜態 API
    // 非靜態 API

    // 1. 非靜態 API 需要物件
    // 2. 定義一個欄位 - 物件
    public Transform tra1;
    public Transform tra2;
    
    public SpriteRenderer spr;
    
    // 非靜態所需的物件
    public Camera cam;
    public SpriteRenderer spr2;
    public Transform tra3;
    public Rigidbody2D rig;   


    private void Start()
    {
        #region  認識 API
        // 靜態
        // 類別名稱.靜態屬性
        float f = Random.value;

        // 非靜態
        // 屬性名稱
        // 物件名稱.非靜態屬性
        print("取得物件的座標:" + tra1.position);

        // 存放屬性
        // 物件名稱.非靜態屬性 指定 值;
        tra2.localScale = new Vector3(3, 3, 3);

        spr.color = new Color(1, 0, 0);
        spr.flipX = true;
 
        #endregion

        print("攝影機的深度:" + cam.depth);
        print("圖片1的顏色:" + spr2.color);

        cam.backgroundColor = new Color(0.5f, 0.3f, 0.3f);
        spr2.flipX = true;
        spr2.flipY = true;


        tra3.localScale = new Vector3(1, 1, 1);


    }

    private void Update()
    {
        #region 認識 API
        // 非靜態
        // 使用方法
        // 物件名稱.非靜態方法(對應參數)
        tra2.Translate(0.1f, 0, 0);

        #endregion

      
        tra3.Rotate(0, 0, 1);
        rig.AddForce(new Vector2(0, 10));
    }
}
