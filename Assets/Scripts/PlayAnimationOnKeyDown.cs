using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOnKeyDown : MonoBehaviour
{
    // Allows us to specify the key to be pressed.
    public KeyCode Key;

    // Allows us to specify the name of an animation trigger.
    public string TriggerName;

    // Stores a reference to the animator.
    public Animator TargetAnimator;

    // Allows us to specify a delay before we accept input.
    public float InDelay = 1f;

    // This Unity method is called once after the Awake method and before the game loop starts.
    IEnumerator Start()
    {
        // Implement the specifed delay before we accept input.
        yield return new WaitForSeconds(InDelay);

        // While the user is not pressing the specified key, keep looping.  This effectively
        // pauses the coroutine until the user enters the required key.
        while (!Input.GetKeyDown(Key))
        {
            // Make sure we return control to the game engine once per loop so the game doesn't lock up
            // and crash.
            yield return null;
        }

        // Set the trigger in the animator to play the specified animation.
        TargetAnimator.SetTrigger(TriggerName);
    }
}