using DG.Tweening;
using UnityEngine;

public class PositionTweener : MonoBehaviour
{
    [SerializeField] private float _duration = 1f;

    private void Start()
    {
        transform
            .DOMove(transform.forward, _duration)
            .SetRelative(true)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Incremental);
    }
}
