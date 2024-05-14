using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class CharacterUI : MonoBehaviour
{
    private InputField nameInputField;                  // 이름 입력란
    private CharacterSort characterSort = CharacterSort.Penguin;

    public PlayerInput PlayerInput;                     // Input system
    public Text CharacterNameText;                      // 캐릭터 머리 위 이름 UI
    public GameObject UIPenguinImage, UIWizardImage;    // 스프라이트가 담긴 UI 버튼
    public GameObject CharacterSelectUI;                // 캐릭터 변경 UI (패널)
    public GameObject PenguinSprite, WizardSprite;      // 캐릭터 스프라이트

    private void Awake()
    {
        nameInputField = GetComponentInChildren<InputField>();
    }

    // UI 버튼으로 호출
    public void OpenCharacterSelectUI()
    {
        CharacterSelectUI.SetActive(true);  // 캐릭터 선택 UI 활성화
    }

    // UI 버튼으로 호출
    public void SelectCharacter(int characterSort)
    {
        this.characterSort = (CharacterSort)characterSort;
        SetSelectedCharacter(); // 고른 캐릭터로 변경
        CharacterSelectUI.SetActive(false); // 캐릭터 선택 UI 종료
    }

    public void SetSelectedCharacter()
    {
        switch(characterSort)
        {
            case CharacterSort.Penguin:
                // UI 버튼 변경
                UIPenguinImage.SetActive(true);
                UIWizardImage.SetActive(false);
                // 캐릭터 스프라이트 변경
                PenguinSprite.SetActive(true);
                WizardSprite.SetActive(false);
                break;
            case CharacterSort.Wizard:
                UIPenguinImage.SetActive(false);
                UIWizardImage.SetActive(true);
                PenguinSprite.SetActive(false);
                WizardSprite.SetActive(true);
                break;
        }
    }

    // UI 버튼으로 호출
    public void Join()
    {
        if (nameInputField == null) { return; }

        string name = nameInputField.text;
        if (2 <= name.Length && name.Length <= 10)
        {
            CharacterNameText.text = name;  // 이름 설정
            gameObject.SetActive(false);    // UI 종료
            PlayerInput.enabled = true;     // 캐릭터 입력 활성화
        }
    }
}
