using UnityEngine;

public class Cornerman_Script : MonoBehaviour
{
    public GameObject[] dialoguePanel;
    public KeyCode interactKey = KeyCode.E;
    public int DialogueIndex;

    private bool playerInRange;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(interactKey))
        {
            closeall();
            if(DialogueIndex >= dialoguePanel.Length) 
                DialogueIndex = 0;
            dialoguePanel[DialogueIndex].SetActive(true);
            DialogueIndex++;
        }
    }
    private void closeall()
    {
        for (int i = 0; i < dialoguePanel.Length; i++)
        {
            dialoguePanel[i].SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            closeall();
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;

        }
    }

}

