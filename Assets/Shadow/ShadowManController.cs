using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowManController : MonoBehaviour
{
    [SerializeField] private GameObject kage;
    [SerializeField] private float _walkingSpeed = 0.7f;

    [SerializeField] private float _cavity = 0.5f;
    [SerializeField] private float _duration = 4f;

    private Vector3 _startPos;

    private Material _material;

    private void Start()
    {
        _startPos = transform.position;
    }

    private void OnEnable()
    {
        _material = kage.GetComponent<Renderer>().material;
        _material.SetFloat("_cavity", 1);
        StartCoroutine(ShadowFade(_duration, 1, _cavity));
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        yield return StartCoroutine(ShadowFade(_duration, _cavity, 1));
        gameObject.SetActive(false);
        transform.position = _startPos;
        gameObject.SetActive(true);
    }

    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * _walkingSpeed);
    }


    IEnumerator ShadowFade(float duration, float startScale, float endScale)
    {
        for (float t = 0; t <= duration; t += Time.deltaTime)
        {
            _material.SetFloat("_cavity", Mathf.Lerp(startScale, endScale, t / duration));
            yield return null;
        }
    }
}
