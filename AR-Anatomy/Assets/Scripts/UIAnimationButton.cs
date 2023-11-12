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
    Vector2 startingPoint;
    [SerializeField]
    Vector2 finalPoint;
    [ContextMenu("Fade in")]
    public void FadeIn()
    {
        StopAllCoroutines();
        StartCoroutine(FadeInCoroutine(startingPoint,finalPoint));
    }
    [ContextMenu("Fade out")]
    public void FadeOut()
    {
        StopAllCoroutines();
        StartCoroutine(FadeInCoroutine(finalPoint,startingPoint));
    }

    IEnumerator FadeInCoroutine(Vector2 a, Vector2 b)
    {
        Vector2 staringPoint = a;
        Vector2 finalPoint = b;
        float elapsed = 0;
        while (elapsed <= delay)
        {
            elapsed = Time.deltaTime;
            yield return null;
        }

        elapsed = 0;
        while (elapsed <= duration)
        {
            float percentage = elapsed / duration;
            float curvePercentage = animationCurve.Evaluate(percentage);
            elapsed += Time.deltaTime;
            Vector2 currentPosition = Vector2.LerpUnclamped(startingPoint, finalPoint, curvePercentage);
            target.anchoredPosition = currentPosition;
            yield return null;
        }

        target.anchoredPosition = finalPoint;

    }
}
