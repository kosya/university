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
public class Matrix {
    /**
     * <p>Initialize matrix</p>
     * @param matrix given matrix
     * @param m amount of rows
     * @param n amount of columns
     */
    static public void initialize(int[][] matrix, int m, int n) {
         for (int i = 0; i < m; ++i) {
            if (i == 0) {
                for (int j = 0; j < n; ++j) {
                    matrix[i][j] = i * 10 + 9 - j;
                    System.out.print(" " + matrix[i][j] + " ");
                }
            }
            else {
                for (int j = 0; j < n; ++j) {
                    matrix[i][j] = i * 10 + 9 - j;
                    System.out.print(matrix[i][j] + " ");
                }
            }
            System.out.println();
        }
    }
    
    /**
     * <p>Method, which writes out a matrix</p>
     * @param matrix given matrix
     * @param m amount of rows
     * @param n amount of columns
     */
    static public void out(int[][] matrix, int m, int n) {
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
    
    /**
     * <p>Method, which sorts matrix</p>
     * @param matrix given matrix
     * @param m amount of rows
     * @param n amount of columns
     */
    static public void sort(int[][] matrix, int m, int n) {
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
