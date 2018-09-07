using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraScript : MonoBehaviour
{

	static WebCamTexture backCam;

	void Start()
	{
		if (backCam == null)
			backCam = new WebCamTexture();

		GetComponent<Image>().material.mainTexture = backCam;

		if (!backCam.isPlaying)
			backCam.Play();

	}

	void Update()
	{

	}
}