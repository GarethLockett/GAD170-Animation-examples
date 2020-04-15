using UnityEngine;

/*
    Script: AnimatorToggle
    Author: Gareth Lockett
    Version: 1.0
    Description: Super simple script to toggle on/off an Animator parameter.
*/

public class AnimatorToggle : MonoBehaviour
{
    // Properties
    public KeyCode key = KeyCode.Space;             // Key to press to toggle the Animator parameter.
    public string nameOfParameter = "Sprint";       // Name of the parameter in the Animator editor (Make sure matches case!)

    // Methods
    private void Update()
    {
        // Check if key is pressed.
        if( Input.GetKeyDown( this.key ) == true )
        {
            // Get/check this game object has an Animator component.
            Animator animator = this.gameObject.GetComponent<Animator>();
            if( animator != null )
            {
                // Set the parameter to the opposite (Eg ! == NOT) the current value.
                animator.SetBool( this.nameOfParameter, !animator.GetBool( this.nameOfParameter ) );
            }
        }
    }
}
