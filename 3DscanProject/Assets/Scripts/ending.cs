using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ending : MonoBehaviour
{
    public Animator ani;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            StartCoroutine(End());
        }
    }

    IEnumerator End()
    {
        ani.SetTrigger("End");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}
