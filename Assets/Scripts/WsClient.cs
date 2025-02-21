using UnityEngine;
using WebSocketSharp;

public class WsClient : MonoBehaviour
{
    int test = 0;
    WebSocket ws;
    private void Start()
    {
        ws = new WebSocket("ws://localhost:7777");
        //서버에서 설정한 포트를 넣어줍니다.


        ws.Connect();
        //연결합니다.
        ws.OnMessage += Call;
        //이벤트 추가
        /*
         위랑 같은 것
        ws.OnMessage += (sender, e) =>
        {
            Debug.Log("주소 :  "+((WebSocket)sender).Url+", 데이터 : "+e.Data);
        };
         */
    }

    void Call(object sender, MessageEventArgs e)
    {
        Debug.Log("주소 :  " + ((WebSocket)sender).Url + ", 데이터 : " + e.Data);
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
            //데이터를 보냅니다 예제이기 때문에 "abcd" 를 보냅니다
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ws.Send("혼자만");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            ws.Send("모두에게");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            ws.Send("나를제외한 모두");
        }
    }
}
