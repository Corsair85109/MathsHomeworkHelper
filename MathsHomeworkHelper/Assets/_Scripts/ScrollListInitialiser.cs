using UnityEngine;

public class ScrollListInitialiser : MonoBehaviour
{
    [SerializeField]
    private Transform content;

    [SerializeField]
    private GameObject buttonPrefab;

    [SerializeField]
    private ScrollListType type;

    public void Start()
    {
        GameObject button;

        if (type == ScrollListType.Categories)
        {
            foreach (var item in Features.features)
            {
                button = Instantiate(buttonPrefab, content);
                button.SetActive(true);
                button.name = item.Key;
                button.GetComponent<ListButtonControl>().SetText(item.Key);
            }
        }
    }



    public enum ScrollListType
    {
        Categories,
        Feature
    }
}
