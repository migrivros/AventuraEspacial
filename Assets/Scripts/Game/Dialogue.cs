using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{

    public TextMeshProUGUI text;
    public string[] sentences;
    public float textSpeed;
    private int index; 

    public static bool startedLevel = false;

    // Start is called before the first frame update
    void Start()
    {
        if(startedLevel == false)
        {
            text.text = string.Empty;
            StartDialogue();
        }
        if(startedLevel == true)
        {
            gameObject.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(startedLevel == false)
        {
            if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if(text.text == sentences[index])
                {
                    NextSentence();
                }
                else
                {
                StopAllCoroutines();
                text.text  = sentences[index];
                }
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach(char c in sentences[index].ToCharArray())
        {
            text.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextSentence()
    {
        if(index < sentences.Length - 1)
        {
            index++;
            text.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
            startedLevel = true;
        }
    }
}
