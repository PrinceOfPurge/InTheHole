using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private int index;
    public bool dialogueTwo;
    public bool dialogueThree;
    public bool dialogueFour;
    
    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
            
        }

        if(dialogueTwo == true)
        {
            lines[0] = "You made it through the first section. So you DO have a brain after all.";
            lines[1] = "Still don't remember why you're here, do you? You don't remember what YOU did.";
            lines[2] = "There were so many tears, and much more BLOOD.";
            lines[3] = "You dare feel scared when all of this was you own damn fault?";
            lines[4] = "Whatever... try and find your way out. I'm sure it'll go great...";
            Debug.Log("Dialogue should run");
            
            StartDialogue();
            dialogueTwo = false;
            
        }

        if (dialogueThree == true)
        {
            lines[0] = "You’re almost to the end. Good job… I guess…";
            lines[1] = "You remember now don’t you? All the blood around you? It’s from all the people you’ve killed.";
            lines[2] = "All the lives you thought were trivial enough to take away for your own sake. All the hurt you brought into the world is immeasurable.";
            lines[3] = "They had friends, sibilings, and loved ones! How could you take that away from them?";
            lines[4] = "That's why you're here. Do you understand now? Even if you don't, you definitely will soon...";
            Debug.Log("Dialogue should run");

            StartDialogue();
            dialogueThree = false;

        }

        if (dialogueFour == true)
        {
            lines[0] = "You finally made it to the end...";
            lines[1] = "Look at you...";
            lines[2] = "But there's nowhere else to go from here, is there? That's because you've made it to hell.";
            lines[3] = "For all the sins and wrongdoings you have committed, you'll be stuck in this maze for the rest of ETERNITY.";
            lines[4] = "Have fun! <3";
            Debug.Log("Dialogue should run");

            StartDialogue();
            dialogueFour = false;

        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
        
    }
    
    IEnumerator TypeLine()
    {
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
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            textComponent.text = string.Empty;
            gameObject.SetActive(false);
        }
    }
        
}
