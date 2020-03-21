using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using UnityEngine;
using Google.Protobuf;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class ClientConn : MonoBehaviour
{
    [Serializable]
    class Message
    {
        public int Len;
        public int MsgID;
        public byte[] Data;
    }
    /// <summary>
    /// 遊戲連線
    /// </summary>
    Socket H_Socket;
    /// <summary>
    /// 接收訊息的工作
    /// </summary>
    Thread Receive_Work;

    /// <summary>
    /// 從伺服器取得的消息
    /// </summary>
    Queue<Message> GameMessages = new Queue<Message>();

    private void OnApplicationQuit()
    {
        if (Receive_Work != null && Receive_Work.IsAlive)
        {
            Receive_Work.Abort();
        }
        Exit();
        GameMessages.Clear();
        GC.Collect();
    }

    private void Awake()
    {
        H_Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        try
        {
            H_Socket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 7777));
            Debug.Log("連接成功");

            Receive_Work = new Thread(new ThreadStart(Receive));
            Receive_Work.IsBackground = true;
            Receive_Work.Start();

            //StartCoroutine(Bet_Coroutine());

            StartCoroutine(Handle_Coroutine());
        }
        catch
        {
            Debug.Log("連接不成功");
        }
    }

    IEnumerator Handle_Coroutine()
    {
        while (H_Socket.Connected)
        {

            if (GameMessages.Count > 0)
            {
                service(GameMessages.Dequeue());
            }
            else
            {
                yield return new WaitForSeconds(0.1f);
            }
        }
    }

    //IEnumerator Bet_Coroutine()
    //{

    //    while (H_Socket.Connected)
    //    {
    //        yield return new WaitForSeconds(5f);
    //        Pb.Bet t = new Pb.Bet();
    //        t.PlayerID = 0;
    //        t.Bet_ = 50;
    //        SendMsg(100, t);
    //    }

    //}

    public void Send100(int bet)
    {
        if (H_Socket.Connected)
        {
            Pb.Bet t = new Pb.Bet();
            t.PlayerID = 0;
            t.Bet_ = bet;
            SendMsg(100, t);
        }

    }

    private void SendMsg(int msgid, IMessage data)
    {
        //序列化
        byte[] d = HyanProtobuf.HyanProto.Marshal(data);
        //裝包
        byte[] m = Pack(msgid, d);
        //send server
        H_Socket.Send(m);
    }

    /// <summary>
    /// 接收
    /// </summary>
    void Receive()
    {
        //訊息長度
        int receivelength = 0;
        byte[] result = new byte[1024];
        while (true)
        {
            try
            {
                receivelength = H_Socket.Receive(result);
                if (receivelength > 0)
                {
                    //取得訊息長度以及業務編號
                    byte[] gethead = new byte[8];
                    Array.Copy(result, gethead, gethead.Length);
                    Message t = UnPack(gethead);

                    if (t.Len > 0)
                    {
                        Array.Copy(result, 8, t.Data, 0, t.Len);
                    }

                    Array.Clear(result, 0, result.Length);

                    GameMessages.Enqueue(t);
                    //處理
                    //service(t);
                }

            }
            catch (SocketException e)
            {
                Debug.Log(e.ToString());
                break;
            }
            catch (Exception ex)
            {
                Debug.Log(ex.ToString());
                break;
            }

        }

        Exit();
    }
    /// <summary>
    /// 關閉socket連接
    /// </summary>
    private void Exit()
    {
        if (H_Socket != null)
        {
            H_Socket.Shutdown(SocketShutdown.Both);
            H_Socket.Close(500);
        }

    }

    /// <summary>
    ///  裝包
    /// </summary>
    byte[] Pack(int msgid, byte[] data)
    {
        byte[] outdata = new byte[data.Length + 8];//len + msgid + data
        try
        {
            using (MemoryStream ms = new MemoryStream(outdata))
            {
                ms.Write(BitConverter.GetBytes(data.Length), 0, 4);
                ms.Write(BitConverter.GetBytes(msgid), 0, 4);
                ms.Write(data, 0, data.Length);
            }
        }
        catch (Exception ex)
        {
            Debug.Log(ex.ToString());
            return new byte[0];
        }


        return outdata;
    }

    /// <summary>
    /// 拆包
    /// </summary>
    Message UnPack(byte[] headdata)
    {
        int Msg_Length = 0;
        int Msg_ID = 0;

        try
        {
            Msg_Length = BitConverter.ToInt32(headdata, 0);
            Msg_ID = BitConverter.ToInt32(headdata, 4);
        }
        catch (Exception ex)
        {
            Debug.Log(ex.ToString());
        }

        return new Message() { Len = Msg_Length, MsgID = Msg_ID, Data = new byte[Msg_Length] };
    }

    /// <summary>
    /// 處理業務邏輯
    /// </summary>
    void service(Message m)
    {
        //Debug.Log("輸出:" + m.Len + " " + m.MsgID + " " + m.Data);

        switch (m.MsgID)
        {
            case 1:
                {
                    Pb.PlayerData t = HyanProtobuf.HyanProto.UnMarshal<Pb.PlayerData>(m.Data);
                    Debug.Log(t.PlayerID);
                    Debug.Log(t.PlayerMoney);
                }
                break;
            case 100:
                {
                    Pb.ReturnGameResult t = HyanProtobuf.HyanProto.UnMarshal<Pb.ReturnGameResult>(m.Data);


                    GameMain.Main.Obj_Texts.TM_ResultMsg.text = "";
                    for (int i = 0; i < t.GameResult.LinesOdds.Count; i++)
                    {
                        GameMain.Main.Obj_Texts.TM_ResultMsg.text += "線號碼:"+ t.GameResult.LinesOdds[i].GetID+" 連線數:"+ t.GameResult.LinesOdds[i].GetCount+" 連線賠率:"+ t.GameResult.LinesOdds[i].GetOdds+"\n";
                        Debug.Log("LineID:" + t.GameResult.LinesOdds[i].GetID + " Count:" + t.GameResult.LinesOdds[i].GetCount + " Odds:" + t.GameResult.LinesOdds[i].GetOdds);
                    }

                    GameMain.Main.Obj_Reels.SetGameResult(Array.ConvertAll<string, int>(t.GameResult.Result.Split(','), int.Parse));
                    GameMain.Main.Obj_Texts.TM_AllMoney.text = t.AllMoney.ToString();
                    //GameMain.Main.Obj_Texts.TM_RaiseMoney =;
                    GameMain.Main.Obj_Texts.TM_GetMoney.text = t.GetMoney.ToString();
                }
                break;
            case 150:
                {

                }
                break;
            case 201:
                {

                }
                break;
        }

    }
}
