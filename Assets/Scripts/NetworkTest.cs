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
        // ��ſ� �ʿ��� �ּ�.
        string url = "https://developer-lostark.game.onstove.com/characters/LostGrade/siblings";
        // url�̶�� �ּҷ� ��û�� ����
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
