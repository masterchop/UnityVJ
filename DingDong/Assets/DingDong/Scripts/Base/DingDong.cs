using UnityEngine;
using System.Collections;

namespace DingDong
{
	public class DingDong : MonoBehaviour
	{
		/*
		public bool cycleMode = false;

		Shader shader;
		RenderTexture renderTexture;
		Video video;
		Sound sound;

		void Start ()
		{
			shader = GetComponent<Shader>();
			renderTexture = GetComponentInChildren<RenderTexture>();
			video = GetComponentInChildren<Video>();
			sound = GetComponent<Sound>();
			// sound.LoadAudioClip();
		}

		void Update ()
		{
			UnityEngine.Shader.SetGlobalFloat("_TimeElapsed", Time.time);
			UnityEngine.Shader.SetGlobalFloat("_MouseX", Input.mousePosition.x / Screen.width);
			UnityEngine.Shader.SetGlobalFloat("_MouseY", Input.mousePosition.y / Screen.height);


	        if (video.movieTexture.isReadyToPlay && !video.movieTexture.isPlaying)
	        {
	            video.movieTexture.Play();
				// sound.SetAudioClip(video.movieTexture.audioClip);
	        }

	        if (video.movieTexture.isPlaying)
	        {
	        	sound.UpdateSamples();
	        }

			if (cycleMode)
			{
				if (shader.IsItTimeToChange())
				{
					shader.NextShader();
				}
			}

			if (Input.GetKeyDown(KeyCode.RightArrow))
			{
				shader.NextShader();
				// CheckSpecials();
			}

			if (Input.GetKeyDown(KeyCode.LeftArrow))
			{
				shader.PreviousShader();
				// CheckSpecials();
			}

			if (Input.GetKeyDown(KeyCode.Space))
			{
				// video.Toggle();
			}

			if (Input.GetKeyDown(KeyCode.Escape))
			{
				Application.Quit();
			}
		}*/
	}
}