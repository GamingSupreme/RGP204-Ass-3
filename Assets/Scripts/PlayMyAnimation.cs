using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMyAnimation : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Child"))
        {
            myAnimationController.SetBool("PlayTrap", true);
        }
        
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