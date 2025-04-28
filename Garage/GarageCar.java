package lugar.de.estacionamiento;


public class Car {
    private String carModel;
    private String carPlate;
    private String phone;

    
    public Car (String carPlate, String phone, String carModel){
        this.carPlate = carPlate;
        this.phone = phone;
        this.carModel=carModel;
    }

    public String getCarPlate(){
        return carPlate;
    }
    public String getPhone(){
        return phone;
    }
    public String getCarModel(){
    return carModel;
    }

    public String toString(){
        return  carModel +  ", Plate = " + carPlate + ", Phone = " + phone + ". ";
    }
}

package lugar.de.estacionamiento;


public class Place {
    private String name;

    public Place(String name){
        this.name = name;
    }

    public String getName(){
        return name;
    }

    public String toString(){
        return "Name = " + name + ". ";
    }
}

package lugar.de.estacionamiento;


public class Garage {
    private Car car;
    private Place place;
    private String enter;
    private String exit;

    public Garage(Car car, Place place, String enter){
        this.car = car;
        this.place = place;
        this.enter = enter;
        
    }

    public void getExit(String exit){
          this.exit = exit;
    }

    public String toString(){
        return "Garage: Car = " + car + "Place: " + place + "Enter = " + enter + ", Exit = " + exit + ".";

    }
}

package lugar.de.estacionamiento;


public class LugarDeEstacionamiento {

   
    public static void main(String[] args) {
        Car car1 = new Car("ABC 123","223412413411234", "Honda");
        Place Place1 = new Place("A1");

        Garage garage = new Garage(car1, Place1, "08:00");
        

        garage.getExit("17:00");
        System.out.println("Car Registered: " + garage);

    }
    
}