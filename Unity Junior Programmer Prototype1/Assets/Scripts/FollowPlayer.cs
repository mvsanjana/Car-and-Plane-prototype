using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /*void Update()
    {
        //transform.position = player.transform.position; //The script is for main camera. So it's position will change with
                                                        // reference to the player's position with this line of code
                                                        //But this is giving the view below the player (0,0,0). We want the view on top of the player
        //transform.position = player.transform.position + new Vector3(0, 5, -7); //Since initial main camera's position (which
                                                                                // is giving the top view) is (0, 5, -7)
                                                                                //But this is hardcoded, not desirable, hence assign this to the offset variable
                                                                                //for easy changes
        transform.position = player.transform.position + offset; 
        //Update() causes maincamera to stutter because in some frames the player moves first, in others the maincamera moves first
    }*/

    //LateUpdate() will update after the Update()
    //Vehicle moves during Update() so put the above code in LateUpdate() so that the camera moves during LateUpdate()
    //Therefore this way, camera moves after the vehicle moves

    void LateUpdate()
    {
        transform.position = player.transform.position + offset; 
    }
}
