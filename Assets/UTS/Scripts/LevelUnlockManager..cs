using UnityEngine;
using UnityEngine.UI;

public class LevelUnlockManager : MonoBehaviour
{
    public Button level2Button;
    public GameObject lockIcon;

    void Start()
    {
        bool unlocked =
            PlayerPrefs.GetInt("Level2Unlocked", 0) == 1;

        level2Button.interactable = unlocked;

        lockIcon.SetActive(!unlocked);
    }
}