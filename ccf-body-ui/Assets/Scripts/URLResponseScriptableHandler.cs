using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "UrlResponseData", menuName = "ScriptableObjects/UrlResponseScriptableObject", order = 1)]
public class UrlResponseScriptableHandler : ScriptableObject
{
    public List<string> id;
    public List<string> type;
    public List<string> representation_of;
    public List<string> reference_organ;
    public List<string> scenegraph;
    public List<string> scenegraphNode;
    public List<string> tooltip;
    public List<string> color;
    public List<string> opacity;
    public List<string> unpickable;
    public List<string> _lighting;
    public List<string> zoomBasedOpacity;

}
