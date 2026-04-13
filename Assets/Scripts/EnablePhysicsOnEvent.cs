using UnityEngine;

public class EnablePhysicsOnEvent : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UIButtonHandler.OnStartButtonClicked += () => StartPhysicsOnButtonClicked();
        rb.isKinematic = true;
    }

    private void StartPhysicsOnButtonClicked()
    {
        rb.isKinematic = false;
        rb.useGravity = true;
    }
    private void OnDestroy()
    {
        UIButtonHandler.OnStartButtonClicked -= () => StartPhysicsOnButtonClicked();
    }
}
