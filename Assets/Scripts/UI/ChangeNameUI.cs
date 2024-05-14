public class ChangeNameUI : CharacterUI
{
    public void OpenChangeNameUI()
    {
        PlayerInput.enabled = false;
        gameObject.SetActive(true);
    }
}
