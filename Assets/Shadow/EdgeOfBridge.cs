using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeOfBridge : MonoBehaviour
{
    [SerializeField] private float _cavity = 0.5f;
    [SerializeField] private float _duration = 4f;

    [SerializeField] private ShadowMaterialDissolve dissolve;
    private Vector3 _startPos;
    private GameObject _shadow;

    private void OnEnable()
    {
        _startPos = GameObject.FindGameObjectWithTag("Shadow").transform.position;
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shadow"))
        {
            _shadow = other.gameObject;
            yield return StartCoroutine(dissolve.ShadowFade(_duration, _cavity, 1));
            _shadow.gameObject.SetActive(false);
            _shadow.transform.position = _startPos;
            _shadow.gameObject.SetActive(true);
            yield return StartCoroutine(dissolve.ShadowFade(_duration, 1, _cavity));
        }
    }
}