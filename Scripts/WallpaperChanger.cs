using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallpaperChanger : MonoBehaviour
{
    public GameObject Wallpaper1;
    public GameObject Wallpaper3;
    public GameObject Wallpaper2;
    public int WPTicker;
    void Start()
    {
        WPTicker = Random.Range(0, 15);
    }

    void Update()
    {
		if (WPTicker > 5)
		{
			Wallpaper1.SetActive(true);
			Wallpaper2.SetActive(false);
			Wallpaper3.SetActive(false);
		}
		if (WPTicker >= 10)
		{
			Wallpaper1.SetActive(false);
			Wallpaper2.SetActive(true);
			Wallpaper3.SetActive(false);
		}
		if (WPTicker <= 5)
		{
			Wallpaper1.SetActive(false);
			Wallpaper3.SetActive(true);
			Wallpaper2.SetActive(false);
		}
	}
	public void ChangeWPRandomly() //If You Want It For A Button
	{
		WPTicker = Random.Range(0, 15);
	}

	 void OnGUI() //If You Want It ONGUI
	{
		GUILayout.BeginArea(new Rect(Screen.width / 2 - 250, Screen.height / 2 - 500, 500, 500));

		if (GUILayout.Button("Random Wallpaper"))
		{
			WPTicker = Random.Range(0, 15);
			Debug.Log("Wallpaper Changed");
		}
	}
}
