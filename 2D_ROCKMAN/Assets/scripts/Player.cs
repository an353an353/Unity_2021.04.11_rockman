using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("移動速度")]
    [Range(0,1000)]
    public float walkspeed = 10.5f;

    [Header("跳越高度")]
    [Range(0, 3000)]
    public int jumptall = 100;

    [Header("血量")]
    [Range(0, 200)]
    public float health = 100;

    [Header("是否在地板上"),Tooltip("儲存僥色是否在地板上")]
    public bool onfloor ;

    [Header("子彈"), Tooltip("角色要發射的子彈物件")]
    public GameObject bullet;

    [Header("子彈生成點"), Tooltip("生成子彈的位置")]
    public Transform bulletPoint;

    [Header("子彈速度")]
    [Range(0,5000)]
    public int bulletspeed = 800;

    [Header("開槍音效")]
    public AudioClip gunnoice;

    [Header("元件音效來源")]
    private AudioSource soundeffect;

    [Header("元件 2D 剛體")]
    private Rigidbody2D Rigidbody2;

    [Header("元件 動畫控制器")]
    private Animator Animator;



}
