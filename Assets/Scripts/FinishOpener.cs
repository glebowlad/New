using UnityEngine;

public class FinishOpener : MonoBehaviour
{
    public LapTimeManager lapTimeManager;
    public BoxCollider opener;
    public float lapTime;
    public float bestTime;
    void Start()
    {
        bestTime = Mathf.Infinity;
    }

    private void OnTriggerEnter(Collider other)
    {
        opener.isTrigger = true;
        lapTime = LapTimeManager.SecCount;
        LapTimeManager.SecCount = 0;
        if (lapTime < bestTime)
        {
            bestTime = lapTime;
            lapTimeManager.SetBestTime(bestTime);
        }
    }
}
