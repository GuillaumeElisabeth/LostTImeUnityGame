﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SaveController : MonoBehaviour {

    

    public void SaveCurrentGameConfig(string CurrentScene)
    {
        if(PlayerPrefs.GetString("CurrentSaveStateUsed") == "SaveStateOne")
        {
            PlayerPrefs.SetFloat("SaveStateOneAstridPositionX", GameObject.Find("AstridPlayer").transform.position.x);
            PlayerPrefs.SetFloat("SaveStateOneAstridPositionY", GameObject.Find("AstridPlayer").transform.position.y + 1); // +1 pour éviter que astrid ne tombe sous la map au prochain chargement du niveau
            PlayerPrefs.SetFloat("SaveStateOneAstridPositionZ", GameObject.Find("AstridPlayer").transform.position.z);
            PlayerPrefs.SetFloat("SaveStateOneAstridRotationX", GameObject.Find("AstridPlayer").transform.rotation.x);
            PlayerPrefs.SetFloat("SaveStateOneAstridRotationY", GameObject.Find("AstridPlayer").transform.rotation.y);
            PlayerPrefs.SetFloat("SaveStateOneAstridRotationZ", GameObject.Find("AstridPlayer").transform.rotation.z);
            PlayerPrefs.SetFloat("SaveStateOneTimer", GameObject.Find("Sun").GetComponent<Timer>().CurrentTimeOfDay);
            PlayerPrefs.SetString("SaveStateOneCurrentScene", CurrentScene);
        }

        if (PlayerPrefs.GetString("CurrentSaveStateUsed") == "SaveStateTwo")
        {
            PlayerPrefs.SetFloat("SaveStateTwoAstridPositionX", GameObject.Find("AstridPlayer").transform.position.x);
            PlayerPrefs.SetFloat("SaveStateTwoAstridPositionY", GameObject.Find("AstridPlayer").transform.position.y + 1); // +1 pour éviter que astrid ne tombe sous la map au prochain chargement du niveau
            PlayerPrefs.SetFloat("SaveStateTwoAstridPositionZ", GameObject.Find("AstridPlayer").transform.position.z);
            PlayerPrefs.SetFloat("SaveStateTwoAstridRotationX", GameObject.Find("AstridPlayer").transform.rotation.x);
            PlayerPrefs.SetFloat("SaveStateTwoAstridRotationY", GameObject.Find("AstridPlayer").transform.rotation.y);
            PlayerPrefs.SetFloat("SaveStateTwoAstridRotationZ", GameObject.Find("AstridPlayer").transform.rotation.z);
            PlayerPrefs.SetFloat("SaveStateTwoTimer", GameObject.Find("Sun").GetComponent<Timer>().CurrentTimeOfDay);
            PlayerPrefs.SetString("SaveStateTwoCurrentScene", CurrentScene);
        }

        if (PlayerPrefs.GetString("CurrentSaveStateUsed") == "SaveStateThree")
        {
            PlayerPrefs.SetFloat("SaveStateThreeAstridPositionX", GameObject.Find("AstridPlayer").transform.position.x);
            PlayerPrefs.SetFloat("SaveStateThreeAstridPositionY", GameObject.Find("AstridPlayer").transform.position.y + 1); // +1 pour éviter que astrid ne tombe sous la map au prochain chargement du niveau
            PlayerPrefs.SetFloat("SaveStateThreeAstridPositionZ", GameObject.Find("AstridPlayer").transform.position.z);
            PlayerPrefs.SetFloat("SaveStateThreeAstridRotationX", GameObject.Find("AstridPlayer").transform.rotation.x);
            PlayerPrefs.SetFloat("SaveStateThreeAstridRotationY", GameObject.Find("AstridPlayer").transform.rotation.y);
            PlayerPrefs.SetFloat("SaveStateThreeAstridRotationZ", GameObject.Find("AstridPlayer").transform.rotation.z);
            PlayerPrefs.SetFloat("SaveStateThreeTimer", GameObject.Find("Sun").GetComponent<Timer>().CurrentTimeOfDay);
            PlayerPrefs.SetString("SaveStateThreeCurrentScene", CurrentScene);
        }
    }

    public void InitialisePlayerSaveState(string SaveState)
    {
        if (PlayerPrefs.GetString("CurrentSaveStateUsed") == SaveState)
        {
            PlayerPrefs.SetFloat("SaveStateOneAstridPositionX", 5.0f);
            PlayerPrefs.SetFloat("SaveStateOneAstridPositionY", 1f + 1); // +1 pour éviter que astrid ne tombe sous la map au prochain chargement du niveau
            PlayerPrefs.SetFloat("SaveStateOneAstridPositionZ", 25f);
            PlayerPrefs.SetFloat("CurrentAstridPositionX", 5.0f);
            PlayerPrefs.SetFloat("CurrentAstridPositionY", 1f + 1); // +1 pour éviter que astrid ne tombe sous la map au prochain chargement du niveau
            PlayerPrefs.SetFloat("CurrentAstridPositionZ", 25f);
            PlayerPrefs.SetInt("SaveStateOneCycle", 0);
            PlayerPrefs.SetInt("SaveStateOneFragments", 0);
            PlayerPrefs.SetFloat("SaveStateOneTimer", 0f);
            PlayerPrefs.SetString("SaveStateOneLastScene", "LostTimeGearDistrict");
        }

        if (PlayerPrefs.GetString("CurrentSaveStateUsed") == SaveState)
        {
            PlayerPrefs.SetFloat("SaveStateTwoAstridPositionX", 5.0f);
            PlayerPrefs.SetFloat("SaveStateTwoAstridPositionY", 1f + 1); // +1 pour éviter que astrid ne tombe sous la map au prochain chargement du niveau
            PlayerPrefs.SetFloat("SaveStateTwoAstridPositionZ", 25f);
            PlayerPrefs.SetFloat("CurrentAstridPositionX", 5.0f);
            PlayerPrefs.SetFloat("CurrentAstridPositionY", 1f + 1); // +1 pour éviter que astrid ne tombe sous la map au prochain chargement du niveau
            PlayerPrefs.SetFloat("CurrentAstridPositionZ", 25f);
            PlayerPrefs.SetInt("SaveStateTwoCycle", 0);
            PlayerPrefs.SetInt("SaveStateTwoFragments", 0);
            PlayerPrefs.SetFloat("SaveStateTwoTimer", 0f);
            PlayerPrefs.SetString("SaveStateTwoLastScene", "LostTimeGearDistrict");
        }

        if (PlayerPrefs.GetString("CurrentSaveStateUsed") == SaveState)
        {
            PlayerPrefs.SetFloat("SaveStateThreeAstridPositionX", 5.0f);
            PlayerPrefs.SetFloat("SaveStateThreeAstridPositionY", 1f + 1); // +1 pour éviter que astrid ne tombe sous la map au prochain chargement du niveau
            PlayerPrefs.SetFloat("SaveStateThreeAstridPositionZ", 25f);
            PlayerPrefs.SetFloat("CurrentAstridPositionX", 5.0f);
            PlayerPrefs.SetFloat("CurrentAstridPositionY", 1f + 1); // +1 pour éviter que astrid ne tombe sous la map au prochain chargement du niveau
            PlayerPrefs.SetFloat("CurrentAstridPositionZ", 25f);
            PlayerPrefs.SetInt("SaveStateThreeCycle", 0);
            PlayerPrefs.SetInt("SaveStateThreeFragments", 0);
            PlayerPrefs.SetFloat("SaveStateThreeTimer", 0f);
            PlayerPrefs.SetString("SaveStateThreeLastScene", "LostTimeGearDistrict");
        }
    }

    public void SaveFragmentsPlayer()
    {
        if (PlayerPrefs.GetString("CurrentSaveStateUsed") == "SaveStateOne")
        {
            int tmp = PlayerPrefs.GetInt("SaveStateOneFragments");
                tmp += 1;
            PlayerPrefs.SetInt("SaveStateOneFragments", tmp);
        }

        if (PlayerPrefs.GetString("CurrentSaveStateUsed") == "SaveStateTwo")
        {
            int tmp = PlayerPrefs.GetInt("SaveStateTwoFragments");
            tmp += 1;
            PlayerPrefs.SetInt("SaveStateTwoFragments", tmp);
        }

        if (PlayerPrefs.GetString("CurrentSaveStateUsed") == "SaveStateThree")
        {
            int tmp = PlayerPrefs.GetInt("SaveStateThreeFragments");
            tmp += 1;
            PlayerPrefs.SetInt("SaveStateThreeFragments", tmp);
        }
    }

    public void SaveCyclePlayer()
    {
        if (PlayerPrefs.GetString("CurrentSaveStateUsed") == "SaveStateOne")
        {
            int tmp = PlayerPrefs.GetInt("SaveStateOneCycle");
            tmp += 1;
            PlayerPrefs.SetInt("SaveStateOneCycle", tmp);
        }

        if (PlayerPrefs.GetString("CurrentSaveStateUsed") == "SaveStateTwo")
        {
            int tmp = PlayerPrefs.GetInt("SaveStateThreeCycle");
            tmp += 1;
            PlayerPrefs.SetInt("SaveStateTwoCycle", tmp);
        }

        if (PlayerPrefs.GetString("CurrentSaveStateUsed") == "SaveStateThree")
        {
            int tmp = PlayerPrefs.GetInt("SaveStateThreeCycle");
            tmp += 1;
            PlayerPrefs.SetInt("SaveStateThreeCycle", tmp);
        }
    }

    public void LoadSceneAstridPosition(float AstridPositionX, float AstridPositionY, float AstridPositionZ, string NextScene)
    {
        PlayerPrefs.SetFloat("CurrentAstridPositionX", AstridPositionX);
        PlayerPrefs.SetFloat("CurrentAstridPositionY", AstridPositionY);
        PlayerPrefs.SetFloat("CurrentAstridPositionZ", AstridPositionZ);
        PlayerPrefs.SetString("CurrentScene", NextScene);
        SceneManager.LoadScene(NextScene);
    }

    public void LoadGame(string SaveState)
    {
        if (PlayerPrefs.GetString("CurrentSaveStateUsed") == SaveState)
        {
            PlayerPrefs.SetFloat("CurrentAstridPositionX", PlayerPrefs.GetFloat("SaveStateOneAstridPositionX"));
            PlayerPrefs.SetFloat("CurrentAstridPositionY", PlayerPrefs.GetFloat("SaveStateOneAstridPositionY"));
            PlayerPrefs.SetFloat("CurrentAstridPositionZ", PlayerPrefs.GetFloat("SaveStateOneAstridPositionZ"));
        }

        if (PlayerPrefs.GetString("CurrentSaveStateUsed") == SaveState)
        {
            PlayerPrefs.SetFloat("CurrentAstridPositionX", PlayerPrefs.GetFloat("SaveStateTwoAstridPositionX"));
            PlayerPrefs.SetFloat("CurrentAstridPositionY", PlayerPrefs.GetFloat("SaveStateTwoAstridPositionY"));
            PlayerPrefs.SetFloat("CurrentAstridPositionZ", PlayerPrefs.GetFloat("SaveStateTwoAstridPositionZ"));
        }

        if (PlayerPrefs.GetString("CurrentSaveStateUsed") == SaveState)
        {
            PlayerPrefs.SetFloat("CurrentAstridPositionX", PlayerPrefs.GetFloat("SaveStateThreeAstridPositionX"));
            PlayerPrefs.SetFloat("CurrentAstridPositionY", PlayerPrefs.GetFloat("SaveStateThreeAstridPositionY"));
            PlayerPrefs.SetFloat("CurrentAstridPositionZ", PlayerPrefs.GetFloat("SaveStateThreeAstridPositionZ"));
        }
    }
}
