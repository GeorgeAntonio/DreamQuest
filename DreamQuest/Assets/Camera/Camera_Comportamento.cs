using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Comportamento : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (player != null)
        {
            Vector3 startPosition = new Vector3 (player.position.x, player.position.y, -1f);
            Vector3 smoothPosition = Vector3.Lerp(transform.position, startPosition, .5f);
            transform.position = smoothPosition;
        }
    }
}
