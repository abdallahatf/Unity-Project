using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    void Start()
    {
        // قفل وإخفاء الماوس عند بدء اللعب
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void UnlockMouse()
    {
        // فتح الماوس عند الإجابة
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
