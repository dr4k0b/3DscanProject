using Unity.Cinemachine;
using UnityEngine;

public class Door : MonoBehaviour
{
    Transform player;
    public Transform Path;
    public int pathCamera;

    CameraInfo cf;
    void Start()
    {
        player = FindAnyObjectByType<Movement_Script>().transform;
        cf = FindAnyObjectByType<CameraInfo>();
    }

    void Update()
    {
        if(Vector2.Distance(transform.position, player.position) < 2 && Input.GetKeyUp(KeyCode.E))
        {
            player.position = Path.position;
            cf.currentCamera = pathCamera;
        }
    }
}
