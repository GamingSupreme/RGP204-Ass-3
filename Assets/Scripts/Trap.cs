using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public Wanderer Wanderer;
    public AnimationClip TrapFX;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Child detected!");
        AnimationClip e = Instantiate(TrapFX) as AnimationClip;
        Wanderer.TrappedState();
    }
}
