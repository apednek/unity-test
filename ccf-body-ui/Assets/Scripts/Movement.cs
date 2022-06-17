using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    private Transform position;
    
    void Start()
    {
        position = cube.transform;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)){
            position.Translate(0.001f, 0f,0f);
        }
        else if(Input.GetKeyDown(KeyCode.A)){
            position.Translate(-0.001f, 0f,0f);
        }
        else if(Input.GetKeyDown(KeyCode.W)){
            position.Translate(0f, 0.001f,0f);
        }
        else if(Input.GetKeyDown(KeyCode.S)){
            position.Translate(0f, -0.001f,0f);
        }
        else if(Input.GetKeyDown(KeyCode.Q)){
            position.Translate(0f, 0f, 0.001f);
        }
        else if(Input.GetKeyDown(KeyCode.E)){
            position.Translate(0f, 0f, -0.001f);
        }
    }
}
