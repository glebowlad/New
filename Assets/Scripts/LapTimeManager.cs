using System;
using System.Collections;
using TMPro;
using UnityEngine;
public class LapTimeManager : MonoBehaviour
{
    public TextMeshProUGUI lapText, bestTimeText, startCounter;
    public static float SecCount;
    public System.TimeSpan time;
    private static TimeSpan bestTime;
    public PrometeoCarController carController;
    void Start()
    {
        carController.enabled = false;
        StartCoroutine(CountStart());
    }
    public IEnumerator CountStart()
    {
        startCounter.text = "3";
        yield return new WaitForSeconds(1f);
        startCounter.text = "2";
        yield return new WaitForSeconds(1f);
        startCounter.text = "1";
        yield return new WaitForSeconds(1f);
        startCounter.text = "GO!!!";
        carController.enabled=true;
        SecCount = 0;
        lapText.text = SecCount.ToString();
        startCounter.enabled = false;
    }
    void Update()
    {
        SecCount += Time.deltaTime;
        time = System.TimeSpan.FromSeconds(SecCount);
        lapText.text = string.Format("{0:D2}:{1:D2}.{2:D2}", time.Minutes, time.Seconds, time.Milliseconds/10);
    }
    public void SetBestTime(float best)
    {
        bestTime = System.TimeSpan.FromSeconds(best);
        bestTimeText.text = string.Format("{0:D2}:{1:D2}.{2:D2}", bestTime.Minutes, bestTime.Seconds, bestTime.Milliseconds / 10);
    }
}
