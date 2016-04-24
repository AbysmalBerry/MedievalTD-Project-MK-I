using UnityEngine;
using System.Collections;

public class PlayButtonMainMenu : MonoBehaviour {

    public Sprite DefaultPlayButton;
    public Sprite HoverPlayButton;

    private SpriteRenderer PlayButtonRenderer;

    void Start()
    {
        PlayButtonRenderer = GetComponent<SpriteRenderer>();
        if(PlayButtonRenderer.sprite == null)
        {
            PlayButtonRenderer.sprite = DefaultPlayButton;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("Level1");
        }


    }
 
}
