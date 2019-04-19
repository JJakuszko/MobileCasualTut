using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{

    [Range (0,5)]
    public float waitTime = 2.0f;
    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.GetComponent<PlayerBehaviour>())
        {
            Destroy(collision.gameObject);
            Invoke("ResetGame", waitTime);
        }
    }

    void ResetGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
