using Unity.Cinemachine;
using UnityEngine;

public class Door : MonoBehaviour
{
    Transform player;
    public Transform Path;
    public CinemachineCamera pathCamera;
    public static CinemachineCamera currentCamera;
    void Start()
    {
        player = FindAnyObjectByType<Movement_Script>().transform;
    }

    void Update()
    {
        if(Vector2.Distance(transform.position, player.position) < 1 && Input.GetKeyUp(KeyCode.E))
        {
            player.position = Path.position;
            pathCamera.enabled = true;
            currentCamera.enabled = false;
            currentCamera = pathCamera;
        }
    }
}
