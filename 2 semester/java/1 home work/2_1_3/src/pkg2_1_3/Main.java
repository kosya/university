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
import java.util.Scanner;

public class Main {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int amount = 10;
        int[] array = new int[amount];
        
        for (int i = 0; i < amount; ++i) {
            if (scan.hasNextInt()) {
                array[i] = scan.nextInt();
            }
        }
        
        for (int i = 1; i < amount; ++i) {
            for (int j = 0; j < amount - i; ++j) {
                if (array[j] > array[j + 1]) {
                    int tmp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = tmp;
                }
            }
        }
        
        for (int i = 0; i < amount; ++i) {
            System.out.print(array[i] + " ");
        }
    }
    
}
