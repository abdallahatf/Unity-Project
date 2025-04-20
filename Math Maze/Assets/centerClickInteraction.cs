using UnityEngine;

public class CenterClickInteraction : MonoBehaviour
{
    public float moveAmount = 2f;
    public float moveSpeed = 5f;
    public Camera mainCamera;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
 
             Debug.Log("Click detected");

            Ray ray = mainCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                 Debug.Log("Hit: " + hit.collider.name);
                
                // run interaction here
            }
            else
            {
                Debug.Log("Did not hit anything.");
            }
        }
    }
}