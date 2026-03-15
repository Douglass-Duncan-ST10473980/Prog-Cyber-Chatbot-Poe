using System;
using System.Collections.Generic;
using System.Text;
using System.Media;

namespace ST10473980_Poe_ChatBot.Classes;
public class VoiceIntro
{
    private readonly string soundFilePath= "Data/Audio/VoiceAudio.wav";
    private SoundPlayer player;

   public VoiceIntro()
    {
        player=new SoundPlayer(soundFilePath);
    }

    public void PlaySound()
    {
        player.Play();
    }
}

