using UnityEngine;

public class ScrewDriver : MonoBehaviour
{
    private bool playerInRange;
    public GameObject door;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            door.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
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
