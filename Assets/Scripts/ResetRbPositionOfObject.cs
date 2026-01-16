using UnityEngine;

public class ResetRbPositionOfObject : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;
    private Vector3 rbStartPosition;
    private Quaternion rbStartRotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UIButtonHandler.OnResetButtonClicked += () => ResetRbPositionOnButtonClicked();

        rbStartPosition = rb.transform.localPosition;
        rbStartRotation = rb.transform.localRotation;
    }
    private void ResetRbPositionOnButtonClicked()
    {
        rb.isKinematic = true;
        rb.transform.localPosition = rbStartPosition;
        rb.transform.localRotation = rbStartRotation;

        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
    private void OnDestroy()
    {
        UIButtonHandler.OnResetButtonClicked -= () => ResetRbPositionOnButtonClicked();
    }
}
