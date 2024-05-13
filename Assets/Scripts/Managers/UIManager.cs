using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private InputField nameInputField;

    public PlayerInput PlayerInput;
    public Text CharacterNameText;

    private void Awake()
    {
        nameInputField = GetComponentInChildren<InputField>();
    }

    public void Join()
    {
        if (nameInputField == null) { return; }

        string name = nameInputField.text;
        if (2 <= name.Length && name.Length <= 10)
        {
            CharacterNameText.text = name;
            gameObject.SetActive(false);
            PlayerInput.enabled = true;
        }
    }
}
