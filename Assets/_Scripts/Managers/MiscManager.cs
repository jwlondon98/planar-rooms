using System;
using UnityEngine;
using DG.Tweening;

public class MiscManager : MonoBehaviour
{
    public static MiscManager instance;

    [Range(0f, 100f)] public float outlineWidth;

    public event Action<float> updateOutline;

    [SerializeField] private float outlineIntroDuration;
    
    void Awake ()
    {
        instance = this;
    }

    void Start()
    {
        TweenOutline();
    }

    void Update()
    {
    }

    [ContextMenu("Tween Outline")]
    public void TweenOutline()
    {
        Debug.Log("Tween Outline started");
        DOTween.To(() => outlineWidth, x => outlineWidth = x, 10, outlineIntroDuration)
            .SetEase(Ease.InCubic)
            .OnUpdate(() => {
                Debug.Log(outlineWidth);
                updateOutline(outlineWidth);
            });
    }
}