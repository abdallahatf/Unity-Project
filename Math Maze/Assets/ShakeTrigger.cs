using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;

public class ShakeTrigger : MonoBehaviour
{
    private CinemachineImpulseSource impulseSource;
    private CharacterController controller;

    void Start()
    {
        impulseSource = GetComponent<CinemachineImpulseSource>();
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.velocity.magnitude > 2f)
        {
            impulseSource.GenerateImpulse();
        }
    }
}