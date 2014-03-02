/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package pkg2_1_7;

/**
 *
 * @author Alex
 */
public class MatrixOutput {
    public MatrixOutput() {
        
    }
    
    public void out(int[][] matrix, int m, int n) {
        for (int i = 0; i < m; ++i) {
            if (i == 0) {
                for (int j = 0; j < n; ++j) {
                    System.out.print(" " + matrix[i][j] + " ");
                }
            }
            else {
                for (int j = 0; j < n; ++j) {
                    System.out.print(matrix[i][j] + " ");
                }
            }
            System.out.println();
        }
    }
}
