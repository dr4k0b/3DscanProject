using Unity.Cinemachine;
using UnityEngine;

public class CameraInfo : MonoBehaviour
{
    public int currentCamera;

    public CinemachineCamera[] cameras;

    private void Update()
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].Priority = 0;
            if (i == currentCamera)
            {
                cameras[i].Priority = 1;
            }
        }
    }
}
