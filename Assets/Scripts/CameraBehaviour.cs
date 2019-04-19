using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    [Tooltip ("Camera pointing destination")]
    public Transform target;
    [Tooltip ("Camera offset to target")]
    public Vector3 offset  = new Vector3(0,3,-6);
    void Update()
    {
        if (target!= null)
        {
            transform.position = target.position + offset;

            transform.LookAt(target);
        }
    }
}
