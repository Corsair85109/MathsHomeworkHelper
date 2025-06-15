using TMPro;
using UnityEngine;

public class ListButtonControl : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI tmp;

    public void SetText(string text)
    {
        tmp.text = text;
    }
        
}
