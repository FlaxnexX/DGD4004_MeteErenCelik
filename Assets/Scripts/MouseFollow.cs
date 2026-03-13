using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    public float rotationSpeed = 15f;
    float maxDistance = 250f;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 target;
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, maxDistance))
        {
             target = hit.point;
        }
        else
        {
             target = ray.GetPoint(maxDistance);
        }

        Quaternion targetRotation = Quaternion.LookRotation(target - transform.position);

        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            targetRotation,
            rotationSpeed * Time.deltaTime
        );
    }
}
