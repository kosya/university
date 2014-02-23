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
public class StackElement {
    private int element;
    private StackElement next;
    
    public StackElement(int element, StackElement next) {
        this.element = element;
        this.next = next;
    }
    
    public int element() {
        return this.element;
    }
    
    public StackElement next() {
        return this.next;
    }
}
