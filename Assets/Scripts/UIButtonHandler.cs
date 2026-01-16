using System;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonHandler : MonoBehaviour
{

    [SerializeField] private Button UIStartButton;
    [SerializeField] private Button UIShootButton;
    [SerializeField] private Button UIResetButton;

    public static event Action OnStartButtonClicked;
    public static event Action OnShootButtonClicked;
    public static event Action OnResetButtonClicked;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UIStartButton.onClick.AddListener(OnStartbuttonClicked);
        UIShootButton.onClick.AddListener(OnShootbuttonClicked);
        UIResetButton.onClick.AddListener(OnResetbuttonClicked);

        UIShootButton.gameObject.SetActive(false);
    }

    void OnStartbuttonClicked()
    {
        OnStartButtonClicked?.Invoke();

        UIStartButton.gameObject.SetActive(false);
        UIShootButton.gameObject.SetActive(true);
    }

    void OnShootbuttonClicked()
    {
        OnShootButtonClicked?.Invoke();
    }

    void OnResetbuttonClicked()
    {
        OnResetButtonClicked?.Invoke();

        UIStartButton.gameObject.SetActive(true);
        UIShootButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}