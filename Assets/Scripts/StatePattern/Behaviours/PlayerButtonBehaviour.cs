using UnityEngine;
using UnityEngine.UI;

public class PlayerButtonBehaviour : MonoBehaviour, ISetInteractable
{
    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();

        SetInteractable(false);
    }

    public void SetInteractable(bool set)
    {
        button.interactable = set;
    }
}