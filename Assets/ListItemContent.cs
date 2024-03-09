using R3;
using UnityEngine;

public class ListItemContent : MonoBehaviour
{
    public List list;
    public int id;

    void Start()
    {
        list.reactiveProperty
            .Skip(1)
            .Subscribe(x => Debug.Log($"[ListItemContent {id}] OnNext {x}"))
            .AddTo(this);
    }
}
