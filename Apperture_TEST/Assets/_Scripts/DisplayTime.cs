using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayTime : MonoBehaviour
{
    [SerializeField] GameObject displayTime;
    [SerializeField] GameObject displayDate;
    int hour;
    int minute;
    int seconde;

   
    // Start is called before the first frame update
    void Start()
    {
        string date = System.DateTime.Today.ToString("dd MM yyyy");
        displayDate.GetComponent<TextMeshProUGUI>().text = date;

    }

    // Update is called once per frame
    void Update()
    {
        hour = System.DateTime.Now.Hour;
        minute = System.DateTime.Now.Minute;
        seconde = System.DateTime.Now.Second;

        displayTime.GetComponent<TextMeshProUGUI>().text = "" + hour + ":" + minute + ":" + seconde;

    }
}
