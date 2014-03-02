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
public class MatrixSort {
    public MatrixSort() {
        
    }
    
    public void sort(int[][] matrix, int m, int n) {
        for (int i = 1; i < n; ++i) {
            for (int j = 0; j < n - i; ++j) {
                if (matrix[0][j] > matrix[0][j + 1]) {
                    for (int l = 0; l < m; ++l) {
                        int tmp = matrix[l][j];
                        matrix[l][j] = matrix[l][j + 1];
                        matrix[l][j + 1] = tmp;
                    }
                }
            }
        }
    }
}
