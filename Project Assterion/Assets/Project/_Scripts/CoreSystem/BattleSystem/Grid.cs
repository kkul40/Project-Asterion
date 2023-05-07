using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FighterTypes
{
    Healer,
    Wizard,
    Fighter,
}
public class Grid : MonoBehaviour
{
    private BattleSystem _battleSystem;

    public SpriteRenderer spriteRenderer;

    public Vector2 pos;

    public FighterTypes fighterType;

    private void Awake()
    {
        _battleSystem = GetComponent<BattleSystem>();
    }


    private void OnMouseEnter()
    {
        spriteRenderer.sprite = _battleSystem.playerManager.characters[0].GetComponent<SpriteRenderer>().sprite;
    }

    private void OnMouseExit()
    {
        spriteRenderer.sprite = null;
    }
}
