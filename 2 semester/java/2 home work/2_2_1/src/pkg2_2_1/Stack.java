/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package pkg2_2_1;

/**
 *
 * @author Alex
 */
public class Stack {
    private StackElement head;
    
    public Stack() {
        head = null;
    }
    
    public boolean isEmpty() {
        return this.head == null;
    }
    
    public void push(int element) {
        StackElement tmp = new StackElement(element, this.head);
        this.head = tmp;
    }
    
    public int pop() {
        if (this.isEmpty()) {
            return -999;
        } else {
            int tmp = this.head.element();
            this.head = this.head.next();
            return tmp;
        }
    }
    
    public void printStack() {
        StackElement iterator = this.head;
        while (iterator != null) {
            System.out.println(iterator.element());
            iterator = iterator.next();
        }
    }
}
