using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int totalTrash;
    public int collectedTrash;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        totalTrash = GameObject.FindGameObjectsWithTag("pickup").Length;

        Debug.Log("Total Sampah : " + totalTrash);
    }

    public void AddTrash()
    {
        collectedTrash++;

        Debug.Log("Sampah Dibersihkan : "
                  + collectedTrash +
                  "/" +
                  totalTrash);

        if (collectedTrash >= totalTrash)
        {
            WinGame();
        }
    }

    void WinGame()
    {
        Debug.Log("YOU WIN!");

        PlayerPrefs.SetInt("Level2Unlocked", 1);
        PlayerPrefs.Save();
    }
}