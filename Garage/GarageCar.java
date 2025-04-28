class Car {
    private String carPlate;
    private String phone;

    public Car (String carPlate, String phone){
        this.carPlate = carPlate;
        this.phone = phone;
    }

    public String getCarPlate(){
        return carPlate;
    }
    public String getPhone(){
        return phone;
    }

    public String toString(){
        return "Car: Plate = " + carPlate + ", Phone = " + phone + ".";
    }
}

class Place {
    private String name;

    public Place(String name){
        this.name = name;
    }

    public String getName(){
        return name;
    }

    public String toString(){
        return "Place: Name = " + name + ".";
    }
}

class Garage {
    private Car car;
    private Place place;
    private String enter;
    private String exit;

    public Garage(Car car, Place place, String enter){
        this.car = car;
        this.place = place;
        this.enter = enter;
        this.exit = exit;
    }

    public void getExit(String exit){

    }

    public String toString(){
        return "Garage: Car = " + car + "Place = " + place + "Enter = " + enter + "Exit = " + exit + ".";

    }
} 

public class GarageCar{
    public static void main (String[] args){
        Car car1 = new Car("ABC 123", "22233344455");
        Place Place1 = new Place("A1");

        Garage garage = new Garage(car1, Place1, "08:00");
        System.out.println("Registered entry: " + garage);

        garage.getExit("17:00");
        System.out.println("Registered entry: " + garage);
    }
}