using R3;
using System;
//using UniRx;
using UnityEngine;

public class Baz : MonoBehaviour
{
    public PropertyHolder propertyHolder;

    void Start()
    {
        Observable.Return(Unit.Default)
            .Delay(TimeSpan.FromSeconds(3))
            .Take(1)
            .Subscribe(_ =>
            {
                propertyHolder.property.Skip(1).Subscribe(x => Debug.Log($"[Baz] {x}"));
                propertyHolder.property.Value = 3;
            });
    }
}
