﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end_handler : MonoBehaviour
{
    public GameObject Basic_UI;
    
    // Game object onde o game manager está
    private GameObject manager_object;

    // Game object onde o save options está
    private GameObject save_options;
    // boleana para o input da tela
    
    void Start(){
        // acha game manager com tag
        manager_object = GameObject.FindWithTag("Game_manager");

        // pega save options com via função do game manager
        save_options = manager_object.GetComponent<Game_Manager>().Get_save_options();


       
    }

    // Função para terminar o jogo
    public void End_Game()
    {
        Call_Save();
        Disable_player_input();
        Disable_general_ui();
        Explode_player();
        Stop_time();
        ShowAdd();
        Call_End_Screen();
    }

    // Save Score
    private void Call_Save()
    {
        // Get the score value from the player
        float score = manager_object.GetComponent<Game_Manager>().Get_height();

        // Save the score value in memory
        save_options.GetComponent<save>().salvar(score.ToString(), "save_score_endereço");
    }

    // Disable user input
    private void Disable_player_input(){
        //desabilita boleana do input la no scrip movimento
        movimentação.input_consider = false;

    }

    //! Disable general UI
    private void Disable_general_ui(){
        //TODO: Call disable ui routine
        Basic_UI.SetActive(false);
        Basic_UI.GetComponent<Canvas>().enabled = false;
    }

    // Change Player sprite to explosion
    private void Explode_player(){
        //TODO: Call player change sprite
    }

    //! Stop time in a good manner
    private void Stop_time(){
        //TODO: Create gradual time shift to zero
        // Time.time = 0; // Time.time é uma variável só de leitura. Para zerá-la seria necessário criar uma nova variável para assumir seu lugar (x = Time.time; x = 0) 
        // Dessa forma é possível zerar o tempo relativo do jogo e reiniciá-lo ao começar de novo o jogo
        Time.timeScale = 0f;
    }

    // Show Intersticial add
    private void ShowAdd(){
        //TODO: Implement the add 
    }

    // Show End screen menu
    private void Call_End_Screen(){
        //TODO: Implement the end screen menu
    }

}
