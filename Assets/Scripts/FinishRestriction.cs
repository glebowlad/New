using UnityEngine;

public class FinishRestriction : MonoBehaviour
{
    private BoxCollider collider;
    void Start()
    {
        collider = GetComponent<BoxCollider>();
    }
    private void OnTriggerExit(Collider other)
    {
        collider.isTrigger = false;
    }
}
