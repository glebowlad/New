using UnityEngine;
using TMPro;
public class LapCounter : MonoBehaviour
{
    private TextMeshProUGUI lapText;
    public int totalLaps;
    public static int CurrentLap;
    public GameObject GameUI;
    public GameObject WinUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameUI.SetActive(true);
        WinUI.SetActive(false);
        Time.timeScale = 1;
        lapText = GetComponent<TextMeshProUGUI>();
        CurrentLap = 0;
        lapText.text = CurrentLap.ToString()+"/"+totalLaps.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        lapText.text = CurrentLap.ToString() + "/" + totalLaps.ToString();
        if (CurrentLap == totalLaps)
        {
            GameUI.SetActive(false);
            WinUI.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
