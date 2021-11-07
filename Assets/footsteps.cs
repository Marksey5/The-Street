using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    //set classes for the audio source, the distance between steps that I can set in unity, where the player moved from and the distance the player moved to 
    public AudioSource audioSource;
    public float footstepDistance;
    public Vector3 lastStepPosition;
    public float distanceMoved;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position is linked to gameobject that is set to XR rig so make the last step position equal to wherever the XR rig would be 
        lastStepPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //figure out distance moved between last step and current position using Vector3.distance
        distanceMoved = Vector3.Distance(lastStepPosition, transform.position);

        //make audio play when player moves
        if (Vector3.Distance(lastStepPosition, transform.position) > footstepDistance)
        {
            audioSource.Play();
            lastStepPosition = transform.position;

        }
    }
}
