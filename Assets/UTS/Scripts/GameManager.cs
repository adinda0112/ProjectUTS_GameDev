using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int totalTrash;
    public int collectedTrash;

    public TMP_Text trashText;

    [Header("Win Panel")]
    public GameObject winPanel;
    public TMP_Text winTrashText;
    public TMP_Text winTimeText;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        totalTrash = GameObject.FindGameObjectsWithTag("pickup").Length;

        UpdateTrashUI();
    }

    public void AddTrash()
    {
        collectedTrash++;

        UpdateTrashUI();

        Debug.Log("Sampah Dibersihkan : "
                  + collectedTrash +
                  "/" +
                  totalTrash);

        if (collectedTrash >= totalTrash)
        {
            WinGame();
        }
    }

    void UpdateTrashUI()
    {
        trashText.text = collectedTrash + " / " + totalTrash;
    }

    void WinGame()
    {
        Debug.Log("YOU WIN!");

        Time.timeScale = 0f;

        winPanel.SetActive(true);

        winTrashText.text =
            "Trash : " +
            collectedTrash +
            " / " +
            totalTrash;

        TimerManager timer =
            FindFirstObjectByType<TimerManager>();

        if (timer != null)
        {
            int timeLeft =
                Mathf.CeilToInt(timer.timeRemaining);

            winTimeText.text =
                "Time Left : " + timeLeft + " s";
        }
    }
}