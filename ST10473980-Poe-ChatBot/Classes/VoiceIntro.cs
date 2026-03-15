using System;
using System.Collections.Generic;
using System.Text;
using System.Media;

namespace ST10473980_Poe_ChatBot.Classes;

/// <summary>
/// Handles the voice introduction played when the chatbot starts.
/// This class loads an audio file and plays it using the SoundPlayer class.
/// </summary>
public class VoiceIntro
{
    /// <summary>
    /// Stores the file path of the audio file to be played.
    /// </summary>
    private readonly string soundFilePath = "Data/Audio/VoiceAudio.wav";

    /// <summary>
    /// SoundPlayer object used to play the audio file.
    /// </summary>
    private SoundPlayer player;

    /// <summary>
    /// Constructor that initialises the SoundPlayer
    /// with the specified audio file.
    /// </summary>
    public VoiceIntro()
    {
        player = new SoundPlayer(soundFilePath);
    }

    /// <summary>
    /// Plays the voice introduction sound.
    /// </summary>
    public void PlaySound()
    {
        player.Play();
    }
}