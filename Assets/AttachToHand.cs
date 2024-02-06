using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachToHand : MonoBehaviour
{
    private Collider collider;
    private Transform otherTransform;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(otherTransform)
        {
            this.transform.position = otherTransform.position;
            this.transform.rotation = otherTransform.rotation;
        }
    }

    private void OnTriggerEnter(Collider  other)
    {
        otherTransform = other.transform;
    }
    
}
