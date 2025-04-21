using UnityEngine;

public class CenterClickInteraction : MonoBehaviour
{
    public Camera mainCamera;

    void Start()
    {
        if (mainCamera == null)
            mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Debug.Log("Hit: " + hit.collider.name);

                GateQuestion question = hit.collider.GetComponent<GateQuestion>();
                if (question != null)
                {
                    question.ShowQuestion();
                    return;
                }

                MoveUpOnClick mover = hit.collider.GetComponent<MoveUpOnClick>();
                if (mover != null)
                {
                    mover.Move();
                }
            }
        }
    }
}
