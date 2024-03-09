using UnityEngine;

public class Bar : MonoBehaviour
{
    public BarItem item;

    void Start()
    {
        item.gameObject.SetActive(true);
    }
}
