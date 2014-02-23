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
import java.util.ArrayList;

public class StackArray implements IStack {
    private ArrayList<Integer> array;
    
    public StackArray() {
       this.array = new ArrayList<Integer>();
    }
    
    public void push(int element) {
        this.array.add(element);
    }
    
    public int pop() {
        if (!this.array.isEmpty()) {
            int tmp = this.array.get(this.array.size() - 1);
            return tmp;
        } else {
            return -999;
        }
    }
    
    public int amountOfElements() {
        return this.array.size();
    }
}
