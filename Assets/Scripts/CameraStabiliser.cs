using UnityEngine;

public class CameraStabiliser : MonoBehaviour
{
    public GameObject Car;
    private float carX, carY, carZ;
    void Update()
    {
        carX = Car.transform.eulerAngles.x;
        carY = Car.transform.eulerAngles.y;
        carZ = Car.transform.eulerAngles.z;
        transform.eulerAngles = new Vector3(carX-carX, carY, carZ-carZ);
    }
}
