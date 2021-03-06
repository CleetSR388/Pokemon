﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour {

    public Battlemenu currentMenu;
    public Battlemenu Selection;

    [Header("Selection")]
    public GameObject SelectionMenu;
    public GameObject SelectionInfo;
    public Text selectionInfoText;
    public Text fight;
    private string fightT;
    public Text bag;
    private string bagT;
    public Text pokemon;
    private string pokemonT;
    public Text run;
    private string runT;

    [Header("Moves")]
    public GameObject movesMenu;
    public GameObject movesDetails;
    public Text PP;
    public Text pType;
    public Text moveO;
    private string moveOT;
    public Text moveT;
    private string moveTT;
    public Text moveTH;
    private string moveTHT;
    public Text movef;
    private string movefT;


    [Header("Info")]
    public GameObject InfoMenu;
    public Text InfoText;

    [Header("Misc")]
    public int currentSelection;

	void Start () {
        fightT = fight.text;
        bagT = bag.text;
        pokemonT = pokemon.text;
        runT = run.text;
        moveOT = moveO.text;
        moveTT = moveT.text;
        moveTHT = moveTH.text;
        movefT = movef.text;
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (currentSelection < 4)
            {
                currentSelection++;
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (currentSelection > 0)
            {
                currentSelection--;
            }

        }
        if (currentSelection == 0)
            currentSelection = 1;

        switch (currentMenu)
        {
            case Battlemenu.Fight:
                switch (currentSelection)
                {
                    case 1:
                        moveO.text = "> " + moveO.text;
                        moveT.text = moveTT;
                        moveTH.text = moveTHT;
                        movef.text = movefT;
                        break;
                    case 2:
                        moveO.text = moveO.text;
                        moveT.text = "> " + moveTT;
                        moveTH.text = moveTHT;
                        movef.text = movefT;
                        break;
                    case 3:
                        moveO.text = moveO.text;
                        moveT.text = moveTT;
                        moveTH.text = "> " + moveTHT;
                        movef.text = movefT;
                        break;
                    case 4:
                        moveO.text = moveO.text;
                        moveT.text = moveTT;
                        moveTH.text = moveTHT;
                        movef.text = "> " + movefT;
                        break;
                }


                break;

        switch (currentMenu)
                { 

                    case Battlemenu.Selection:
                        switch (currentSelection)
                        {
                            case 1:
                                moveO.text = "> " + moveOT;
                                moveT.text = moveTT;
                                moveTH.text = moveTHT;
                                movef.text = movefT;
                                break;
                            case 2:
                                moveO.text = moveO.text;
                                moveT.text = "> " + moveTT;
                                moveTH.text = moveTHT;
                                movef.text = movefT;
                                break;
                            case 3:
                                moveO.text = moveOT;
                                moveT.text = moveTT;
                                moveTH.text = "> " + moveTHT;
                                movef.text = movefT;
                                break;
                            case 4:
                                moveO.text = moveOT;
                                moveT.text = moveTT;
                                moveTH.text = moveTHT;
                                movef.text = "> " + movefT;
                                break;
                        }

                }
        }
    }
        public void ChangeMenu(Battlemenu m)
    {
        currentMenu = m;
        currentSelection = 1;
        switch(m)
        {
            case Battlemenu.Selection:
                SelectionMenu.gameObject.SetActive(true);
                SelectionInfo.gameObject.SetActive(true);
                movesMenu.gameObject.SetActive(false);
                movesDetails.gameObject.SetActive(false);
                InfoMenu.gameObject.SetActive(false);
                break;
            case Battlemenu.Fight:
                SelectionMenu.gameObject.SetActive(false);
                SelectionInfo.gameObject.SetActive(false);
                movesMenu.gameObject.SetActive(true);
                movesDetails.gameObject.SetActive(true);
                InfoMenu.gameObject.SetActive(true);
                break;
            case Battlemenu.Info:
                SelectionMenu.gameObject.SetActive(false);
                SelectionInfo.gameObject.SetActive(false);
                movesMenu.gameObject.SetActive(false);
                movesDetails.gameObject.SetActive(false);
                InfoMenu.gameObject.SetActive(true);
                break;
        }
    }

    public enum Battlemenu
    {
        Selection,
        Pokemon,
        Bag,
        Fight,
        Info
    }
}
