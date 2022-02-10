using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkStraight : MonoBehaviour
{

    [SerializeField]
    private float _walkingSpeed = 0.7f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * _walkingSpeed);
    }
}
