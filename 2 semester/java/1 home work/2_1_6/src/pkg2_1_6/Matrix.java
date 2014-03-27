/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package pkg2_1_6;

/**
 *
 * @author Alex
 */
public class Matrix {
    /**
     * <p>Initialize matrix elements</p>
     * @param matrix given matrix
     * @param range matrix range
     */
    static public void initialization(int[][] matrix, int range) {
        for (int i = 0; i < range; ++i) {
            if (i == 0) {
                for (int j = 0; j < range; ++j) {
                    matrix[j][i] = i * 10 + j; 
                    System.out.print(" " + matrix[j][i] + " ");
                }
            } else {
                for (int j = 0; j < range; ++j) {
                    matrix[j][i] = i * 10 + j; 
                    System.out.print(matrix[j][i] + " ");
                }
            }
            System.out.println();
        }
    }
    
    /**
     * Method, which writes out matrix elements in spiral way
     * @param matrix given matrix
     * @param range matrix range
     */
    static public void spiralLook(int[][] matrix, int range) {
        int x = range / 2;
        int y = range / 2;
        int step = 0;
        
        System.out.print(y * 10 + x + " ");
        step++;
        y--;
        while (step != range / 2 + 1) {
            for (int i = 1; i <= step * 2; ++i) {
                System.out.print(y * 10 + x + " ");
                x--;
            }
            
            x++;
            y++;
            for (int i = 1; i <= step * 2; ++i) {
                System.out.print(y * 10 + x + " ");
                y++;
            }
            
            y--;
            x++;
            for (int i = 1; i <= step * 2; ++i) {
                System.out.print(y * 10 + x + " ");
                x++;
            }
            
            x--;
            y--;
            for (int i = 1; i <= step * 2; ++i) {
                System.out.print(y * 10 + x + " ");
                y--;
            }
            step++;
        }
    }
}
