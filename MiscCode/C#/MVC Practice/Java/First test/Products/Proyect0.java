package proyecto;

import java.util.Scanner;

public class Proyect0 {
    public static void main(String[] args) {
        Scanner scn = new Scanner(System.in);

        Product p1 = new Product();
        p1.name = "Coke 1.5L";
        p1.price = 12345678;
        p1.code = 1;
        p1.brand = "Coca-Cola Company.";

        System.out.println("Product data:");
        System.out.println("NAME: " + p1.name);
        System.out.println("PRICE: " + p1.price);
        System.out.println("CODE: " + p1.code);
        System.out.println("BRAND: " + p1.brand);

        System.out.println("Name of the product: ");
        p1.name = scn.next();
    }
}