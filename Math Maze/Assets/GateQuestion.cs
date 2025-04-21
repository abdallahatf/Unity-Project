using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GateQuestion : MonoBehaviour
{
    [Header("UI Elements")]
    public GameObject questionUI;
    public TextMeshProUGUI questionText;
    public Button correctButton;
    public Button wrongButton;
    public GameObject playerControllerObject;


    [Header("Question")]
    [TextArea]
    public string question;
    public bool correctAnswerIsTrue = true;

    private bool isAnswered = false;
    private MoveUpOnClick moveScript;

    void Start()
    {
        questionUI.SetActive(false);
        moveScript = GetComponent<MoveUpOnClick>();
    }

    public void ShowQuestion()
    {
        if (playerControllerObject != null)
            playerControllerObject.SetActive(false);

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        if (isAnswered) return;

        questionText.text = question;

        if (correctAnswerIsTrue)
        {
            correctButton.onClick.RemoveAllListeners();
            correctButton.onClick.AddListener(() => Answer(true));
            wrongButton.onClick.RemoveAllListeners();
            wrongButton.onClick.AddListener(() => Answer(false));
        }
        else
        {
            correctButton.onClick.RemoveAllListeners();
            correctButton.onClick.AddListener(() => Answer(false));
            wrongButton.onClick.RemoveAllListeners();
            wrongButton.onClick.AddListener(() => Answer(true));
        }

        questionUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Answer(bool isCorrect)
    {
        if (playerControllerObject != null)
            playerControllerObject.SetActive(true);

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        questionUI.SetActive(false);
        Time.timeScale = 1f;

        if (isCorrect)
        {
            isAnswered = true;
            moveScript?.Move();
        }
        else
        {
            Debug.Log("Wrong Answer");
        }
    }
}


