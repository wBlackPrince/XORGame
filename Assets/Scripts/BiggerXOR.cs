using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiggerXOR{
    private bool inputA, inputB, inputC, output;

    public BiggerXOR(bool inputA = false,bool inputB = false, bool inputC = false){
        UpdateInputs(inputA, inputB, inputC);
    } //? конструктор



    public void UpdateInputs(bool inputA, bool inputB, bool inputC){
        this.inputA = inputA;
        this.inputB = inputB; 
        this.inputC = inputC;
        UpdateOutput(inputA, inputB, inputC);
    } //? получаем входные сигналы и на их основе создаем выходной сигнал

    private void UpdateOutput(bool inputA, bool inputB, bool inputC){
        bool xr = (!inputA && inputB) || (!inputB && inputA);
        this.output = (!xr && inputB) || (!inputB && xr);
    } //? новый входной сигнал
}
