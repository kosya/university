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
import java.util.ArrayList;

public class HashTable {
    private int size;
    private List[] array = new List[size];;
    
    public HashTable(int size) {
        this.size = size;
        array = new List[size];
    }
    
    public int getHashKey(int number) {
        return number % this.size;
    }
    
    public boolean isEmpty() {
        for (int i = 0; i < this.size; ++i) {
            if (!this.array[i].isEmpty()) {
                return false;
            }
        }
        return true;
    }
    
    public void addElement(int element) {
        this.array[this.getHashKey(element)].addElement(element);
    }
    
    public void deleteElement(int element) {
        this.array[this.getHashKey(element)].deleteElement(element);
    }
    
    public boolean searchElement(int element) {
        return this.array[this.getHashKey(element)].searchElement(element);
    }
}
