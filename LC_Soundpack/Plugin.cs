using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using LCSoundTool;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC_Soundpack
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string modGUID = "Slam.SlamsBonanzaSoundPack";
        private const string modName = "Slam's Bonanza Sound Pack";
        private const string modVersion = "0.1.1";

        private readonly Harmony harmony = new Harmony(modGUID);
        private static Plugin instance;
        public ManualLogSource mls;

        void Awake()
        {
            if (instance == null) { instance = this; }

            mls = BepInEx.Logging.Logger.CreateLogSource(nameof(modGUID));
            mls.LogInfo("Slam's Bonanza Sound Pack!");

            AudioClip JackInTheBoxTheme = SoundTool.GetAudioClip("Slam-SlamsBonanzaSoundPack", "JackInTheBoxTheme.mp3");
            AudioClip Pop1 = SoundTool.GetAudioClip("Slam-SlamsBonanzaSoundPack", "Pop1.mp3");            
            AudioClip Chitter1 = SoundTool.GetAudioClip("Slam-SlamsBonanzaSoundPack", "Chitter1.wav");
            AudioClip Chitter2 = SoundTool.GetAudioClip("Slam-SlamsBonanzaSoundPack", "Chitter2.wav");
            AudioClip Chitter3 = SoundTool.GetAudioClip("Slam-SlamsBonanzaSoundPack", "Chitter3.wav");
            AudioClip AngryScreech = SoundTool.GetAudioClip("Slam-SlamsBonanzaSoundPack", "AngryScreech.wav");
            AudioClip AngryScreech2 = SoundTool.GetAudioClip("Slam-SlamsBonanzaSoundPack", "AngryScreech2.wav");
            AudioClip BugDie = SoundTool.GetAudioClip("Slam-SlamsBonanzaSoundPack", "BugDie.wav");
            AudioClip ShovelHitDefault = SoundTool.GetAudioClip("Slam-SlamsBonanzaSoundPack", "ShovelHitDefault.wav");
            AudioClip ShovelHitDefault2 = SoundTool.GetAudioClip("Slam-SlamsBonanzaSoundPack", "ShovelHitDefault2.wav");
            AudioClip DropMetalObject3 = SoundTool.GetAudioClip("Slam-SlamsBonanzaSoundPack", "DropMetalObject3.wav");
            AudioClip AirHorn1 = SoundTool.GetAudioClip("Slam-SlamsBonanzaSoundPack", "AirHorn1.wav");
            AudioClip AirHornFar = SoundTool.GetAudioClip("Slam-SlamsBonanzaSoundPack", "AirHornFar.wav");

            SoundTool.ReplaceAudioClip("JackInTheBoxTheme", JackInTheBoxTheme);
            SoundTool.ReplaceAudioClip("Pop1", Pop1);
            SoundTool.ReplaceAudioClip("Chitter1", Chitter1);
            SoundTool.ReplaceAudioClip("Chitter2", Chitter2);
            SoundTool.ReplaceAudioClip("Chitter3", Chitter3);
            SoundTool.ReplaceAudioClip("AngryScreech", AngryScreech);
            SoundTool.ReplaceAudioClip("AngryScreech2", AngryScreech2);
            SoundTool.ReplaceAudioClip("BugDie", BugDie);
            SoundTool.ReplaceAudioClip("ShovelHitDefault", ShovelHitDefault);
            SoundTool.ReplaceAudioClip("ShovelHitDefault2", ShovelHitDefault2);
            SoundTool.ReplaceAudioClip("DropMetalObject3", DropMetalObject3);
            SoundTool.ReplaceAudioClip("AirHorn1", AirHorn1);
            SoundTool.ReplaceAudioClip("AirHornFar", AirHornFar);

            harmony.PatchAll(typeof(Plugin));
        }
    }
}
