using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Singleton
//  - 접근이 쉬워야 함. (static) ✅
//  - 파괴 되지 않아야 하고 (DontDestroy) ✅
//  - 게임 내에서 딱 하나만 존재하도록 함. ✅

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
                DontDestroyOnLoad(_instance.gameObject);
            }

            return _instance;
        }
    }

    private void Awake() => SetSingleton();
    
    // 씬 전환 + 데이터 전달
    public void StartBattle()
    {
        SceneManager.LoadScene("BattleScene");
    }

    private void SetSingleton()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
