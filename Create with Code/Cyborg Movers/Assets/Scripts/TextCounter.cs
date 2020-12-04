using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TextCounter : MonoBehaviour
{
    private Text textObj;
    public float delay = 1f;
    public UnityEvent goEvent;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        textObj = GetComponent<Text>();
        textObj.text = "3";
        var i = 3;
        while (i > 0)
        {
            textObj.text = i.ToString();
            yield return new WaitForSeconds(delay);
            i--;
        }
        
        textObj.text = "GO";
        yield return new WaitForSeconds(delay);
        textObj.text = "   ";
        goEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
