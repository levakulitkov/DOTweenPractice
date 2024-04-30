using DG.Tweening;
using UnityEngine;

public class ComplexTransformTweener : MonoBehaviour
{
    [SerializeField] private float _positionChangingDuration = 1f;
    [SerializeField] private float _rotationChangingDuration = 1f;
    [SerializeField] private float _scaleChangingDuration = 1f;
    [SerializeField] private float _scaleMultiplier = 1.5f;

    private Tweener _positionTween;
    private Vector3 _lastTarget;

    private void Start()
    {
        _lastTarget = transform.position + transform.forward;

        _positionTween = transform
                .DOMove(_lastTarget, _positionChangingDuration)
                .SetEase(Ease.Linear)
                .SetLoops(-1, LoopType.Incremental);

        transform
            .DOLocalRotate(new Vector3(0, 90), _rotationChangingDuration)
            .SetRelative()
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Incremental);

        transform
            .DOScale(transform.localScale * _scaleMultiplier, _scaleChangingDuration)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Yoyo);
    }

    private void Update()
    {
        Vector3 target = transform.position + transform.forward;

        if (_lastTarget != target)
        {
            _positionTween.ChangeEndValue(target, _positionChangingDuration, true);

            _lastTarget = target;
        }
    }
}
