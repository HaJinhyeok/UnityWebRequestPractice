using UnityEngine;
using WebSocketSharp;

public class WsClient : MonoBehaviour
{
    int test = 0;
    WebSocket ws;
    private void Start()
    {
        ws = new WebSocket("ws://localhost:7777");
        //�������� ������ ��Ʈ�� �־��ݴϴ�.


        ws.Connect();
        //�����մϴ�.
        ws.OnMessage += Call;
        //�̺�Ʈ �߰�
        /*
         ���� ���� ��
        ws.OnMessage += (sender, e) =>
        {
            Debug.Log("�ּ� :  "+((WebSocket)sender).Url+", ������ : "+e.Data);
        };
         */
    }

    void Call(object sender, MessageEventArgs e)
    {
        Debug.Log("�ּ� :  " + ((WebSocket)sender).Url + ", ������ : " + e.Data);
        Debug.Log($"test : {++test}");
    }
    private void Update()
    {
        if (ws == null)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ws.Send("abcd");
            //�����͸� �����ϴ� �����̱� ������ "abcd" �� �����ϴ�
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ws.Send("ȥ�ڸ�");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            ws.Send("��ο���");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            ws.Send("���������� ���");
        }
    }
}
