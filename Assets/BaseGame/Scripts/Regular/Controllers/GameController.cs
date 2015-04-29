using System;
using System.Collections;
using Assets.PuzzleEd.Scripts.Regular.Framework;
using Assets.PuzzleEd.Scripts.Regular.General;
using Assets.PuzzleEd.Scripts.Regular.Managers;
using UnityEngine;

namespace Assets.PuzzleEd.Scripts.Regular.Controllers
{
    public class GameController : BaseGameController
    {
        #region Singleton
        private static GameController _instance;
        public static GameController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType(typeof(GameController)) as GameController;
                    
                    if (_instance == null)
                        _instance = new GameObject("GameController Temporary Instance", typeof(GameController)).GetComponent<GameController>();
                }
                return _instance;
            }
        }

        void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
            }
            else
            {
                if (this != _instance)
                    Destroy(this.gameObject);
            }
        }
        #endregion

        void Start()
        {
            DontDestroyOnLoad(_instance.gameObject);
        }

        public override void StartGame()
        {
            base.StartGame();
        }      
    }
}
