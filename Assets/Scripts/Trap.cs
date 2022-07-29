using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject TrapFX;

    private void OnTriggerStay2D(Collider2D other)
    {
        if ((other.tag == "Child") && (Input.GetKeyDown(KeyCode.Space)))
        {
            Destroy(other.gameObject);
            Debug.Log("Child detected!");
            GameObject e = Instantiate(TrapFX) as GameObject;
            e.transform.position = transform.position;
            
        }
    }
}
