using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public GameObject goOnText;
    public string[] lines;
    public float textSpeed;

    public GameObject Blob;

    public GameObject Mission;

    public static bool introRunning = false;

    public static bool restarted = false;

    private int index;

    public GameObject GravityHandler;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {   
        if (!restarted)
        {
            gameObject.SetActive(true);
            Player.SetActive(false);
            GravityHandler.GetComponent<GravityHandler>().enabled = false;
            introRunning = true;
            textComponent.text = string.Empty;
            startDialogue();
        }
        else 
        {
            gameObject.SetActive(false);
            Mission.SetActive(true);
        }
    }   

    // Update is called once per frame
    void Update()
    {
        Debug.Log(restarted);
        if (introRunning && !restarted)
        {
            if (textComponent.text == lines[index])
            {
                Blob.GetComponent<Animator>().enabled = false;
                goOnText.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (textComponent.text == lines[index])
                {
                    Blob.GetComponent<Animator>().enabled = false;
                    NextLine();
                }
                else 
                {
                    StopAllCoroutines();
                    textComponent.text = lines[index];
                    Blob.GetComponent<Animator>().enabled = false;
                }
            }   
        }
        
    }

    void startDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        Blob.GetComponent<Animator>().enabled = true;
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            goOnText.SetActive(false);
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
            Mission.SetActive(true);
            introRunning = false;
            Player.SetActive(true);
            GravityHandler.GetComponent<GravityHandler>().enabled = true;
            
        }
    }
}
