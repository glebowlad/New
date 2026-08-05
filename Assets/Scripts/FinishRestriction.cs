using UnityEngine;

public class FinishRestriction : MonoBehaviour
{
    public BoxCollider collider;
    void Start()
    {
        collider = GetComponent<BoxCollider>();
    }
    private void OnTriggerExit(Collider other)
    {
        collider.isTrigger = false;
    }
}
