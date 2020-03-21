using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_Play : MonoBehaviour
{
    private void Awake()
    {
        this.GetComponent<Btn>().e = BetEvents;
    }
    /// <summary>
    /// 單次下注事件
    /// </summary>
    private void BetEvents()
    {
        if (GameMain.Main.Auto)
            return;

        GameMain.Main.Obj_Conn.Send100(1);
    }

}
