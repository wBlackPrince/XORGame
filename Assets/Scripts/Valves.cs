using UnityEngine;
class Nand{
    public Node inputA, inputB, output;

    public Nand(Transform inA,Transform inB,Transform outp,bool a = false, bool b = false){
        inputA = new Node(inA);
        inputB = new Node(inB);
        output = new Node(outp);
        SetInputs(a,b);
    }

    public void SetInputs(bool a, bool b){
        
        inputA.ChangeState(a);
        inputB.ChangeState(b);
        SetOutput();
    }

    private void SetOutput(){
        bool a = inputA.GetState();
        bool b = inputA.GetState();
        output.ChangeState(!(a && b));
    }
}


class Or{
    public Node inputA, inputB, output;

    public Or(Transform inA,Transform inB,Transform outp,bool a = false, bool b = false){
        inputA = new Node(inA);
        inputB = new Node(inB);
        output = new Node(outp);
        SetInputs(a,b);
    }

    public void SetInputs(bool a, bool b){
        
        inputA.ChangeState(a);
        inputB.ChangeState(b);
        SetOutput();
    }

    private void SetOutput(){
        bool a = inputA.GetState();
        bool b = inputA.GetState();
        output.ChangeState(a || b);
    }
}


class Nor{
    public Node inputA, inputB, output;

    public Nor(Transform inA,Transform inB,Transform outp,bool a = false, bool b = false){
        inputA = new Node(inA);
        inputB = new Node(inB);
        output = new Node(outp);
        SetInputs(a,b);
    }

    public void SetInputs(bool a, bool b){
        
        inputA.ChangeState(a);
        inputB.ChangeState(b);
        SetOutput();
    }

    private void SetOutput(){
        bool a = inputA.GetState();
        bool b = inputA.GetState();
        output.ChangeState(!(a || b));
    }
}


class AlwaysOn{
    public Node inputA, inputB, output;

    public AlwaysOn(Transform inA,Transform inB,Transform outp,bool a = false, bool b = false){
        inputA = new Node(inA);
        inputB = new Node(inB);
        output = new Node(outp, true);
        SetInputs(a,b);
    }

    public void SetInputs(bool a, bool b){
        
        inputA.ChangeState(a);
        inputB.ChangeState(b);
    }
}


