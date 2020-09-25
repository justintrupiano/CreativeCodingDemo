using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    // public vars are accessible in the editor and other scripts
    public float speed;
    public Transform openTransform;
    public Transform closedTransform;

    // private vars are only accessible localy
    private Transform currentTarget;

    // Start is called before the first frame update
    void Start(){
      // Start with the door closed
      currentTarget = closedTransform;
    }

    // Update is called once per frame
    void Update()
    {
      // Rotate the door
      RotateDoor();

      // Check if the Space key is pressed
      if (Input.GetKeyUp(KeyCode.Space)){
        // If so, switch the currentTarget
        SwitchTarget();
      }
    }


    private void RotateDoor(){
      // Only run if the currentTarget and the transform are not equal
      if (currentTarget.rotation != transform.rotation){
        // Using the Quaternion method RotateTowards, change the transform to get closer to the target transform.
        transform.rotation = Quaternion.RotateTowards(transform.localRotation, currentTarget.rotation, speed * Time.deltaTime);
      }
    }

    private void SwitchTarget(){
      // Switch the currentTarget transform.
      currentTarget = (currentTarget == openTransform) ? closedTransform : openTransform;


      // if (currentTarget == openTransform ){
      //   currentTarget = closedTransform;
      // } else {
      //   currentTarget = openTransform;
      // }

      // if (true){
      //   // Do something
      // }













    }
}
