using UnityEngine;
using Cinemachine;

public class CameraShakeTest : MonoBehaviour
{
    private CinemachineImpulseSource impulseSource;

    void Start()
    {
        impulseSource = GetComponent<CinemachineImpulseSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // جرب الاهتزاز عند الضغط على Space
        {
            impulseSource.GenerateImpulse();
        }
    }
}
