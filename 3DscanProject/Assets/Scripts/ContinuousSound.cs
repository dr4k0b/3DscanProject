using UnityEngine;

public class ContinuousSound : MonoBehaviour
{
    public string name;
    AudioManager am;
    void Start()
    {
        am = GetComponent<AudioManager>();
        am.Play(name);
    }
}
