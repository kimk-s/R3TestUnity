using R3;
using System;
using UnityEngine;

public class List : MonoBehaviour
{
    public ReactiveProperty<int> reactiveProperty;

    public ListItem listItem1;
    public ListItem listItem2;

    void Awake()
    {
        reactiveProperty = new ReactiveProperty<int>().AddTo(this);
    }

    void Start()
    {
        Debug.Log("[List] Start");

        Observable.Interval(TimeSpan.FromSeconds(1))
            .Take(3)
            .Subscribe(_ =>
            {
                reactiveProperty.Value++;
            },
            result => Debug.Log("[List] Completed"))
            .AddTo(this);

        reactiveProperty
            .Subscribe(x =>
            {
                Debug.Log("[List] {}");
                if (reactiveProperty.Value == 2)
                {
                    listItem2.gameObject.SetActive(true);
                    Destroy(listItem1.gameObject);
                }
            })
            .AddTo(this);
    }
}
