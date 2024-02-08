using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LensCameraRotation : MonoBehaviour
{

    public Camera lensCamera;
    public Camera mainCamera;
    private Transform lensTransform;
    private Transform mainTransform;
    // Start is called before the first frame update
    void Start()
    {
        lensTransform = lensCamera.transform;
        mainTransform = mainCamera.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rotation = Quaternion.LookRotation(lensTransform.position - mainTransform.position, lensTransform.up);
        lensTransform.rotation = rotation;
    }
}
