/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package pkg2_1_2;

/**
 *
 * @author Alex
 */
import java.util.Scanner;

public class Main {

    /**
     * @param args the command line arguments
     */
    public static int fib(int n) {
        int f1 = 1;
        int f2 = 1;
        for (int i = 3; i <= n; ++i) {
            int tmp = f2;
            f2 = f2 + f1;
            f1 = tmp;
        }
        return f2;
    }
    
    public static void main(String[] args) {
        int n = 0;
        int result = 0;
        
        Scanner scan = new Scanner(System.in);
        
        if (scan.hasNextInt()) {
            n = scan.nextInt();
        }
        result = fib(n);
        System.out.println(result);
    }
    
}
