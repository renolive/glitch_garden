using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	private int currentTrack;
	private AudioSource player;
	
	public enum Tracks {START_MENU = 1};
	public AudioClip [] soundTracks;

	#region Custom Methods
	void getComponentsFindObjects () {
		player = GetComponent<AudioSource>();
	}
		
	void playSoundTrack (int track) {
		player.clip = soundTracks[track];
		player.Play();
		player.volume = PlayerPrefsManager.GetMasterVolume();
	}
	#endregion

	void Awake () {
		DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start () {
		getComponentsFindObjects();
	}

	void OnLevelWasLoaded (int level) {
		playSoundTrack(level);
	}
}
