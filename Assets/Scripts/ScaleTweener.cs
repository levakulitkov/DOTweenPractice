using DG.Tweening;
using UnityEngine;

public class ScaleTweener : MonoBehaviour
{
    [SerializeField] private float _duration = 1f;
    [SerializeField] private float _scaleMultiplier = 1.5f;

    private void Start()
    {
        transform
            .DOScale(transform.localScale * _scaleMultiplier, _duration)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
