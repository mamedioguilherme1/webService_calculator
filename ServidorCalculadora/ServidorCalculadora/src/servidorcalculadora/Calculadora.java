package servidorcalculadora;

import javax.jws.WebService;

@WebService(serviceName = "CalculadoraServiceSW")
public class Calculadora {

    public double mult(double x, double y) {
        return (x * y);
    }

    public double div(double x, double y) {
        return (x / y);
    }

    public double sum(double x, double y) {
        return (x + y);
    }

    public double sub(double x, double y) {
        return (x - y);
    }

    public double mod(double x, double y) {
        return (x % y);
    }

    public double pow(double x, double y) {
        return (Math.pow(x, y));
    }

    public double sqt(double x) {
        return (Math.sqrt(x));
    }
    
    public double log(double x) {
        return (Math.log(x));
    }
}
