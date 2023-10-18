using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Executable : MonoBehaviour
{

    [SerializeField] float messageDisplayTime = 2f;
    [SerializeField] GameObject normalMessage;

    Animator messageAnimator;

    // Start is called before the first frame update
    void Start()
    {
        messageAnimator = normalMessage.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayNormalMessage();
        DisplayWarningMessage();
        AddProjectInList();


        if(Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("IZI");
        }
    }

    private void DisplayNormalMessage()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Normal Message");
            messageAnimator.SetBool("canGo", true);
            StartCoroutine(MessageCoroutine());
        }
    }
    private void DisplayWarningMessage()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Warning Message");
        }
    }
    private void AddProjectInList()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Add Project To List");
        }
    }

    IEnumerator MessageCoroutine()
    {
        yield return new WaitForSeconds(messageDisplayTime);
        messageAnimator.SetBool("canGo", false);

    }
}
