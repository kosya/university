/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package pkg2_2_2;

/**
 *
 * @author Alex
 */
public class ListElement {
    private int element;
    private ListElement next;
    private ListElement previous;
    
    public ListElement(int element, ListElement previous, ListElement next) {
        this.element = element;
        this.previous = previous;
        this.next = next;
    }
    
    public int element() {
        return this.element;
    }
    
    public ListElement next() {
        return this.next;
    }
    
    public ListElement previous() {
        return this.previous;
    }
    
    public void setElement(int element) {
        this.element = element;
    }
    
    public void setNext(ListElement next) {
        this.next = next;
    }
    
    public void setPrevious(ListElement previous) {
        this.previous = previous;
    }
}
