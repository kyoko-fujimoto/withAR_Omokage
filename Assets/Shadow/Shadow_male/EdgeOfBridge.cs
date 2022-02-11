using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeOfBridge : MonoBehaviour
{
    [SerializeField] private float _cavity = 0.5f;
    [SerializeField] private float _duration = 4f;
    [SerializeField] private Material _maleMaterial;
    [SerializeField] private Material _childMaterial;

    [SerializeField] private ShadowMaterialDissolve dissolve;
    private Vector3 _startPos;
    private GameObject _shadow;

    private void OnEnable()
    {

    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shadow_man"))
        {
            Material _material = _maleMaterial;
            _startPos = other.GetComponent<ShadowManController>()._startPos;
            _shadow = other.gameObject;
            yield return StartCoroutine(dissolve.ShadowFade(_duration, _cavity, 1, _material));
            _shadow.gameObject.SetActive(false);
            _shadow.transform.position = _startPos;
            _shadow.gameObject.SetActive(true);
            yield return StartCoroutine(dissolve.ShadowFade(_duration, 1, _cavity, _material));
        }
        else if (other.CompareTag("Shadow_child"))
        {
            Material _material = _childMaterial;
            _startPos = other.GetComponent<ShadowManController>()._startPos;
            _shadow = other.gameObject;
            yield return StartCoroutine(dissolve.ShadowFade(_duration, _cavity, 1, _material));
            _shadow.gameObject.SetActive(false);
            _shadow.transform.position = _startPos;
            _shadow.gameObject.SetActive(true);
            yield return StartCoroutine(dissolve.ShadowFade(_duration, 1, _cavity, _material));
        }
    }
}