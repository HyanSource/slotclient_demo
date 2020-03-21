using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Google.Protobuf;
using ProtoBuf;
using System.IO;
using HyanProtobuf;

public class GameMain : MonoBehaviour
{
    /// <summary>
    /// 遊戲主物件
    /// </summary>
    [SerializeField]
    public static GameMain Main;

    [SerializeField]
    public ClientConn Obj_Conn;
    /// <summary>
    /// 控制轉輪用
    /// </summary>
    [SerializeField]
    public Reels_Manage Obj_Reels;
    /// <summary>
    /// 控制數字用
    /// </summary>
    [SerializeField]
    public Text_Manage Obj_Texts;

    [SerializeField]
    public bool Auto;

    private void Awake()
    {
        Main = this;
        Obj_Conn = this.GetComponent<ClientConn>();
        Auto = false;

        Debug.Log(Obj_Conn != null);
    }
}
