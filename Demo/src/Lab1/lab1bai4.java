package Lab1;
import java.util.Scanner;

public class lab1bai4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		Double a, b, c, delta, canDelta;
		System.out.print("a: ");
		a = sc.nextDouble();
		System.out.print("b: ");
		b = sc.nextDouble();
		System.out.print("c: ");
		c = sc.nextDouble();
		delta = Math.pow(b, 2) - 4 * a * c;
		System.out.println("Delta: " + delta);
		canDelta = Math.sqrt(delta);
		if (delta >= 0)
			System.out.println("canDelta: " + canDelta);
		else
			System.out.println("canDelta : delta phai la so duong");

	}

}
