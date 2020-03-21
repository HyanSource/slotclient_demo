using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_AutoPlay : MonoBehaviour
{
    private void Awake()
    {
        this.GetComponent<Btn>().e = AutoBetEvents;
    }

    private void AutoBetEvents()
    {

        if (GameMain.Main.Auto)
        {
            GameMain.Main.Auto = false;
        }
        else
        {
            GameMain.Main.Auto = true;
            StartCoroutine(AutoBetCoroutine());
        }

    }

    IEnumerator AutoBetCoroutine()
    {
        while (GameMain.Main.Auto)
        {
            GameMain.Main.Obj_Conn.Send100(1);

            yield return new WaitForSeconds(3f);
        }

    }
}
