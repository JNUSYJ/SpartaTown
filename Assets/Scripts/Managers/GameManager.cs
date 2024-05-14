using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 게임매니저 미사용
    public static GameManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
}

public enum CharacterSort
{
    Penguin,
    Wizard
}