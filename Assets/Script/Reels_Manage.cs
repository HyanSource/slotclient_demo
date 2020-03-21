using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reels_Manage : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer[] Grids = new SpriteRenderer[15];
    /// <summary>
    /// 取得遊戲結果
    /// </summary>
    /// <param name="r"></param>
    public void SetGameResult(int[] r)
    {
        for (int i = 0; i < Grids.Length; i++)
        {
            Grids[i].sprite = Load_Resources.Main.Lott_Symbols[r[i]];
        }

    }
}
