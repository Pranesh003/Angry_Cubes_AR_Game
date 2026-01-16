using Unity.Mathematics;
using UnityEngine;

public class ShootBallLogic : MonoBehaviour
{
    private Camera mainCamera;

    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private float ballForwardForce = 500f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera = FindObjectOfType<Camera>();
        UIButtonHandler.OnShootButtonClicked += () => ShootBallOnButtonClicked();
    }

    private void ShootBallOnButtonClicked()
    {
        Vector3 spawnPosition = mainCamera.transform.position + mainCamera.transform.forward * 0.1f;
        quaternion spawnRotation = mainCamera.transform.rotation;

        GameObject ball = Instantiate(ballPrefab, spawnPosition, spawnRotation);
        Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();

        if (ballRigidbody != null)
        {
            ballRigidbody.AddForce(mainCamera.transform.forward*ballForwardForce);
        }

        Destroy(ball, 5f); 
    }

}
