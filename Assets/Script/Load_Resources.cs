using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load_Resources:MonoBehaviour
{
    /// <summary>
    /// 全局讀取
    /// </summary>
    public static Load_Resources Main;

    private void Awake()
    {
        Main = this;
        Load();
    }

    private void Load()
    {
        //(0)10號 (1)J (2)Q (3)K (4)A
        //(5)硯台 (6)紙 (7)墨 (8)毛筆
        //(9)百搭 (10)免費
        Lott_Symbols = new Sprite[11];

        Sprite[] t = Resources.LoadAll<Sprite>("slottexture");

        for (int i = 0; i < Lott_Symbols.Length; i++)
        {
            Lott_Symbols[i] = t[i];
        }

        Debug.Log("讀取成功");
    }

    /// <summary>
    /// 中獎素材圖片
    /// </summary>
    [SerializeField]
    public Sprite[] Lott_Symbols;


}
