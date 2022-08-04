using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fireworks : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    ParticleSystem ps;
    bool emit;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        text.gameObject.SetActive(true);
        ps.startColor = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !emit)
        {
            emit = true;
        }

        if (emit)
        {
            ps.Emit(200);
            emit = false;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            text.text = "I love you!";
        }
    }
}
