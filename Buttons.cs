using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject M_on, M_off;
    public Sprite layer_blue, layer_red;

    void Start()
    {
        if (gameObject.name == "Music")
        {
            if (PlayerPrefs.GetString("Music") == "no")
            {
                M_on.SetActive(false);
                M_off.SetActive(true);
            }
            else
            {
                M_on.SetActive(true);
                M_off.SetActive(false);
            }
        }
    }

    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = layer_red;
    }
    void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = layer_blue;
    }
    void OnMouseUpAsButton()
    {
        if (PlayerPrefs.GetString("Music") != "no")
           GameObject.Find ("Click Audio").GetComponent<AudioSource>().Play();
        switch (gameObject.name)
        {
            case "Play":
//#pragma warning disable CS0618 // The type or member is deprecated
                Application.LoadLevel("play");

                break;
            case "Rating":
                Application.OpenURL("https://t.me/dabidibu");
                break;
            case "Replay":

                Application.LoadLevel("play");

                break;
            case "Home":

                Application.LoadLevel("main");

                break;
            case "info":
                Application.LoadLevel("howTo");
                break;
            case "Close":
                Application.LoadLevel("main");
                break;
//#pragma warning restore CS0618 // The type or member is deprecated
            case "Music":
                if (PlayerPrefs.GetString("Music") != "no")
                {
                    PlayerPrefs.SetString("Music", "no");
                    M_on.SetActive(false);
                    M_off.SetActive(true);
                }
                else
                {
                    PlayerPrefs.SetString("Music", "yes");
                    M_on.SetActive(true);
                    M_off.SetActive(false);
                } 

                break;
        }
    }
}
