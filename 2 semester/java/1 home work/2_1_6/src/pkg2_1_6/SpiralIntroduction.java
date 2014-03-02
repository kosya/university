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
public class SpiralIntroduction {
    public SpiralIntroduction() {
        
    }
    
    public void spiralLook(int[][] matrix, int range) {
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
