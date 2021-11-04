using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    public AudioSource audioSource;
    public float footstepDistance;
    public Vector3 lastStepPosition;
    public float distanceMoved;

    // Start is called before the first frame update
    void Start()
    {
        lastStepPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distanceMoved = Vector3.Distance(lastStepPosition, transform.position);

        if (Vector3.Distance(lastStepPosition, transform.position) > footstepDistance)
        {
            audioSource.Play();
            lastStepPosition = transform.position;

        }
    }
}
