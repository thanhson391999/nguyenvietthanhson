package Lab2;

import java.util.Scanner;

public class lab2bai2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		Double a, b, c, x1, x2, nghiem, delta, x;
		System.out.print("a: ");
		a = sc.nextDouble();
		System.out.print("b: ");
		b = sc.nextDouble();
		System.out.print("c: ");
		c = sc.nextDouble();
		if (a == 0) {
			if (b == 0) {
				if (c == 0) {
					System.out.println("phuong trinh vo so nghiem");
				} else {
					System.out.println("phuong trinh vo nghiem");
				}
			} else {
				nghiem = -c / b;
				System.out.println("nghiem: " + nghiem);
			}
		} else {
			delta = Math.pow(b, 2) - 4 * a * c;
			System.out.println("Delta: " + delta);
			if (delta < 0)
				System.out.println("phuong trinh vo nghiem");
			else if (delta == 0) {
				x = -b / (2 * a);
				System.out.print("phuong trinh nghiem kep x1=x2= " + x);
			} else {
				System.out.println("phuong trinh co 2 nghiem phan biet:");
				x1 = (-b + Math.sqrt(delta)) / (2 * a);
				System.out.println("x1 = " + x1);
				x2 = (-b - Math.sqrt(delta)) / (2 * a);
				System.out.println("x2 = " + x2);

			}
		}

	}

}
