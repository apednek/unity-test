using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EditorHandler : MonoBehaviour
{
    // [SerializeField] private ScriptableObject urlResponse;
    private WebRequestHandler webRequestHandler;
    private string urlResponseText;

    [SerializeField]
    public class Response{
        public string id;
        public string type;
        public string representation_of;
        public string reference_organ;
        public string scenegraph;
        public string scenegraphNode;
        public string tooltip;
        public string color;
        public string opacity;
        public string unpickable;
        public string _lighting;
        public string zoomBasedOpacity;
    }

    [SerializeField]
    public class ResponseList{
        public Response[] response;
    }

    public static Response CreateFromJSON(string jsonString){
        return JsonUtility.FromJson<Response>(jsonString);
    }

    public ResponseList responseList = new ResponseList();

    void Start()
    {
        urlResponseText = webRequestHandler.GetInstance().GetResponseString();
        Debug.Log("eeeeeeeeeeeeeeeeeeee "+urlResponseText);
        StartCoroutine(ShowResponse());
    }

    IEnumerator ShowResponse(){
        yield return new WaitForSeconds(0.1f);
        responseList = JsonUtility.FromJson<ResponseList>(urlResponseText);
    }

}
