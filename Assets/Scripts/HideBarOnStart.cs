using UnityEngine;

public class HideBarOnStart : MonoBehaviour
{
    [SerializeField] private Canvas ARMagicBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UIButtonHandler.OnStartButtonClicked += () => OnStartButtonClicked();
        UIButtonHandler.OnResetButtonClicked += () => OnResetButtonClicked();
    }
    private void OnStartButtonClicked()
    {
        ARMagicBar.enabled = false;
    }
    private void OnResetButtonClicked()
    {
        ARMagicBar.enabled = true;
        
    }
 
}
