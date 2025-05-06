package proyecto;

public class ExpirationProduct extends Product {
    protected int expirationDate;

    public ExpirationProduct(String name) {
        super(name);
    }

    public ExpirationProduct(String name, float price) {
        super(name, price);
        this.code = 0;
    }

    public int getExpirationDate() {
        return this.expirationDate;
    }
    
    public void setExpirationDate(int date) {
        this.expirationDate = date;
    }
    @Override
    public void showProduct() {
        super.showProduct();
        System.out.println("Expiration date: " + this.expirationDate);
    }
}
