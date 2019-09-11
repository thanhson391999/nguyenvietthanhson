package Lab2;

import java.util.Scanner;

public class lab2bai4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		System.out.println("chon chuc nang : ");
		int chon = sc.nextInt();
		int n;
		do {
			System.out.println("+------------------------+");
			System.out.println("1.giai PT bac 1");
			System.out.println("2.giai PT bac 2");
			System.out.println("3.tinh tien dien");
			System.out.println("4.ket thuc");
			System.out.println("+------------------------+");
			n=sc.nextInt();

			switch (n) {
			case 1:
				giaiptbac1();
				break;
			case 2:
				giaiptbac2();
				break;
			case 3:
				tinhtiendien();
				break;
			default:
				ketthuc();
				break;
			}
		} while (n != 0);
		

		
 
 
		
	}

}
