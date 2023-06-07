using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour {

    private Prect p;
    private Color c;

    // Start is called before the first frame update
    void Start()
    {
       p = new Prect("PrimRect", 40, 40, 100, 100, false, "simple");
       c = new Color(1, 0.5f, 0);
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnGUI()
    {
        Manager.GUIDrawRect(p.rect, c);
    }

}
