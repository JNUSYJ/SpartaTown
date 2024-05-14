using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class CharacterUI : MonoBehaviour
{
    public PlayerInput PlayerInput;         // Input system
    public Text CharacterNameText;          // 캐릭터 머리 위 이름 UI

    protected CharacterSort characterSort = CharacterSort.Penguin;
    protected InputField nameInputField;    // 이름 입력란

    public virtual void Awake()
    {
        nameInputField = GetComponentInChildren<InputField>();
    }

    // UI 버튼으로 호출
    public virtual void Confirm()
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
