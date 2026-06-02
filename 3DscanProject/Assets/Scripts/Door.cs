using Unity.Cinemachine;
using UnityEngine;

public class Door : MonoBehaviour
{
    Transform player;
    public Transform Path;
    public int pathCamera;
     bool hasEntered;

    float pSpeed;

    CameraInfo cf;
    void Start()
    {
        player = FindAnyObjectByType<Movement_Script>().transform;

        pSpeed = player.GetComponent<Movement_Script>().speed;

        cf = FindAnyObjectByType<CameraInfo>();
    }

    void Update()
    {

        if (Vector3.Distance(transform.position, player.position) < 2 && Input.GetKeyUp(KeyCode.E) && !hasEntered)
        {
            Debug.Log("door");
            player.GetComponent<CharacterController>().enabled = false;
            player.position = Path.position;
            cf.currentCamera = pathCamera;
            hasEntered = true;
        }
        else
        {
            player.GetComponent<CharacterController>().enabled = true;
            hasEntered = false;

        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, 2);
    }
}
