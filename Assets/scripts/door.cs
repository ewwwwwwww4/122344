using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class door : MonoBehaviour
{

    [SerializeField]
    TMP_Text speechUIAlso1;
    public TMP_Text speechUI1;
    public string doorDialogue;
    public GameObject textObject1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)//2d only
    {
        Debug.Log("Collided with" + collision.gameObject.name);
        if (collision.gameObject.name == "player")
        {
            textObject1.SetActive(true);
            speechUI1.text = doorDialogue;
            InvokeRepeating("Hide", 3.0f, 0f);
        }


    }
    private void Hide()
    {
        textObject1.SetActive(false);
    }
}
