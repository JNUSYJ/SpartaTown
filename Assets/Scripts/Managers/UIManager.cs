using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private InputField nameInputField;
    private CharacterSort characterSort = CharacterSort.Penguin;

    public PlayerInput PlayerInput;
    public Text CharacterNameText;
    public GameObject PenguinImage, WizardImage;
    public GameObject CharacterSelectUI;
    public GameObject PenguinSprite, WizardSprite;

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

    public void OpenCharacterSelectUI()
    {
        CharacterSelectUI.SetActive(true);
    }

    public void SelectCharacter(int characterSort)
    {
        this.characterSort = (CharacterSort)characterSort;
        SetCharacter();
        CharacterSelectUI.SetActive(false);
    }

    public void SetCharacter()
    {
        switch(characterSort)
        {
            case CharacterSort.Penguin:
                PenguinImage.SetActive(true);
                WizardImage.SetActive(false);
                PenguinSprite.SetActive(true);
                WizardSprite.SetActive(false);
                break;
            case CharacterSort.Wizard:
                PenguinImage.SetActive(false);
                WizardImage.SetActive(true);
                PenguinSprite.SetActive(false);
                WizardSprite.SetActive(true);
                break;
        }
    }
}
