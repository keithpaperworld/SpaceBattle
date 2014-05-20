using UnityEngine;
using System.Collections;

public class FadeIn : MonoBehaviour {
    public float fadeSpeed = 1.5f;          // Speed that the screen fades to and from black.
     

    private bool sceneStarting = true;      // Whether or not the scene is still fading in.

	// Use this for initialization
	void Start () {

        guiTexture.pixelInset = new Rect(guiTexture.pixelInset.y, guiTexture.pixelInset.y, Screen.width, Screen.height);

	}
	
	// Update is called once per frame
	void Update () {
        // If the scene is starting...
        if (sceneStarting)
        {
            // ... call the StartScene function.
            StartScene();
        }
	}

    void StartScene()
    {
        // Fade the texture to clear.
        FadeToClear();

        // If the texture is almost clear...
        if (guiTexture.color.a <= 0.05f)
        {
            // ... set the colour to clear and disable the GUITexture.
            guiTexture.color = Color.clear;
            guiTexture.enabled = false;

            // The scene is no longer starting.
            sceneStarting = false;
        }
    }

    void FadeToClear()
    {
        // Lerp the colour of the texture between itself and transparent.
        guiTexture.color = Color.Lerp(guiTexture.color, Color.clear, fadeSpeed * Time.deltaTime);
    }
}
