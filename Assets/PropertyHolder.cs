using R3;
//using UniRx;
using UnityEngine;

public class PropertyHolder : MonoBehaviour
{
    public ReactiveProperty<int> property;

    void Awake()
    {
        property = new ReactiveProperty<int>().AddTo(this);

        property
            .Skip(1)
            .Subscribe(x => Debug.Log($"[PropertyHelper] {x}"));
    }
}
