using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysOn{
    private bool input, output;

    public AlwaysOn(bool input = false){
        UpdateInputs(input);
        output = true;
    } //? конструктор



    public void UpdateInputs(bool input){
        this.input = input;
    } //? получаем входные сигналы

}