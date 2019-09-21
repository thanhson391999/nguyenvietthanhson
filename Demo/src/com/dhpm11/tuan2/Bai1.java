package com.dhpm11.tuan2;

import javax.swing.JFrame;

public class Bai1 extends JFrame {
	public Bai1() {
		setTitle("Demo Window");
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Bai1 dm = new Bai1();
		dm.setSize(400, 300);
		dm.setLocationRelativeTo(null);
		dm.setVisible(true);
	}

}
