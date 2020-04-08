
using UnityEngine;

public class Enemy : MonoBehaviour
{
    /// <summary>
    /// 血量
    /// </summary>
    [Header("血量")]
    [Tooltip("怪物的血量")]
    [Range(50, 500)]
    public int HP;
    /// <summary>
    /// 魔力
    /// </summary>
    [Header("魔力")]
    [Tooltip("怪物的魔力")]
    [Range(10, 100)]
    public int MP = 100;
    /// <summary>
    /// 移動速度
    /// </summary>
    [Header("能力值")]
    //[Tooltip("怪物的血量")]
    [Range(1, 50.5f)]
    public float MoveSpeed = 10.5f;
    /// <summary>
    /// 攻擊力
    /// </summary>
    //[Header("血量")]
    //[Tooltip("怪物的血量")]
    [Range(20, 200)]
    public int Att = 50;
    /// <summary>
    /// 防禦力
    /// </summary>
    //[Header("血量")]
    //[Tooltip("怪物的血量")]
    [Range(0, 100)]
    public int Def;
    /// <summary>
    /// 武器名稱
    /// </summary>
    [Header("裝備")]
    //[Tooltip("怪物的血量")]
    //[Range(50, 500)]
    public string Weapon;
    /// <summary>
    /// 裝備名稱
    /// </summary>
    //[Header("血量")]
    //[Tooltip("怪物的血量")]
    //[Range(50, 500)]
    public string Equipment = ("皮衣");
    /// <summary>
    /// 是否帶有鑰匙
    /// </summary>
    [Header("其他資料")]
    [Tooltip("怪物是否帶有鑰匙")]
    //[Range(50, 500)]
    public bool Key = false;
    /// <summary>
    /// 血量
    /// </summary>
    //[Header("血量")]
    [Tooltip("怪物是否帶有寶物")]
    //[Range(50, 500)]
    public bool Treasure = false;



}
