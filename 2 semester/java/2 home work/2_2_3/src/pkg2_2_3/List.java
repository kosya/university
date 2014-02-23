/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package pkg2_2_3;

/**
 *
 * @author Alex
 */
public class List {
    private ListElement head;
    private ListElement tail;
    
    public List() {
        this.head = head;
        this.tail = tail;
    }
    
    public boolean isEmpty() {
        return tail == null;
    }
    
    public void addElement(int element) {
        ListElement tmp = new ListElement(element, this.tail, null);
        if (this.isEmpty()) {
            this.head = tmp;
            this.tail = tmp;
        } else {
            this.tail.setNext(tmp);
            this.tail = tmp;
        }
    }
    
    public boolean searchElement(int element) {
        ListElement iterator = this.head;
        while (iterator != null) {
            if (iterator.element() == element) {
                return true;
            }
            iterator = iterator.next();
        }
        return false;
    }
    
    public ListElement searchListElement(int element) {
        ListElement iterator = this.head;
        while (iterator != null) {
            if (iterator.element() == element) {
                return iterator;
            }
            iterator = iterator.next();
        }
        return null;
    }
    
    public void deleteElement(int element) {
        ListElement tmp = this.searchListElement(element);
        if (tmp != null) {
            tmp.previous().setNext(tmp.next());
            tmp.next().setPrevious(tmp.previous());
        }
    }
    
    public void printList() {
        ListElement iterator = this.head;
        while (iterator != null) {
            System.out.println(iterator.element());
            iterator = iterator.next();
        }
    }
}
