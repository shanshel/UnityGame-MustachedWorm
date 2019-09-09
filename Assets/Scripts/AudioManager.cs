﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static EnumsData;

public class AudioManager : MonoBehaviour
{

    public static AudioManager inst;
    public AudioSource eatSFX, levelUpSFX, levelUp2SFX, bodyBreakSFX, failSFX;
    public AudioSource inGameMusic, mainMenuMusic, gameOverMusic;
    private void Awake()
    {
        inst = this;
    }

    public void playSFX(SFXEnum sfx)
    {

        if (sfx == SFXEnum.eating)
            eatSFX.Play();
        else if (sfx == SFXEnum.levelUp)
        {
            levelUpSFX.Play();
        }
        else if (sfx == SFXEnum.levelUp2)
        {
            levelUp2SFX.Play();
        }
        else if (sfx == SFXEnum.bodyBreak)
        {
            bodyBreakSFX.Play();
        }
        else  if (sfx == SFXEnum.fail)
        {
            failSFX.Play();
        }

    }


    public void playMusic(MusicEnum music)
    {
        if(music == MusicEnum.inGameMusic)
        {
            mainMenuMusic.Stop();
            gameOverMusic.Stop();
            inGameMusic.Play();
        }
        else if (music == MusicEnum.mainManuMusic)
        {
            inGameMusic.Stop();
            gameOverMusic.Stop();
            mainMenuMusic.Play();
        }
        else
        {
            inGameMusic.Stop();
            mainMenuMusic.Stop();
            gameOverMusic.Play();
        }
    }


}
