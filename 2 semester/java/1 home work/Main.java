/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package pkg2_1_1;

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
        Scanner sc = new Scanner(System.in); // создаём объект класса Scanner
        int n = 0;
        int result = 1;
        
        if (sc.hasNextInt()) { // возвращает истинну если с потока ввода можно считать целое число
            n = sc.nextInt(); // считывает целое число с потока ввода и сохраняем в переменную
        }
        
        for (int i = 2; i <= n; ++i) {
            result *= i;
        }
        
        System.out.println(result);
    }
    
}
