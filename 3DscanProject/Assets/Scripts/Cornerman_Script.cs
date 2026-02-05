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
            DialogueIndex = Random.Range(0, 4);
            dialoguePanel[DialogueIndex].SetActive(true);
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

