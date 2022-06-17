using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EditorHandler : MonoBehaviour
{
    [SerializeField] private WebRequestHandler webRequestHandler;
    private string urlResponseText;
    private Boolean responseFlag = false;

    [Serializable]
    public class Response{
        public string id;
        public string @type;
        public string entityId;
        public string representation_of;
        public string reference_organ;
        public string scenegraph;
        public string scenegraphNode;
        public List<string> transformMatrix = new List<string>();
        public List<string> ccf_annotations	= new List<string>();
        public string tooltip;
        public List<string> color = new List<string>();
        public string opacity;
        public string unpickable;
        public string _lighting;
        public string zoomBasedOpacity;
    }

    [Serializable]
    public class ResponseList{
        public List<Response> response = new List<Response>();
    }

    public static Response CreateFromJSON(string jsonString){
        return JsonUtility.FromJson<Response>(jsonString);
    }

    public ResponseList responseList = new ResponseList();

    void Update(){
        if(urlResponseText == null){
            urlResponseText = webRequestHandler.GetInstance().GetResponseString();
        }
        else if(urlResponseText != null){
            if(!responseFlag){
                string JSONToParse = ("{\"response\":" + urlResponseText + "}").Replace("@","");
                responseList = JsonUtility.FromJson<ResponseList>(JSONToParse);
                responseFlag = true;
            }
        }
    }

}
