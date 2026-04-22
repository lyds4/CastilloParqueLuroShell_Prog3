using UnityEngine;

public class SkydomeFollow : MonoBehaviour
{
    public Transform player;

    void LateUpdate()
    {
        transform.position = player.position;
    }
}