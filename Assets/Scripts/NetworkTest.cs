using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkTest : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(UnityWebRequestGet());
    }

    IEnumerator UnityWebRequestGet()
    {
        // 통신에 필요한 주소.
        string url = "";
        // url이라는 주소로 요청을 보냄
        UnityWebRequest www = UnityWebRequest.Get(url);

        yield return www.SendWebRequest();

        if (www.error == null)
        {
            Debug.Log(www.downloadHandler.text);
        }
        else
        {
            Debug.Log("ERROR");
        }
    }
}
