using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 미사용
    public static GameManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
}

enum CharacterSort
{
    Penguin,
    Wizard
}