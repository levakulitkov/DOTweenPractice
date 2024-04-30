using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ColorTweener : MonoBehaviour
{
    [SerializeField] private Color _targetColor;
    [SerializeField] private float _duration = 1f;
    
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    void Start()
    {
        _renderer.material
            .DOColor(_targetColor, _duration)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.Linear);
    }
}
