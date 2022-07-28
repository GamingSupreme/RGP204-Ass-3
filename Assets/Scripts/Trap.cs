using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject TrapFX;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Child detected!");
        GameObject e = Instantiate(TrapFX) as GameObject;
        e.transform.position = transform.position;
    }
}
