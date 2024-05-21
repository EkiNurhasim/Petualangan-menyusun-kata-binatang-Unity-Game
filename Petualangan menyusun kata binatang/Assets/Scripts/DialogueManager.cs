using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public GameObject[] activateObjectSetelahDialogueSelesai;

    public Text nameText;
    public Text dialogueText;

    public Dialogue dialogue;
    public Queue<string> sentences;
    public AudioSource[] source;      
    private int hitung;

    void Start()
    {
        hitung = 0;                        
        sentences = new Queue<string>();
        StartDialogue();
    }

    public void StartDialogue()
    {
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);         
        }

        //if (hitung == 0)
        //{
        //    source[1].Play();
        //}
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            foreach (var item in activateObjectSetelahDialogueSelesai)
            {
                item.SetActive(true);
            }            
            this.gameObject.SetActive(false);
            EndDialogue();
            return;
        }

        hitung++;

        switch (hitung)
        {
            case 1:                
                source[1].Play();
                source[1].pitch = 1f;
                break;
            case 2:                
                source[2].Play();
                source[2].pitch = 1f;
                source[1].Stop();
                break;
            case 3:                
                source[3].Play();
                source[3].pitch = 1f;
                source[2].Stop();
                break;
            case 4:
                source[4].Play();
                source[4].pitch = 1f;
                source[3].Stop();
                hitung = 0;
                break;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentences(sentence));
    }

    IEnumerator TypeSentences(string sentence)
    {
        dialogueText.text = ""; 
        foreach (char letter in sentence.ToCharArray()) {
            dialogueText.text += letter;
            source[0].Play();
            yield return null;            
        }
    }
    
    public void EndDialogue()
    {
        Debug.Log("end of dialogue");
    }

}


[System.Serializable]
public class Dialogue
{
    public string name;
    [TextArea(3, 10)]
    public string[] sentences;
}
