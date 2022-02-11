using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowManController : MonoBehaviour
{
    [SerializeField] private float _walkingSpeed = 0.7f;
    [SerializeField] private float _cavity = 0.5f;
    [SerializeField] private float _duration = 4f;

    [SerializeField] private ShadowMaterialDissolve dissolve;

    private void Start()
    {
        StartCoroutine(dissolve.ShadowFade(_duration, 1, _cavity));
    }

    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * _walkingSpeed);
    }


}
