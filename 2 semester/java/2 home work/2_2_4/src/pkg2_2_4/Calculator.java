/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package pkg2_2_4;

/**
 *
 * @author Alex
 */
public class Calculator {
    private String str;
    private IStack stack;
    
    public Calculator (String str, IStack stack) {
        this.str = str;
        this.stack = stack;
    }
    
    public void addition() {
        this.stack.push(this.stack.pop() + this.stack.pop());
    }
    
    public void substraction() {
        this.stack.push(this.stack.pop() - this.stack.pop());
    }
    
    public void multiplication() {
        this.stack.push(this.stack.pop() * this.stack.pop());
    }
    
    public void division() {
        int tmp1 = this.stack.pop();
        int tmp2 = this.stack.pop();
        if (tmp2 != 0) {
            this.stack.push(tmp1 / tmp2);
        }
    }
    
    public int calculate() {
        String[] splitNumbers = str.split("+-/*");
        for (int i = 1; i <= splitNumbers.length; ++i) {
            this.stack.push(Integer.parseInt(splitNumbers[splitNumbers.length - i]));
        }
        
        String[] splitOperations = str.split("0123456789");
        
        for (int i = 0; i < splitOperations.length; ++i) {
            switch(Integer.parseInt(splitOperations[i])) {
                case '+' :  
                    if (splitOperations[i + 1] != "*" && splitOperations[i + 1] != "/") {
                        this.addition();
                    } else {
                        int tmp = this.stack.pop();
                        if (splitOperations[i + 1] == "*") {
                            this.multiplication();
                            this.stack.push(tmp + this.stack.pop());
                        } else {
                            this.division();
                            this.stack.push(tmp + this.stack.pop());
                        }     
                    }
                    break;
                case '-' :
                     if (splitOperations[i + 1] != "*" && splitOperations[i + 1] != "/") {
                        this.substraction();
                    } else {
                        int tmp = this.stack.pop();
                        if (splitOperations[i + 1] == "*") {
                            this.multiplication();
                            this.stack.push(tmp - this.stack.pop());
                        } else {
                            this.division();
                            this.stack.push(tmp - this.stack.pop());
                        }     
                    }
                    break;
                case '*' :
                    this.multiplication();
                    break;
                case '/' :
                    this.division();
                    break;
            }
        }
        return stack.pop();
    } 
}
