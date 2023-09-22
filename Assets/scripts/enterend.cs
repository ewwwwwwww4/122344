using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enterend : MonoBehaviour
{
    private bool enterAllowed;
    private string sceneToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<guest>())
        {
            if (PlayerPrefs.GetInt("MilkteaDestroyed") == 1)
            {
                sceneToLoad = "ending";
                enterAllowed = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        enterAllowed = false;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enterAllowed)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}

