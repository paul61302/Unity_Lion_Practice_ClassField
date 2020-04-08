using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [Header("怪物一號")]
    public Enemy Enemy1;

    [Header("怪物二號")]
    public Enemy Enemy2;

    private void Start()
    {
        //取得怪物資訊
        print("怪物一號的魔力為：" + Enemy1.MP);
        print("怪物二號的裝備名稱為：" + Enemy2.Equipment);

        //修改怪物資訊
        Enemy1.HP = 100;
        Enemy2.HP = 300;
        Enemy1.Def = 50;
        Enemy1.Weapon = "木棍";
        Enemy2.Weapon = "短刀";
        Enemy1.Key = true;
        Enemy2.Treasure = true;


    }

}
