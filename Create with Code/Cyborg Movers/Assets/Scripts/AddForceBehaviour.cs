using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AddForceBehaviour : MonoBehaviour
{
    private Rigidbody ridgid;
    public Vector3 forces, forces2;
    public float holdTime = 3f;
    public int counter = 10;
    public bool canRun;
    // Start is called before the first frame update
    private IEnumerator Start()
    {
        ridgid = GetComponent<Rigidbody>();

        while (counter > 0)
        {
            yield return new WaitForSeconds(holdTime);
            ridgid.AddForce(forces);
            counter--;
        }
        while (canRun)
        {
            yield return new WaitForSeconds(holdTime);
            ridgid.AddForce(forces2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
