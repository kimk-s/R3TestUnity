using R3;
//using UniRx;
using UnityEngine;

public class BarItem : MonoBehaviour
{
    public PropertyHolder propertyHolder;

    void Start()
    {
        propertyHolder.property
            .Skip(1)
            .Subscribe(x => Debug.Log($"[BarItem] {x}"))
            .AddTo(this);

        propertyHolder.property.Value = 1;
        propertyHolder.property.Value = 2;
    }
}