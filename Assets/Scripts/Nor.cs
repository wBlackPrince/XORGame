using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nor{
    private bool inputA, inputB, output;

    public Nor(bool inputA = false,bool inputB = false){
        UpdateInputs(inputA, inputB);
    } //? конструктор



    public void UpdateInputs(bool inputA, bool inputB){
        this.inputA = inputA;
        this.inputB = inputB; 
        UpdateOutput(inputA, inputB);
    } //? получаем входные сигналы и на их основе создаем выходной сигнал

    private void UpdateOutput(bool inputA, bool inputB){
        this.output = !(inputA || inputB);
    } //? новый входной сигнал
}
