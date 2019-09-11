package Lab2;

import java.util.Scanner;

public class lab2bai3 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		int soDienSuDung, tienDien;
		System.out.print("so dien su dung cua thang: ");
		soDienSuDung = sc.nextInt();
		if (soDienSuDung < 50 && soDienSuDung > 0) {
			tienDien = soDienSuDung * 1000;
			System.out.println("tien dien phai tra la: " + tienDien);
		} else {
			tienDien = 50 * 1000 + (soDienSuDung - 50) * 1200;
			System.out.println("tien dien phai tra la: " + tienDien);
		}

	}

}
