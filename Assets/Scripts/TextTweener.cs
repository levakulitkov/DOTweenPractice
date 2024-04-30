using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextTweener : MonoBehaviour
{
    [SerializeField] private float _duration = 1f;

    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(1);
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("Замененный текст", _duration));
        sequence.Append(_text.DOText(" Добавленный текст", _duration).SetRelative(true));
        sequence.Append(_text.DOText("Замененный перебором текст", _duration, false, ScrambleMode.All));

        sequence.SetLoops(-1);
    }
}
