using UnityEngine;

public class MoveUpOnClick : MonoBehaviour
{
    public float moveAmount = 2f;
    public float moveSpeed = 5f;

    private bool isMoving = false;
    private Vector3 targetPosition;

    public void Move()
    {
        if (!isMoving)
        {
            targetPosition = transform.position + Vector3.up * moveAmount;
            isMoving = true;
        }
    }

    void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
            {
                isMoving = false;
            }
        }
    }
}

