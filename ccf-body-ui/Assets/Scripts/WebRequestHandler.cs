using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;

public class WebRequestHandler : MonoBehaviour
{
    protected string responseText;
    private static WebRequestHandler instance;

    void Start()
    {
        instance = this;
        StartCoroutine(GetResponse());
    }

    IEnumerator GetResponse(){
        UnityWebRequest www = UnityWebRequest.Get("https://ccf-api.hubmapconsortium.org/v1/scene");
        yield return www.SendWebRequest();

        if(www.result == UnityWebRequest.Result.ConnectionError) {
            Debug.Log(www.error);
        }
        else {
            responseText = www.downloadHandler.text;
            Debug.Log(responseText);
        }
    }

    public WebRequestHandler GetInstance(){
        if(instance != null){
            return instance;
        }
        return null;
    }

    public string GetResponseString(){
        return responseText;
    }

}
