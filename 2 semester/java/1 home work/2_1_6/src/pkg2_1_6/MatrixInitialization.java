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
public class MatrixInitialization {
    public MatrixInitialization() {    
    }
    
    public void initialization(int[][] matrix, int range) {
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
}
