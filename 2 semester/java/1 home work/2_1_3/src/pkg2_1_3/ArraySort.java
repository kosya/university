/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package pkg2_1_3;

/**
 *
 * @author Alex
 */
public class ArraySort {
    public ArraySort() {
        
    }
    
    public void arraySort(int[] array, int amount) {
        for (int i = 1; i < amount; ++i) {
            for (int j = 0; j < amount - i; ++j) {
                if (array[j] > array[j + 1]) {
                    int tmp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = tmp;
                }
            }
        }
    }
}
