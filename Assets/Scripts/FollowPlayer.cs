using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, (float)4.5, -9);

    // Start is called before the first frame update up
    void Start()
    {

    }

    // Update is called once per frame2
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
