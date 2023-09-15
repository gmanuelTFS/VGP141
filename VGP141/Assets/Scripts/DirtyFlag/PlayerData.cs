using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    private int _level;
    private string _name;

    private bool _dirtyFlag;

    public int Level
    {
        get
        {
            return _level;
        }
        set
        {
            if (value == _level)
            {
                return;
            }

            _level = value;
            PlayerPrefs.SetInt("level", _level);
            _dirtyFlag = true;
        }
    }

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (value == _name)
            {
                return;
            }

            _name = value;
            PlayerPrefs.SetString("name", _name);
            _dirtyFlag = true;
        }
    }

    private void Start()
    {
        _level = PlayerPrefs.GetInt("level", 0);
        _name = PlayerPrefs.GetString("name");
    }

    public void Save()
    {
        if (_dirtyFlag)
        {
            Debug.Log("Saving...");
            PlayerPrefs.Save();
            Debug.Log("Game saved.");
            _dirtyFlag = false;
        }
        else
        {
            Debug.Log("Nothing to save.");
        }
    }

    public void IncrementLevel()
    {
        ++Level;
    }

    public void DecrementLevel()
    {
        if (Level - 1 <= 0)
        {
            Level = 0;
            return;
        }

        --Level;
    }

    public void SetName(string name)
    {
        Name = name;
    }
}