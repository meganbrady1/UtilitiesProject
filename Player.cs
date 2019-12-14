using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 moveForward = Vector3.zero;
    public float Zincrement;
    public float speed;


    private OVRPlayerController controller;
    [SerializeField]
    private float moveSpeedMultiplier = 3.0f;
    [SerializeField]
    private bool allowDoubleSpeed = false;
    //[SerializeField]
    //public GameObject highScoretxt;
    //public int highScore;
    //public int score;
    void Start()
    {
        controller = GetComponent<OVRPlayerController>();
        controller.SetMoveScaleMultiplier(moveSpeedMultiplier);

        moveForward = new Vector3(transform.position.x, transform.position.y, transform.position.z + Zincrement);
        transform.position = Vector3.MoveTowards(transform.position, moveForward, speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        moveForward = new Vector3(transform.position.x, transform.position.y, transform.position.z + Zincrement);
        transform.position = Vector3.MoveTowards(transform.position, moveForward, speed * Time.deltaTime);

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            controller.Jump();
        }

        if(OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger) && allowDoubleSpeed)
        {
            controller.SetMoveScaleMultiplier(moveSpeedMultiplier * 2.0f);
        }
        else
        {
            controller.SetMoveScaleMultiplier(moveSpeedMultiplier);
        }

        //score++;
    }

}
