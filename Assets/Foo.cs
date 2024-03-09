using R3;
using System;
//using UniRx;
using UnityEngine;

public class Foo : MonoBehaviour
{
    public PropertyHolder propertyHolder;
    public Bar bar;

    void Start()
    {
        propertyHolder.property
            .Skip(1)
            .Subscribe(x => Debug.Log($"[Foo] {x}"))
            .AddTo(this);

        Observable.Return(Unit.Default)
            .Delay(TimeSpan.FromSeconds(1))
            .Take(1)
            .Subscribe(_ =>
            {
                bar.gameObject.SetActive(true);
                Destroy(this.gameObject);
            });
    }
}
