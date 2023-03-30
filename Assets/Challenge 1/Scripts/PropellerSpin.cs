using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 10.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
