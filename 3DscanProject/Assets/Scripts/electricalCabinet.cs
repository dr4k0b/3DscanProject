using UnityEngine;

public class electricalCabinet : MonoBehaviour
{

    private bool inRange;

    public GameObject lamps;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange && Input.GetKey(KeyCode.E)) 
        { 
            lamps.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inRange = false;
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inRange = true;

        }
    }
}
