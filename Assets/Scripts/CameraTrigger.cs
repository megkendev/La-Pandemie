using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraTrigger : MonoBehaviour
{
    public GameObject newCamera, oldCamera;
    public float waitTime;
    public bool triggered;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            StartCoroutine(CameraSwap());
            triggered = true;
        }

    }

    IEnumerator CameraSwap()
    {
        newCamera.SetActive(true);
        yield return new WaitForSeconds(waitTime);
        newCamera.SetActive(false);
    }
}
