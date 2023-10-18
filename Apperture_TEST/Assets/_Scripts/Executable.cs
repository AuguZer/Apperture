using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Executable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DisplayNormalMessage();
        DisplayWarningMessage();
        AddProjectInList();


        if(Input.GetKey(KeyCode.W))
        {
            Debug.Log("IZI");
        }
    }

    private void DisplayNormalMessage()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Normal Message");
        }
    }
    private void DisplayWarningMessage()
    {
        if (Input.GetKey(KeyCode.B))
        {
            Debug.Log("Warning Message");
        }
    }
    private void AddProjectInList()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("Add Project To List");
        }
    }
}
