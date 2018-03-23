using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

    Material m_Material;

	void Start () {
        m_Material = GetComponent<Renderer>().material;
        m_Material.color = new Color(0.4f, 0.78f, 0.934f, 1.0f);
	}

	void Update () {
		
	}
}
