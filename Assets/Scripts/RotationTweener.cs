using DG.Tweening;
using System.Collections;
using UnityEngine;

public class RotationTweener : MonoBehaviour
{
    [SerializeField] private float _duraion = 1f;

    private void Start()
    {
        transform
            .DOLocalRotate(new Vector3(0, 90), _duraion)
            .SetRelative()
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Incremental);
    }
}
