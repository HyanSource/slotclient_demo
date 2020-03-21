using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Btn : MonoBehaviour
{
    /// <summary>
    /// 按鈕模式 (0)按下彈起 (1)開關
    /// </summary>
    [SerializeField]
    int Mode;
    /// <summary>
    /// 按鈕目前位置
    /// </summary>
    Vector2 DownPosition;
    /// <summary>
    /// 取得自身的Component
    /// </summary>
    TextMesh MyText;
    /// <summary>
    /// 交換用顏色
    /// </summary>
    Color[] ChangeColor = new Color[2] { new Color(1, 1, 1), new Color(0.5f, 0.5f, 0.5f) };

    /// <summary>
    /// 需要處理的事件
    /// </summary>
    public UnityAction e = null;

    private void Awake()
    {
        //初始化取得以減少效能開銷
        MyText = this.GetComponent<TextMesh>();
    }

    private void OnMouseDown()
    {
        switch (Mode)
        {
            case 0:
                {
                    MyText.color = ChangeColor[1];
                }
                break;
            case 1:
                {

                }
                break;
        }
        //取得屬標位置
        DownPosition = Input.mousePosition;
    }


    private void OnMouseUp()
    {
        switch (Mode)
        {
            case 0:
                {
                    MyText.color = ChangeColor[0];
                }
                break;
            case 1:
                {
                    if (MyText.color == ChangeColor[0])
                    {
                        MyText.color = ChangeColor[1];
                    }
                    else
                    {
                        MyText.color = ChangeColor[0];
                    }
                }
                break;
        }

        //處理事件
        if (e != null)
        {
            e.Invoke();
        }
    }
}
