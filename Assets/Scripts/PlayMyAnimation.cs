using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMyAnimation : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    private void Update()
    {
        myAnimationController = this.GetComponent<Animator>();
    }

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if(other.CompareTag("Child") && (Input.GetKeyDown(KeyCode.Space)))
    //    {
    //        StartCoroutine(DestroyObj(this.gameObject, other));
    //        myAnimationController.SetBool("PlayTrap", true);
    //    }
        
    //}
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Child") && (Input.GetKeyDown(KeyCode.Space)))
        {
            other.gameObject.GetComponent<Wanderer>().moveSpeed = 0.0f;
            StartCoroutine(DestroyObj(this.gameObject, other));
            myAnimationController.SetBool("PlayTrap", true);
        }
    }

    private IEnumerator DestroyObj(GameObject thisOne, Collider2D other)
    {
        yield return new WaitForSeconds(1.2f);
        Destroy(other.gameObject);
        Destroy(thisOne);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Child"))
        {
            myAnimationController.SetBool("PlayTrap", false);
        }

    }
}

//https://www.youtube.com/watch?v=JS4k_lwmZHk&ab_channel=SpeedTutor