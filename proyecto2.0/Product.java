package proyecto;

public class Product {

    protected String name;
    protected float price;
    protected int code;
    protected String brand;

    // Constructor sin parámetros
    public Product() {
        this.name = "";
        this.price = 0.0f;
        this.code = 0;
        this.brand = "";
    }

    // Constructor con nombre
    public Product(String name) {
        this.name = name;
        this.price = 0.0f;
        this.code = 0;
        this.brand = "";
    }

    // Constructor con nombre y precio
    public Product(String name, float price) {
        this.name = name;
        this.price = price;
        this.code = 0;
        this.brand = "";
    }

    public String getName() {
        return this.name;
    }

    public void setName(String newName) {
        this.name = newName;
    }

    public float getPrice() {
        return this.price;
    }

    public void setPrice(float newPrice) {
        this.price = newPrice;
    }

    public int getCode() {
        return this.code;
    }

    public void setCode(int newCode) {
        this.code = newCode;
    }

    public String getBrand() {
        return this.brand;
    }

    public void setBrand(String newBrand) {
        this.brand = newBrand;
    }

    public void showProduct() {
        System.out.println("NAME: " + this.name);
        System.out.println("PRICE: " + this.price);
        System.out.println("CODE: " + this.code);
        System.out.println("BRAND: " + this.brand);
    }

    @Override
    public String toString() {
        String exit = "product: ";
        exit += "NAME: " + this.name;
        exit += "PRICE: " + this.price;
        exit += "CODE: " + this.code;
        exit += "BRAND: " + this.brand;
        return exit;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) {
            return true;
        }
        if (o == null) {
            return false;
        }
        if (this.getClass() != o.getClass()) {
            return false;
        }
        Product aux = (Product) o;
        if (aux.price != this.price) {
            return false;
        }
        if (aux.name.equals(this.name) != true){
            return false;
        }
        return true;
    }
}