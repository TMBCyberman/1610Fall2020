using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class CoroutineBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, repeatEvent, endEvent;
    public float holdTime, repeatHoldTime = 0.25f;
    public int counter = 3;

    public void RunCorouine()
    {
        StartCoroutine(Coroutine());
    }

    private IEnumerator Coroutine()
    {
        startEvent.Invoke();
        
        yield return new WaitForSeconds(holdTime);

        while (counter > 0)
        {
            repeatEvent.Invoke();
            yield return new WaitForSeconds(repeatHoldTime);
            counter--;
        }
        
        yield return new WaitForSeconds(repeatHoldTime);
        endEvent.Invoke();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
