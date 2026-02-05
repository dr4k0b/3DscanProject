using System.Runtime.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Movement_Script : MonoBehaviour
{
    [SerializeField]
    public CharacterController controller;

    public float speed = 6f;

    Animator ani;

    private void Start()
    {
        ani = GetComponent<Animator>();
    }
    void Update()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");
        Vector3 Direction = new Vector3(Horizontal, 0f, Vertical).normalized;



        if (Direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(Direction.x, Direction.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

            controller.Move(Direction * speed * Time.deltaTime);

            ani.SetBool("Walk", true);
        }
        else
        {
            ani.SetBool("Walk", false);
        }

    }
           
}
