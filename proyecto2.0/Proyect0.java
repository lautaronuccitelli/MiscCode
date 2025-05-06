package proyecto;

import java.util.Scanner;

public class Proyect0 {

    public static void main(String[] args) {
    Scanner scn = new Scanner(System.in);

        Product p1 = new Product();
        p1.setName("Coke 1.5L");
        p1.setPrice(12345678);
        p1.setCode(1);
        p1.setBrand("Coca-Cola Company.");
        System.out.println(p1);
/*
        System.out.println("Product data:");
        System.out.println("NAME: " + p1.getName());
        System.out.println("PRICE: " + p1.getPrice());
        System.out.println("CODE: " + p1.getCode());
        System.out.println("BRAND: " + p1.getBrand());

        System.out.println("Name of the product: ");
        p1.setName(scn.nextLine());
        System.out.println("Price of the product: ");
  .      p1.setPrice(scn.nextFloat());
        System.out.println("Code of the product: ");
        p1.setCode(scn.nextInt());
        scn.nextLine();
        System.out.println("Brand of the product: ");
        p1.setBrand(scn.nextLine());

        System.out.println("Updated NAME: " + p1.getName());
        System.out.println("Updated PRICE: " + p1.getPrice());
        System.out.println("Updated CODE: " + p1.getCode());
        System.out.println("Updated BRAND: " + p1.getBrand());
        
        */
        
    }
}
