using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
       
    private void update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
