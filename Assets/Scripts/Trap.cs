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
            ScoreManager.instance.AddPoint();
            GameObject e = Instantiate(TrapFX) as GameObject;
            e.transform.position = transform.position;
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
