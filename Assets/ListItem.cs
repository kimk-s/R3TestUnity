using UnityEngine;

public class ListItem : MonoBehaviour
{
    public ListItemContent content;

    void Start()
    {
        content.gameObject.SetActive(true);
    }
}
