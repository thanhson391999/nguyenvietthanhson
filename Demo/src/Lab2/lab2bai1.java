package Lab2;

import java.util.Scanner;

public class lab2bai1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		Double a, b, nghiem;
		System.out.print("a: ");
		a = sc.nextDouble();
		System.out.print("b: ");
		b = sc.nextDouble();
		if (a == 0) {
			if (b == 0) {
				System.out.println("phuong trinh vo so nghiem");
			} else {
				System.out.println("phuong trinh vo nghiem");
			}
		} else {
			nghiem = -b / a;
			System.out.println("nghiem: " + nghiem);
		}

	}

}
