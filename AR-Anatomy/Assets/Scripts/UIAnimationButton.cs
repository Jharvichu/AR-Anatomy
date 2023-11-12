using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAnimationButton : MonoBehaviour
{

    [SerializeField]
    float duration;
    [SerializeField]
    float delay;

    [SerializeField]
    AnimationCurve animationCurve;
    [SerializeField]
    RectTransform target;

    [SerializeField]
    Vector3 startingPoint;
    [SerializeField]
    Vector3 finalPoint;
    [ContextMenu("Fade in")]
    public void FadeIn()
    {
        StopAllCoroutines();
        StartCoroutine(FadeInCoroutine(startingPoint, finalPoint));
    }
    [ContextMenu("Fade out")]
    public void FadeOut()
    {
        StopAllCoroutines();
        StartCoroutine(FadeOutCoroutine(startingPoint, finalPoint));
    }

    IEnumerator FadeInCoroutine(Vector3 a, Vector3 b)
    {
        Vector3 staringPoint = a;
        Vector3 finalPoint = b;
        float elapsed = 0;
        while (elapsed <= delay)
        {
            elapsed += Time.deltaTime;
            yield return null;
        }

        elapsed = 0;
        while (elapsed <= duration)
        {
            float percentage = elapsed / duration;
            float curvePercentage = animationCurve.Evaluate(percentage);
            elapsed += Time.deltaTime;
            Vector3 currentPosition = Vector3.LerpUnclamped(startingPoint, finalPoint, curvePercentage);
            target.anchoredPosition = currentPosition;
            yield return null;
        }

        target.anchoredPosition = finalPoint;

    }

    IEnumerator FadeOutCoroutine(Vector2 a, Vector2 b)
    {
        Vector3 staringPoint = a;
        Vector3 finalPoint = b;
        float elapsed = 0;
        while (elapsed <= delay)
        {
            elapsed += Time.deltaTime;
            yield return null;
        }

        elapsed = 0;
        while (elapsed <= duration)
        {
            float percentage = elapsed / duration;
            float curvePercentage = animationCurve.Evaluate(percentage);
            elapsed += Time.deltaTime;
            Vector3 currentPosition = Vector3.LerpUnclamped(finalPoint, staringPoint, curvePercentage);
            target.anchoredPosition = currentPosition;
            yield return null;
        }

        target.anchoredPosition = staringPoint;
    }

}
