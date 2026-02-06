using UnityEngine;

public class Intro : MonoBehaviour
{
    private bool up;
    public float speed;
    void Start()
    {
        up = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            up = true;
        }

        if (up)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
    }
}
