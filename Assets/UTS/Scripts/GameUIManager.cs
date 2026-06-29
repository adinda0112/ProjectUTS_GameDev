using UnityEngine;

public class GameUIManager : MonoBehaviour
{
    public static GameUIManager Instance;

    public PauseMenu pauseMenu;

    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
#if UNITY_EDITOR

        // Hanya untuk testing di PC

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                pauseMenu.OpenPause();
            }
            else
            {
                pauseMenu.ResumeGame();
            }
        }

#endif
    }
}