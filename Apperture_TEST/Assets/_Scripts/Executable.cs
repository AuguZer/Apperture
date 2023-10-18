using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Executable : MonoBehaviour
{

    [SerializeField] float messageDisplayTime = 2f; 
    [SerializeField] GameObject normalMessage;
    [SerializeField] GameObject warningMessage;

    [SerializeField] List<Button> projects = new List<Button>();

    [SerializeField] Button projectPrefab;
    [SerializeField] Transform startPos;

    float nextPosY;
    float Yspace = 30f;

    Animator normalAnimator;
    Animator warningAnimator;

    bool normalActive;
    bool warningActive;


    // Start is called before the first frame update
    void Start()
    {
        normalMessage.SetActive(false);
        warningMessage.SetActive(false);
        normalAnimator = normalMessage.GetComponent<Animator>();
        warningAnimator = warningMessage.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayNormalMessage();
        DisplayWarningMessage();
        AddProjectInList();
    }

    private void DisplayNormalMessage()
    {
        if (Input.GetKeyDown(KeyCode.A) && !warningActive)
        {
            normalActive = true;
            normalMessage.SetActive(true);
            normalAnimator.SetBool("canGo", true);
            StartCoroutine(MessageCoroutine());
        }
    }
    private void DisplayWarningMessage()
    {
        if (Input.GetKeyDown(KeyCode.S) && !normalActive)
        {
            warningActive = true;
            warningMessage.SetActive(true);
            warningAnimator.SetBool("canGo", true);
            StartCoroutine(WarningCoroutine());
        }
    }
    private void AddProjectInList()
    {
        if (Input.GetKeyDown(KeyCode.Q) && projects.Count < 10)
        {
            Button newProject = Instantiate(projectPrefab, startPos);

            RectTransform rectTransform = newProject.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = new Vector2(0f, -nextPosY);
            nextPosY += rectTransform.sizeDelta.y + Yspace;
            
            projects.Add(newProject);
        }
    }

    IEnumerator MessageCoroutine()
    {
        yield return new WaitForSeconds(messageDisplayTime);
        normalAnimator.SetBool("canGo", false);
        yield return new WaitForSeconds(messageDisplayTime - 1f);
        normalMessage.SetActive(false);
        normalActive = false;
    }
    IEnumerator WarningCoroutine()
    {
        yield return new WaitForSeconds(messageDisplayTime);
        warningAnimator.SetBool("canGo", false);
        yield return new WaitForSeconds(messageDisplayTime - 1f);
        warningMessage.SetActive(false);
        warningActive = false;

    }
}
