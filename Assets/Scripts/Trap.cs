using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject TrapFX;

    void CheckforColAndSpace(Collider2D other)
    {
        if ((other.tag == "Child") && (Input.GetKeyDown(KeyCode.Space)))
        {
            Destroy(other.gameObject);
            FindObjectOfType<AudioManager>().Play("TrapCaught");
            int randomNumber = Random.Range(1, 4);
            if (randomNumber == 1)
            {
                FindObjectOfType<AudioManager>().Play("Screaming1");
            }
            if (randomNumber == 2)
            {
                FindObjectOfType<AudioManager>().Play("Screaming2");
            }
            if (randomNumber == 3)
            {
                FindObjectOfType<AudioManager>().Play("Screaming3");
            }
            ScoreManager.instance.AddPoint();
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        CheckforColAndSpace(other);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        CheckforColAndSpace(other);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        CheckforColAndSpace(other);
    }
}
