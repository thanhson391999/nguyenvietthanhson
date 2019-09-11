package Lab1;
import java.util.Scanner;
public class lab1bai2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Double dai,rong,chuVi,dienTich,canhNho;
		Scanner sc = new Scanner(System.in);
		System.out.print("chieu dai : ");
		dai=sc.nextDouble();
		System.out.print("chieu rong: ");
		rong=sc.nextDouble();
		chuVi=(dai+rong)*2;
		System.out.println("chu vi hcn: "+chuVi);
		dienTich=dai*rong;
		System.out.println("dien tich hcn: "+dienTich);
		canhNho=Math.min(dai,rong);
		System.out.println("canh nho hcn: "+canhNho);
	}

}
