using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowMaterialDissolve : MonoBehaviour
{
    [SerializeField] private Material _material;

    public IEnumerator ShadowFade(float duration, float startScale, float endScale)
    {
        for (float t = 0; t <= duration; t += Time.deltaTime)
        {
            _material.SetFloat("_cavity", Mathf.Lerp(startScale, endScale, t / duration));
            yield return null;
        }
    }
}
